using IndieGameZone.Application.Hub;
using IndieGameZone.Application.IHub;
using IndieGameZone.Application.IServices;
using IndieGameZone.Domain.Constants;
using IndieGameZone.Domain.Entities;
using IndieGameZone.Domain.Exceptions;
using IndieGameZone.Domain.IRepositories;
using IndieGameZone.Domain.RequestFeatures;
using IndieGameZone.Domain.RequestsAndResponses.Requests.Transactions;
using IndieGameZone.Domain.RequestsAndResponses.Responses.Notifications;
using IndieGameZone.Domain.RequestsAndResponses.Responses.Transactions;
using MapsterMapper;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.SignalR;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Net.payOS;
using Net.payOS.Types;

namespace IndieGameZone.Application.Services
{
	internal sealed class TransactionService : ITransactionService
	{
		private readonly IRepositoryManager repositoryManager;
		private readonly IMapper mapper;
		private readonly IConfiguration configuration;
		private readonly IRecombeeService recombeeService;
		private readonly UserManager<Users> userManager;
		private readonly IHubContext<NotificationHub, INotificationHub> notificationHub;

		public TransactionService(IRepositoryManager repositoryManager, IMapper mapper, IConfiguration configuration, IRecombeeService recombeeService, UserManager<Users> userManager, IHubContext<NotificationHub, INotificationHub> notificationHub)
		{
			this.repositoryManager = repositoryManager;
			this.mapper = mapper;
			this.configuration = configuration;
			this.recombeeService = recombeeService;
			this.userManager = userManager;
			this.notificationHub = notificationHub;
		}

		private async Task<string> GetPayOSPaymentLink(Transactions transaction, TransactionType transactionType)
		{
			var clientId = configuration.GetSection("PayOSClientID").Value;
			var apiKey = configuration.GetSection("PayOSAPIKey").Value;
			var checksumKey = configuration.GetSection("PayOSChecksumKey").Value;

			var domain = "https://indie-game-zone.vercel.app/";

			var payOS = new PayOS(clientId, apiKey, checksumKey);

			// Determine item name based on transaction type
			string itemName = transactionType switch
			{
				TransactionType.Deposit => "Wallet Deposit",
				TransactionType.PurchaseGame => "Game Purchase",
				TransactionType.PurchaseCommercialPackage => "Commercial Package Purchase",
				TransactionType.Donation => "Donation",
				_ => "Unknown Transaction"
			};

			var paymentLinkRequest = new PaymentData(
				orderCode: (long)transaction.OrderCode,
				amount: (int)transaction.Amount,
				description: transaction.Description,
				items: [new(itemName, 1, (int)transaction.Amount)],
				cancelUrl: domain + "?canceled=true",
				returnUrl: domain + "?success=true"
			);
			var response = await payOS.createPaymentLink(paymentLinkRequest);

			return response.checkoutUrl;
		}

		private async Task<double> GetGamePriceAfterApplyingCoupon(Games game, Guid? couponId, CancellationToken ct = default)
		{
			var discount = await repositoryManager.DiscountRepository.GetActiveDiscountByGameId(game.Id, false, ct);
			double gamePriceAfterDiscount = discount is not null ? game.Price - game.Price * discount.Percentage / 100 : game.Price; ;
			if (couponId != null)
			{
				var coupon = await repositoryManager.CouponRepository.GetCouponById((Guid)couponId, true, ct);
				if (coupon == null)
				{
					throw new NotFoundException("Coupon does not exist");
				}
				else if (coupon.EndDate < DateOnly.FromDateTime(DateTime.Now))
				{
					throw new BadRequestException("This coupon has expired");
				}
				else if (coupon.IsUsed)
				{
					throw new BadRequestException("This coupon has already been used");
				}
				gamePriceAfterDiscount -= gamePriceAfterDiscount * coupon.Percentage / 100;
				coupon.IsUsed = true;
			}
			return gamePriceAfterDiscount;
		}

		private async Task<long> GenerateUniqueOrderCodeAsync(CancellationToken ct)
		{
			Random random = new Random();
			long orderCode;

			do
			{
				orderCode = random.Next(100000, 999999);
			}
			while (await repositoryManager.TransactionRepository.IsOrderCodeExistsAsync(orderCode, ct));

			return orderCode;
		}

