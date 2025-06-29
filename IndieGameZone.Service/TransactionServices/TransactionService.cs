using IndieGameZone.Application.RecombeeServices;
using IndieGameZone.Domain.Constants;
using IndieGameZone.Domain.Entities;
using IndieGameZone.Domain.Exceptions;
using IndieGameZone.Domain.IRepositories;
using IndieGameZone.Domain.RequestFeatures;
using IndieGameZone.Domain.RequestsAndResponses.Requests.Transactions;
using IndieGameZone.Domain.RequestsAndResponses.Responses.Transactions;
using MapsterMapper;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Net.payOS;
using Net.payOS.Types;

namespace IndieGameZone.Application.TransactionServices
{
	internal sealed class TransactionService : ITransactionService
	{
		private readonly IRepositoryManager repositoryManager;
		private readonly IMapper mapper;
		private readonly IConfiguration configuration;
		private readonly IRecombeeService recombeeService;
		private readonly UserManager<Users> userManager;

		public TransactionService(IRepositoryManager repositoryManager, IMapper mapper, IConfiguration configuration, IRecombeeService recombeeService, UserManager<Users> userManager)
		{
			this.repositoryManager = repositoryManager;
			this.mapper = mapper;
			this.configuration = configuration;
			this.recombeeService = recombeeService;
			this.userManager = userManager;
		}

		public async Task<string> CreateTransactionForCommercialPurchase(Guid userId, Guid commercialPackageId, TransactionForCommercialDto dto, CancellationToken ct = default)
		{
			// 1. Validate user and wallet

			var user = await userManager.Users
				.Include(u => u.UserProfile)
		.Include(u => u.Wallet)
				.FirstOrDefaultAsync(u => u.Id == userId, ct);
			if (user == null)
				throw new NotFoundException("User not found");

			var wallet = await repositoryManager.WalletRepository.GetWalletByUserId(userId, true, ct)
				?? throw new NotFoundException("User wallet not found");

			// 2. Validate game ownership
			var game = await repositoryManager.GameRepository.GetGameById(dto.GameId, false, ct);
			if (game == null)
				throw new NotFoundException("Game not found.");
			if (game.DeveloperId != userId)
				throw new BadRequestException("You can only purchase a commercial package for your own public game.");

			// 3. Validate package
			var package = await repositoryManager.CommercialPackageRepository.GetCommercialPackageById(commercialPackageId, false, ct)
				?? throw new NotFoundException("Commercial package not found");

			// 4. Validate dates
			if (dto.EndDate < dto.StartDate)
				throw new BadRequestException("End date must be after start date.");

			// 5. Check wallet balance
			if (dto.PaymentMethod == PaymentMethod.Wallet)
			{
				if (wallet.Balance < package.Price)
					throw new NotEnoughCreditException("You don't have enough wallet points to purchase this package.");
			}

			// 6. Create transaction
			var transaction = new Transactions
			{
				Id = Guid.NewGuid(),
				OrderCode = await GenerateUniqueOrderCodeAsync(ct),
				Amount = package.Price,
				Description = $"Wallet purchase of commercial package '{package.Name}' for game '{game.Name}'",
				Status = dto.PaymentMethod == PaymentMethod.PayOS ? TransactionStatus.Pending : TransactionStatus.Success,
				Type = TransactionType.PurchaseCommercialPackage,
				CreatedAt = DateTime.Now,
				UserId = userId,
				GameId = dto.GameId
			};

			repositoryManager.TransactionRepository.CreateTransaction(transaction);

			if (dto.PaymentMethod == PaymentMethod.Wallet)
			{
				wallet.Balance -= package.Price;

				var registration = new CommercialRegistration
				{
					Id = Guid.NewGuid(),
					StartDate = dto.StartDate,
					EndDate = dto.EndDate,
					GameId = dto.GameId,
					CommercialPackageId = commercialPackageId
				};

				// Need to add transaction.CommercialRegistration startDate and endDate map

				repositoryManager.CommercialRegistrationRepository.CreateCommercialRegistration(registration);
				//transaction.CommercialRegistrationId = registration.Id;
				await repositoryManager.SaveAsync(ct);
				return string.Empty;
			}
			else
			{
				await repositoryManager.SaveAsync(ct);
				return await GetPayOSPaymentLink(transaction, TransactionType.PurchaseCommercialPackage);
			}
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
				orderCode: transaction.OrderCode,
				amount: (int)transaction.Amount,
				description: transaction.Description,
				items: [new(itemName, 1, (int)transaction.Amount)],
				cancelUrl: domain + "?canceled=true",
				returnUrl: domain + "?success=true"
			);
			var response = await payOS.createPaymentLink(paymentLinkRequest);

			return response.checkoutUrl;
		}

		private async Task<double> GetGamePriceAfterApplyingCoupon(Games game, string? couponCode, CancellationToken ct = default)
		{
			double gamePriceAfterDiscount = 0;
			if (couponCode == null || couponCode.Trim().Equals(string.Empty))
			{
				gamePriceAfterDiscount = game.Price;
			}
			else
			{
				var coupon = await repositoryManager.CouponRepository.GetCouponByCode(couponCode, true, ct);
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
				gamePriceAfterDiscount = game.Price - (game.Price * coupon.Percentage / 100);
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

		private async Task CheckGameAchievements(Guid userId)
		{
			int libraryCount = await repositoryManager.LibraryRepository.GetLibraryByUserId(userId, false).CountAsync();
			var userAchievements = repositoryManager.UserAchievementRepository.GetUserAchievementsByUserId(userId, false);

			if (libraryCount == 1 && !userAchievements.Any(u => u.AchievementId == Guid.Parse("fef0c70d-cf7b-4c90-9865-383e660fda8a")))
			{
				repositoryManager.UserAchievementRepository.AddUserAchievement(new UserAchievements
				{
					UserId = userId,
					AchievementId = Guid.Parse("fef0c70d-cf7b-4c90-9865-383e660fda8a")
				});
			}
			else if (libraryCount == 10 && !userAchievements.Any(u => u.AchievementId == Guid.Parse("56e5cd8d-2d46-45dc-9006-f71920beea40")))
			{
				repositoryManager.UserAchievementRepository.AddUserAchievement(new UserAchievements
				{
					UserId = userId,
					AchievementId = Guid.Parse("56e5cd8d-2d46-45dc-9006-f71920beea40")
				});
			}
			else if (libraryCount == 50 && !userAchievements.Any(u => u.AchievementId == Guid.Parse("9c60bc27-9c8a-4be3-9e0d-1f4e96cb59a7")))
			{
				repositoryManager.UserAchievementRepository.AddUserAchievement(new UserAchievements
				{
					UserId = userId,
					AchievementId = Guid.Parse("9c60bc27-9c8a-4be3-9e0d-1f4e96cb59a7")
				});
			}
			await repositoryManager.SaveAsync();
		}

		public async Task<string> CreateTransactionForDeposit(Guid userId, TransactionForDepositCreationDto transaction, CancellationToken ct = default)
		{
			var transactionEntity = mapper.Map<Transactions>(transaction);
			transactionEntity.Id = Guid.NewGuid();
			transactionEntity.UserId = userId;
			transactionEntity.OrderCode = await GenerateUniqueOrderCodeAsync(ct);
			transactionEntity.Description = "Deposit to wallet";
			transactionEntity.Status = TransactionStatus.Pending;
			transactionEntity.Type = TransactionType.Deposit;
			transactionEntity.CreatedAt = DateTime.Now;
			repositoryManager.TransactionRepository.CreateTransaction(transactionEntity);

			await repositoryManager.SaveAsync(ct);
			return await GetPayOSPaymentLink(transactionEntity, TransactionType.Deposit);
		}

		public async Task<string> CreateTransactionForGamePurchase(Guid userId, Guid gameId, TransactionForGameCreation transactionForGameCreation, CancellationToken ct = default)
		{
			var game = await repositoryManager.GameRepository.GetGameById(gameId, false, ct);
			var wallet = await repositoryManager.WalletRepository.GetWalletByUserId(userId, true, ct);
			double gamePriceAfterDiscount = await GetGamePriceAfterApplyingCoupon(game, transactionForGameCreation.CouponCode);

			if (transactionForGameCreation.PaymentMethod == PaymentMethod.Wallet)
			{
				if (wallet.Balance < gamePriceAfterDiscount)
				{
					throw new NotEnoughCreditException("You don't have enough credits to buy this game");
				}
			}

			var transactionEntity = new Transactions()
			{
				Id = Guid.NewGuid(),
				UserId = userId,
				GameId = gameId,
				OrderCode = await GenerateUniqueOrderCodeAsync(ct),
				Amount = gamePriceAfterDiscount,
				Description = $"Purchase of game {game.Name}",
				CreatedAt = DateTime.Now,
				Type = TransactionType.PurchaseGame,
				Status = transactionForGameCreation.PaymentMethod == PaymentMethod.PayOS ? TransactionStatus.Pending : TransactionStatus.Success,
			};
			repositoryManager.TransactionRepository.CreateTransaction(transactionEntity);

			if (transactionForGameCreation.PaymentMethod == PaymentMethod.Wallet)
			{
				wallet.Balance -= transactionEntity.Amount;
				var developerWallet = await repositoryManager.WalletRepository.GetWalletByUserId(game.DeveloperId, true, ct);
				developerWallet.Balance += transactionEntity.Amount * 0.8; // 80% to developer
				var libraryEntity = new Libraries
				{
					UserId = userId,
					GameId = gameId,
					PurchasedAt = DateTime.Now
				};
				repositoryManager.LibraryRepository.AddGameToLibrary(libraryEntity);
				await repositoryManager.SaveAsync(ct);
				await recombeeService.SendPurchaseEvent(userId, gameId);

				await CheckGameAchievements(userId);
				return string.Empty;
			}
			else
			{
				await repositoryManager.SaveAsync(ct);
				return await GetPayOSPaymentLink(transactionEntity, TransactionType.PurchaseGame);
			}
		}

		public async Task<string> CreateTransactionForDonation(Guid userId, Guid gameId, TransactionForDonationCreationDto transactionForDonationCreationDto, CancellationToken ct = default)
		{
			var game = await repositoryManager.GameRepository.GetGameById(gameId, false, ct);
			if (game == null)
			{
				throw new NotFoundException("Game does not exist");
			}
			var transactionEntity = new Transactions()
			{
				Id = Guid.NewGuid(),
				UserId = userId,
				GameId = gameId,
				Amount = transactionForDonationCreationDto.Amount,
				Description = $"Donation for game {game.Name}",
				CreatedAt = DateTime.Now,
				Type = TransactionType.Donation,
				Status = TransactionStatus.Pending
			};
			repositoryManager.TransactionRepository.CreateTransaction(transactionEntity);

			await repositoryManager.SaveAsync(ct);
			return await GetPayOSPaymentLink(transactionEntity, TransactionType.Donation);
		}

		public async Task<(IEnumerable<TransactionForReturnDto> transactions, MetaData metaData)> GetTransactions(TransactionParameters transactionParameters, bool trackChange, CancellationToken ct = default)
		{
			var transactionsWithMetaData = await repositoryManager.TransactionRepository.GetTransactions(transactionParameters, trackChange, ct);
			var transactions = mapper.Map<IEnumerable<TransactionForReturnDto>>(transactionsWithMetaData);
			return (transactions, transactionsWithMetaData.MetaData);
		}

		public async Task<(IEnumerable<TransactionForReturnDto> transactions, MetaData metaData)> GetTransactionsByUserId(Guid userId, TransactionParameters transactionParameters, bool trackChange, CancellationToken ct = default)
		{
			var transactionsWithMetaData = await repositoryManager.TransactionRepository.GetTransactionsByUserId(userId, transactionParameters, trackChange, ct);
			var transactions = mapper.Map<IEnumerable<TransactionForReturnDto>>(transactionsWithMetaData);
			return (transactions, transactionsWithMetaData.MetaData);
		}

		public async Task IPNAsync(WebhookData webhookData, bool isSuccess, CancellationToken ct = default)
		{
			var transaction = await repositoryManager.TransactionRepository.GetTransactionById(webhookData.orderCode, true);

			var clientId = configuration.GetSection("PayOSClientID").Value;
			var apiKey = configuration.GetSection("PayOSAPIKey").Value;
			var checksumKey = configuration.GetSection("PayOSChecksumKey").Value;

			var payOS = new PayOS(clientId, apiKey, checksumKey);
			if (isSuccess)
			{
				if (transaction.Type == TransactionType.Deposit)
				{
					var wallet = await repositoryManager.WalletRepository.GetWalletByUserId(transaction.UserId, true, ct);
					wallet.Balance += transaction.Amount;
				}
				else if (transaction.Type == TransactionType.Donation)
				{
					var developerId = transaction.Game.DeveloperId;
					var developerWallet = await repositoryManager.WalletRepository.GetWalletByUserId(developerId, true, ct);
					developerWallet.Balance += transaction.Amount;
				}
				else if (transaction.Type == TransactionType.PurchaseGame)
				{
					var developerId = transaction.Game.DeveloperId;
					var developerWallet = await repositoryManager.WalletRepository.GetWalletByUserId(developerId, true, ct);
					developerWallet.Balance += transaction.Amount * 0.8; // 80% to developer
					var libraryEntity = new Libraries
					{
						UserId = transaction.UserId,
						GameId = (Guid)transaction.GameId,
						PurchasedAt = DateTime.Now
					};
					repositoryManager.LibraryRepository.AddGameToLibrary(libraryEntity);
					await recombeeService.SendPurchaseEvent(transaction.UserId, (Guid)transaction.GameId);
				}
				else if (transaction.Type == TransactionType.PurchaseCommercialPackage)
				{
					// take commercialPackageId, startDate, endDate, and gameId from transaction then create commercialregistration entity 
					//var registration = new CommercialRegistration
					//{
					//    Id = Guid.NewGuid(),
					//    StartDate = dto.StartDate,
					//    EndDate = dto.EndDate,
					//    GameId = dto.GameId,
					//    CommercialPackageId = commercialPackageId
					//};

					//repositoryManager.CommercialRegistrationRepository.CreateCommercialRegistration(registration);
				}

				transaction.Status = TransactionStatus.Success;
			}
			else
			{
				transaction.Status = TransactionStatus.Failed;
			}

			await repositoryManager.SaveAsync(ct);
			if (transaction.Type == TransactionType.PurchaseGame)
			{
				await CheckGameAchievements(transaction.UserId);
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