		private async Task CheckGameAchievements(Guid userId, CancellationToken ct = default)
		{
			int libraryCount = await repositoryManager.LibraryRepository.GetLibraryByUserId(userId, false).CountAsync(ct);
			var userAchievements = repositoryManager.UserAchievementRepository.GetUserAchievementsByUserId(userId, false, ct);

			var achievement = await repositoryManager.AchievementRepository.GetAchievementByLevelAndType(libraryCount, AchievementType.GamePurchase, false, ct);
			if (achievement == null || userAchievements.Any(u => u.AchievementId == achievement.Id))
			{
				return;
			}
			repositoryManager.UserAchievementRepository.AddUserAchievement(new UserAchievements
			{
				UserId = userId,
				AchievementId = achievement.Id
			});
			var notification = new Notifications
			{
				Id = Guid.NewGuid(),
				UserId = userId,
				Message = $"Congratulations! You have earned the {achievement.Name} achievement and receive a {achievement.DiscountAward}% discount.",
				IsRead = false,
				CreatedAt = DateTime.Now
			};
			repositoryManager.NotificationRepository.CreateNotification(notification);
			repositoryManager.CouponRepository.CreateCoupon(new Coupons
			{
				Id = Guid.NewGuid(),
				Code = Guid.NewGuid().ToString(),
				Percentage = achievement.DiscountAward,
				IsUsed = false,
				EndDate = DateOnly.FromDateTime(DateTime.Now.AddDays(7)),
				UserId = userId
			});
			await repositoryManager.SaveAsync(ct);
			await notificationHub.Clients.User(userId.ToString()).SendNotification(new NotificationForReturnDto
			{
				Id = notification.Id,
				Message = notification.Message,
				IsRead = notification.IsRead,
			});
		}

		public async Task<string> CreateTransactionForDeposit(Guid userId, TransactionForDepositCreationDto transaction, CancellationToken ct = default)
		{
			var user = await userManager.Users.AsNoTracking().SingleOrDefaultAsync(u => u.Id == userId);
			if (user == null)
				throw new NotFoundException("User not found");
			var transactionEntity = mapper.Map<Transactions>(transaction);
			transactionEntity.Id = Guid.NewGuid();
			transactionEntity.UserId = userId;
			transactionEntity.PurchaseUserId = userId;
			transactionEntity.OrderCode = await GenerateUniqueOrderCodeAsync(ct);
			transactionEntity.Description = "Deposit to wallet";
			transactionEntity.Status = TransactionStatus.Pending;
			transactionEntity.Type = TransactionType.Deposit;
			transactionEntity.PaymentMethod = PaymentMethod.PayOS;
			transactionEntity.CreatedAt = DateTime.Now;
			repositoryManager.TransactionRepository.CreateTransaction(transactionEntity);

			await repositoryManager.SaveAsync(ct);
			return await GetPayOSPaymentLink(transactionEntity, TransactionType.Deposit);
		}

		public async Task<string> CreateTransactionForGamePurchase(Guid userId, Guid gameId, TransactionForGameCreation transactionForGameCreation, CancellationToken ct = default)
		{
			var dbTransaction = await repositoryManager.BeginTransaction(ct);
			var user = await userManager.Users.AsNoTracking().SingleOrDefaultAsync(u => u.Id == userId);
			if (user == null)
				throw new NotFoundException("User not found");
			var game = await repositoryManager.GameRepository.GetGameById(gameId, false, ct);
			if (game == null)
				throw new NotFoundException("Game not found");
			var wallet = await repositoryManager.WalletRepository.GetWalletByUserId(userId, true, ct);
			var discount = await repositoryManager.DiscountRepository.GetActiveDiscountByGameId(gameId, false, ct);
			double gamePriceAfterDiscount = await GetGamePriceAfterApplyingCoupon(game, transactionForGameCreation.CouponId);

			if (transactionForGameCreation.PaymentMethod == PaymentMethod.Wallet)
			{
				if (wallet.Balance < gamePriceAfterDiscount)
				{
					throw new NotEnoughCreditException("You don't have enough points");
				}
			}

			var order = new Orders
			{
				Id = Guid.NewGuid(),
				Amount = gamePriceAfterDiscount,
				UserId = userId,
				GameId = gameId,
				CouponId = transactionForGameCreation.CouponId,
				CreatedAt = DateTime.Now
			};

			var transactionEntity = new Transactions()
			{
				Id = Guid.NewGuid(),
				UserId = userId,
				PurchaseUserId = userId,
				GameId = gameId,
				OrderCode = await GenerateUniqueOrderCodeAsync(ct),
				Amount = gamePriceAfterDiscount,
				Description = $"Purchase game",
				CreatedAt = DateTime.Now,
				Type = TransactionType.PurchaseGame,
				Status = transactionForGameCreation.PaymentMethod == PaymentMethod.PayOS ? TransactionStatus.Pending : TransactionStatus.Success,
				PaymentMethod = transactionForGameCreation.PaymentMethod,
				OrderId = order.Id
			};
			repositoryManager.OrderRepository.CreateOrder(order);
			repositoryManager.TransactionRepository.CreateTransaction(transactionEntity);

			if (transactionForGameCreation.PaymentMethod == PaymentMethod.Wallet)
			{
				var devWallet = await repositoryManager.WalletRepository.GetWalletByUserId(game.DeveloperId, true, ct);
				var adminWallet = await repositoryManager.WalletRepository.GetWalletByUserId(Guid.Parse("e5d8947f-6794-42b6-ba67-201f366128b8"), true, ct);

				// Update balances for player wallet
				wallet.Balance -= gamePriceAfterDiscount;

				// Add game to library
				var libraryEntity = new Libraries
				{
					UserId = userId,
					GameId = gameId,
					PurchasedAt = DateTime.Now
				};
				repositoryManager.LibraryRepository.AddGameToLibrary(libraryEntity);

				// Create transactions for developer and update balance
				var transactionForDeveloper = new Transactions()
				{
					Id = Guid.NewGuid(),
					UserId = game.DeveloperId,
					PurchaseUserId = userId,
					GameId = gameId,
					OrderCode = null,
					Amount = gamePriceAfterDiscount * 0.8, // 80% to developer
					Description = $"80% of purchase transaction for game {game.Name} for developer",
					CreatedAt = DateTime.Now,
					Type = TransactionType.PurchaseGameRevenue,
					Status = TransactionStatus.Success,
					PaymentMethod = PaymentMethod.Wallet
				};
				devWallet.Balance += transactionForDeveloper.Amount;
				repositoryManager.TransactionRepository.CreateTransaction(transactionForDeveloper);

				// Create transaction for system (admin) and update balance
				var transactionForSystem = new Transactions()
				{
					Id = Guid.NewGuid(),
					UserId = Guid.Parse("e5d8947f-6794-42b6-ba67-201f366128b8"),
					PurchaseUserId = userId,
					GameId = gameId,
					OrderCode = null,
					Amount = gamePriceAfterDiscount * 0.2, // 80% to developer
					Description = $"20% of purchase transaction for game {game.Name} for system",
					CreatedAt = DateTime.Now,
					Type = TransactionType.PurchaseGameRevenue,
					Status = TransactionStatus.Success,
					PaymentMethod = PaymentMethod.Wallet
				};
				adminWallet.Balance += transactionForSystem.Amount;
				repositoryManager.TransactionRepository.CreateTransaction(transactionForSystem);

				await repositoryManager.SaveAsync(ct);
				await recombeeService.SendPurchaseEvent(userId, gameId);

				await CheckGameAchievements(userId);
				dbTransaction.Commit();
				return string.Empty;
			}
			else
			{
				await repositoryManager.SaveAsync(ct);
				dbTransaction.Commit();
				return await GetPayOSPaymentLink(transactionEntity, TransactionType.PurchaseGame);
			}
		}

		public async Task<string> CreateTransactionForDonation(Guid userId, Guid gameId, TransactionForDonationCreationDto transactionForDonationCreationDto, CancellationToken ct = default)
		{
			var dbTransaction = await repositoryManager.BeginTransaction(ct);
			var user = await userManager.Users.AsNoTracking().SingleOrDefaultAsync(u => u.Id == userId);
			var wallet = await repositoryManager.WalletRepository.GetWalletByUserId(userId, true, ct);
			if (user == null)
				throw new NotFoundException("User not found");
			var game = await repositoryManager.GameRepository.GetGameById(gameId, false, ct);
			if (game == null)
			{
				throw new NotFoundException("Game not found");
			}
			if (transactionForDonationCreationDto.PaymentMethod == PaymentMethod.Wallet)
			{
				if (wallet.Balance < transactionForDonationCreationDto.Amount)
				{
					throw new NotEnoughCreditException("You don't have enough points");
				}
			}
			var transactionEntityForDonor = new Transactions()
			{
				Id = Guid.NewGuid(),
				UserId = userId,
				PurchaseUserId = userId,
				OrderCode = await GenerateUniqueOrderCodeAsync(ct),
				GameId = gameId,
				Amount = transactionForDonationCreationDto.Amount,
				Description = $"Donation",
				CreatedAt = DateTime.Now,
				Type = TransactionType.Donation,
				Status = transactionForDonationCreationDto.PaymentMethod == PaymentMethod.PayOS ? TransactionStatus.Pending : TransactionStatus.Success,
				PaymentMethod = transactionForDonationCreationDto.PaymentMethod,
			};
			repositoryManager.TransactionRepository.CreateTransaction(transactionEntityForDonor);

			if (transactionForDonationCreationDto.PaymentMethod == PaymentMethod.Wallet)
			{
				var devWallet = await repositoryManager.WalletRepository.GetWalletByUserId(game.DeveloperId, true, ct);

				// Update balances for player wallet
				wallet.Balance -= transactionEntityForDonor.Amount;


				// Create transactions for developer and update balance
				var transactionForDeveloper = new Transactions()
				{
					Id = Guid.NewGuid(),
					UserId = game.DeveloperId,
					PurchaseUserId = userId,
					GameId = gameId,
					OrderCode = null,
					Amount = transactionForDonationCreationDto.Amount,
					Description = $"80% of purchase transaction for game {game.Name} for developer",
					CreatedAt = DateTime.Now,
					Type = TransactionType.PurchaseGameRevenue,
					Status = TransactionStatus.Success,
					PaymentMethod = PaymentMethod.Wallet
				};
				devWallet.Balance += transactionForDeveloper.Amount;
				repositoryManager.TransactionRepository.CreateTransaction(transactionForDeveloper);

				await repositoryManager.SaveAsync(ct);
				dbTransaction.Commit();
				return string.Empty;
			}
			else
			{
				await repositoryManager.SaveAsync(ct);
				dbTransaction.Commit();
				return await GetPayOSPaymentLink(transactionEntityForDonor, TransactionType.Donation);
			}

		}

		public async Task<(IEnumerable<TransactionForReturnDto> transactions, MetaData metaData)> GetTransactions(TransactionParameters transactionParameters, CancellationToken ct = default)
		{
			var transactionsWithMetaData = await repositoryManager.TransactionRepository.GetTransactions(transactionParameters, false, ct);
			var transactions = mapper.Map<IEnumerable<TransactionForReturnDto>>(transactionsWithMetaData);
			return (transactions, transactionsWithMetaData.MetaData);
		}

		public async Task<(IEnumerable<TransactionForReturnDto> transactions, MetaData metaData)> GetTransactionsByUserId(Guid userId, TransactionParameters transactionParameters, CancellationToken ct = default)
		{
			var transactionsWithMetaData = await repositoryManager.TransactionRepository.GetTransactionsByUserId(userId, transactionParameters, false, ct);
			var transactions = mapper.Map<IEnumerable<TransactionForReturnDto>>(transactionsWithMetaData);
			return (transactions, transactionsWithMetaData.MetaData);
		}

		public async Task IPNAsync(WebhookData webhookData, bool isSuccess, CancellationToken ct = default)
		{
			var transaction = await repositoryManager.TransactionRepository.GetTransactionById(webhookData.orderCode, true, ct);
			var order = await repositoryManager.OrderRepository.GetOrderById((Guid)transaction.OrderId, false, ct);

			if (isSuccess)
			{
				if (transaction.Type == TransactionType.Deposit)
				{
					var wallet = await repositoryManager.WalletRepository.GetWalletByUserId(transaction.UserId, true, ct);
					wallet.Balance += transaction.Amount;

					repositoryManager.NotificationRepository.CreateNotification(new Notifications
					{
						Id = Guid.NewGuid(),
						UserId = transaction.UserId,
						Message = $"You have successfully added {transaction.Amount} points to your wallet",
						CreatedAt = DateTime.Now,
						IsRead = false
					});
				}
				else if (transaction.Type == TransactionType.Donation)
				{
					var game = await repositoryManager.GameRepository.GetGameById((Guid)transaction.GameId!, false, ct);
					var developerId = transaction.Game.DeveloperId;
					var developerWallet = await repositoryManager.WalletRepository.GetWalletByUserId(developerId, true, ct);

					var transactionEntityForDeveloper = new Transactions()
					{
						Id = Guid.NewGuid(),
						UserId = game.DeveloperId,
						PurchaseUserId = transaction.UserId,
						OrderCode = null,
						GameId = game.Id,
						Amount = transaction.Amount,
						Description = $"Donation money for game {game.Name} for developer",
						CreatedAt = DateTime.Now,
						Type = TransactionType.DonationRevenue,
						Status = TransactionStatus.Success,
						PaymentMethod = PaymentMethod.PayOS,
					};
					developerWallet.Balance += transactionEntityForDeveloper.Amount;
					repositoryManager.TransactionRepository.CreateTransaction(transactionEntityForDeveloper);
				}
				else if (transaction.Type == TransactionType.PurchaseGame)
				{
					var game = await repositoryManager.GameRepository.GetGameById((Guid)transaction.GameId!, false, ct);
					var gamePriceAfterDiscount = await GetGamePriceAfterApplyingCoupon(game, order.CouponId, ct);
					var developerId = transaction.Game.DeveloperId;
					var devWallet = await repositoryManager.WalletRepository.GetWalletByUserId(developerId, true, ct);
					var adminWallet = await repositoryManager.WalletRepository.GetWalletByUserId(Guid.Parse("e5d8947f-6794-42b6-ba67-201f366128b8"), true, ct);

					// Addgame to library
					var libraryEntity = new Libraries
					{
						UserId = transaction.UserId,
						GameId = (Guid)transaction.GameId,
						PurchasedAt = DateTime.Now
					};
					repositoryManager.LibraryRepository.AddGameToLibrary(libraryEntity);

					// Create transactions for developer and update balance
					var transactionForDeveloper = new Transactions()
					{
						Id = Guid.NewGuid(),
						UserId = game.DeveloperId,
						PurchaseUserId = transaction.UserId,
						GameId = game.Id,
						OrderCode = null,
						Amount = gamePriceAfterDiscount * 0.8, // 80% to developer
						Description = $"80% of purchase for game {game.Name} for developer",
						CreatedAt = DateTime.Now,
						Type = TransactionType.PurchaseGameRevenue,
						Status = TransactionStatus.Success,
						PaymentMethod = PaymentMethod.PayOS
					};
					devWallet.Balance += transactionForDeveloper.Amount;
					repositoryManager.TransactionRepository.CreateTransaction(transactionForDeveloper);

					// Create transaction for system (admin) and update balance
					var transactionForSystem = new Transactions()
					{
						Id = Guid.NewGuid(),
						UserId = Guid.Parse("e5d8947f-6794-42b6-ba67-201f366128b8"),
						PurchaseUserId = transaction.UserId,
						GameId = game.Id,
						OrderCode = await GenerateUniqueOrderCodeAsync(ct),
						Amount = gamePriceAfterDiscount * 0.2, // 20% to admin
						Description = $"20% of purchase for game {game.Name} for system",
						CreatedAt = DateTime.Now,
						Type = TransactionType.PurchaseGameRevenue,
						Status = TransactionStatus.Success,
						PaymentMethod = PaymentMethod.PayOS
					};
					adminWallet.Balance += transactionForSystem.Amount;
					repositoryManager.TransactionRepository.CreateTransaction(transactionForSystem);

					await CheckGameAchievements(transaction.UserId);
					await recombeeService.SendPurchaseEvent(transaction.UserId, (Guid)transaction.GameId);
				}
				else if (transaction.Type == TransactionType.PurchaseCommercialPackage)
				{
					var adminWallet = await repositoryManager.WalletRepository.GetWalletByUserId(Guid.Parse("e5d8947f-6794-42b6-ba67-201f366128b8"), true, ct);
					var commercialRegistration = new CommercialRegistrations()
					{
						Id = Guid.NewGuid(),
						StartDate = (DateOnly)order.CommercialRegistrationStartDate!,
						EndDate = order.CommercialRegistrationEndDate,
						CreatedAt = DateTime.Now,
						Status = CommercialRegistrationStatus.Pending,
						GameId = (Guid)transaction.GameId!,
						CommercialPackageId = (Guid)order.CommercialPackageId!,
					};
					repositoryManager.CommercialRegistrationRepository.CreateCommercialRegistration(commercialRegistration);

					var transactionForSystem = new Transactions
					{
						Id = Guid.NewGuid(),
						UserId = Guid.Parse("e5d8947f-6794-42b6-ba67-201f366128b8"),
						PurchaseUserId = transaction.UserId,
						OrderCode = null,
						Amount = transaction.Amount,
						Description = $"Purchase for commercial package with a specific period of time",
						CreatedAt = DateTime.Now,
						Type = TransactionType.PurchaseCommercialPackageRevenue,
						Status = TransactionStatus.Success,
						PaymentMethod = PaymentMethod.Wallet
					};
					adminWallet.Balance += transactionForSystem.Amount;
					repositoryManager.TransactionRepository.CreateTransaction(transactionForSystem);
				}

				transaction.Status = TransactionStatus.Success;
			}
			else
			{
				transaction.Status = TransactionStatus.Failed;
			}

			await repositoryManager.SaveAsync(ct);
		}

		public async Task<string> CreateTransactionForCommercialPurchase(Guid userId, Guid gameId, Guid commercialPackageId, TransactionForCommercialDto dto, CancellationToken ct = default)
		{
			// Validate user and wallet
			var user = await userManager.Users
				.Include(u => u.UserProfile).AsSplitQuery()
				.Include(u => u.Wallet).AsSplitQuery()
				.FirstOrDefaultAsync(u => u.Id == userId, ct);
			if (user == null)
				throw new NotFoundException("User not found");

			var wallet = await repositoryManager.WalletRepository.GetWalletByUserId(userId, true, ct)
				?? throw new NotFoundException("User wallet not found");

			// Validate game ownership
			var game = await repositoryManager.GameRepository.GetGameById(gameId, false, ct);
			if (game == null)
				throw new NotFoundException("Game not found.");
			if (game.DeveloperId != userId)
				throw new BadRequestException("You can only purchase a commercial package for your own public game.");

			// Validate package
			var package = await repositoryManager.CommercialPackageRepository.GetCommercialPackageById(commercialPackageId, false, ct)
				?? throw new NotFoundException("Commercial package not found");

			if (dto.StartDate < DateOnly.FromDateTime(DateTime.Today))
			{
				throw new BadRequestException("Start date must be today or a future date.");
			}

			// Check date availability (for both Wallet & PayOS)
			var relevantRegistrations = await repositoryManager.CommercialRegistrationRepository
				.GetRelevantRegistrationsForDateCheckAsync(package.Type, game.CategoryId, ct);

			var dateCounter = new Dictionary<DateOnly, int>();
			var gameSpecificDates = new HashSet<DateOnly>();

			foreach (var reg in relevantRegistrations)
			{
				if (reg.GameId == gameId)
				{
					for (var date = reg.StartDate; date < reg.EndDate!.Value; date = date.AddDays(1))
						gameSpecificDates.Add(date);
				}

				for (var date = reg.StartDate; date < reg.EndDate!.Value; date = date.AddDays(1))
				{
					if (!dateCounter.ContainsKey(date))
						dateCounter[date] = 0;

					dateCounter[date]++;
				}
			}

			var unavailableDates = new HashSet<DateOnly>();

			foreach (var kvp in dateCounter)
			{
				if ((package.Type == CommercialPackageType.HomepageBanner && kvp.Value >= 10) ||
					(package.Type == CommercialPackageType.CategoryBanner && kvp.Value >= 10))
				{
					unavailableDates.Add(kvp.Key);
				}
			}

			// Also block if already registered by this game
			foreach (var d in gameSpecificDates)
				unavailableDates.Add(d);

			// 🔍 Now validate the selected date range
			var selectedDates = Enumerable
				.Range(0, package.Duration)
				.Select(i => dto.StartDate.AddDays(i));

			if (selectedDates.Any(d => unavailableDates.Contains(d)))
			{
				throw new BadRequestException("Selected start date leads to overlapping or full registration period. Please choose another start date.");
			}

			// Check wallet balance
			if (dto.PaymentMethod == PaymentMethod.Wallet)
			{
				if (wallet.Balance < package.Price)
					throw new NotEnoughCreditException("You don't have enough wallet points to purchase this package.");
			}
			var order = new Orders
			{
				Id = Guid.NewGuid(),
				Amount = package.Price,
				UserId = userId,
				GameId = gameId,
				CommercialPackageId = commercialPackageId,
				CommercialRegistrationStartDate = dto.StartDate,
				CommercialRegistrationEndDate = dto.StartDate.AddDays(package.Duration),
				CreatedAt = DateTime.Now
			};

			// Create transaction
			var transaction = new Transactions
			{
				Id = Guid.NewGuid(),
				OrderCode = await GenerateUniqueOrderCodeAsync(ct),
				Amount = package.Price,
				Description = $"Purchase commercial",
				Status = dto.PaymentMethod == PaymentMethod.PayOS ? TransactionStatus.Pending : TransactionStatus.Success,
				Type = TransactionType.PurchaseCommercialPackage,
				CreatedAt = DateTime.Now,
				UserId = userId,
				PurchaseUserId = userId,
				GameId = gameId,
				PaymentMethod = dto.PaymentMethod,
				OrderId = order.Id
			};

			repositoryManager.OrderRepository.CreateOrder(order);
			repositoryManager.TransactionRepository.CreateTransaction(transaction);
			await repositoryManager.SaveAsync(ct);

			if (dto.PaymentMethod == PaymentMethod.Wallet)
			{
				var adminWallet = await repositoryManager.WalletRepository.GetWalletByUserId(Guid.Parse("e5d8947f-6794-42b6-ba67-201f366128b8"), true, ct);
				wallet.Balance -= package.Price;
				var commercialRegistration = new CommercialRegistrations()
				{
					Id = Guid.NewGuid(),
					StartDate = dto.StartDate,
					EndDate = dto.StartDate.AddDays(package.Duration),
					CreatedAt = DateTime.Now,
					Status = CommercialRegistrationStatus.Pending,
					GameId = gameId,
					CommercialPackageId = commercialPackageId,
				};
				repositoryManager.CommercialRegistrationRepository.CreateCommercialRegistration(commercialRegistration);

				var transactionForSystem = new Transactions
				{
					Id = Guid.NewGuid(),
					UserId = Guid.Parse("e5d8947f-6794-42b6-ba67-201f366128b8"),
					PurchaseUserId = userId,
					OrderCode = null,
					Amount = package.Price,
					Description = $"Purchase for commercial package {package.Name} for game {game.Name}",
					CreatedAt = DateTime.Now,
					Type = TransactionType.PurchaseCommercialPackageRevenue,
					Status = TransactionStatus.Success,
					PaymentMethod = PaymentMethod.Wallet
				};
				adminWallet.Balance += transactionForSystem.Amount;
				repositoryManager.TransactionRepository.CreateTransaction(transactionForSystem);

				try
				{
					await repositoryManager.SaveAsync(ct);
				}
				catch (DbUpdateException ex)
				{
					// Log the full error, or rethrow with more detail
					var innerMessage = ex.InnerException?.Message ?? ex.Message;
					throw new Exception($"Failed to save wallet transaction: {innerMessage}", ex);
				}
				return string.Empty;
			}
			else
			{
				return await GetPayOSPaymentLink(transaction, TransactionType.PurchaseCommercialPackage);
			}
		}

		public async Task Cancel(long orderCode, CancellationToken ct = default)
		{
			var clientId = configuration.GetSection("PayOSClientID").Value;
			var apiKey = configuration.GetSection("PayOSAPIKey").Value;
			var checksumKey = configuration.GetSection("PayOSChecksumKey").Value;

			var payOS = new PayOS(clientId, apiKey, checksumKey);

			var transaction = await repositoryManager.TransactionRepository.GetTransactionById(orderCode, true, ct);
			if (transaction == null)
			{
				throw new NotFoundException("Transaction not found");
			}
			transaction.Status = TransactionStatus.Cancel;
			await repositoryManager.SaveAsync(ct);

			await payOS.cancelPaymentLink(orderCode);
		}
	}
}
