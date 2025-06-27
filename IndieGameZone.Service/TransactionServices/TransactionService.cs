using IndieGameZone.Application.RecombeeServices;
using IndieGameZone.Domain.Constants;
using IndieGameZone.Domain.Entities;
using IndieGameZone.Domain.Exceptions;
using IndieGameZone.Domain.IRepositories;
using IndieGameZone.Domain.RequestFeatures;
using IndieGameZone.Domain.RequestsAndResponses.Requests.Transactions;
using IndieGameZone.Domain.RequestsAndResponses.Responses.Transactions;
using MapsterMapper;
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

		public TransactionService(IRepositoryManager repositoryManager, IMapper mapper, IConfiguration configuration, IRecombeeService recombeeService)
		{
			this.repositoryManager = repositoryManager;
			this.mapper = mapper;
			this.configuration = configuration;
			this.recombeeService = recombeeService;
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

			var clientId = configuration.GetSection("PayOSClientID").Value;
			var apiKey = configuration.GetSection("PayOSAPIKey").Value;
			var checksumKey = configuration.GetSection("PayOSChecksumKey").Value;

			var domain = "https://indie-game-zone.vercel.app/";

			var payOS = new PayOS(clientId, apiKey, checksumKey);

			var paymentLinkRequest = new PaymentData(
				orderCode: transactionEntity.OrderCode,
				amount: (int)transactionEntity.Amount,
				description: transactionEntity.Description,
				items: [new("Deposit", 1, (int)transaction.Amount)],
				cancelUrl: domain + "?canceled=true",
				returnUrl: domain + "?success=true"
			);
			var response = await payOS.createPaymentLink(paymentLinkRequest);

			return response.checkoutUrl;
		}

		public async Task<string> CreateTransactionForGamePayOSPurchase(Guid userId, Guid gameId, string? couponCode, CancellationToken ct = default)
		{
			var game = await repositoryManager.GameRepository.GetGameById(gameId, false, ct);

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

			var transactionEntity = new Transactions()
			{
				Id = Guid.NewGuid(),
				UserId = userId,
				GameId = gameId,
				Amount = gamePriceAfterDiscount,
				Description = $"Purchase of game {game.Name}",
				CreatedAt = DateTime.Now,
				Type = TransactionType.PurchaseGame,
				Status = TransactionStatus.Pending,
			};
			repositoryManager.TransactionRepository.CreateTransaction(transactionEntity);

			var clientId = configuration.GetSection("PayOSClientID").Value;
			var apiKey = configuration.GetSection("PayOSAPIKey").Value;
			var checksumKey = configuration.GetSection("PayOSChecksumKey").Value;

			var domain = "https://indie-game-zone.vercel.app/";

			var payOS = new PayOS(clientId, apiKey, checksumKey);

			var paymentLinkRequest = new PaymentData(
				orderCode: transactionEntity.OrderCode,
				amount: (int)transactionEntity.Amount,
				description: transactionEntity.Description,
				items: [new("PurchaseGame", 1, (int)transactionEntity.Amount)],
				cancelUrl: domain + "?canceled=true",
				returnUrl: domain + "?success=true"
			);
			var response = await payOS.createPaymentLink(paymentLinkRequest);

			return response.checkoutUrl;
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

			var clientId = configuration.GetSection("PayOSClientID").Value;
			var apiKey = configuration.GetSection("PayOSAPIKey").Value;
			var checksumKey = configuration.GetSection("PayOSChecksumKey").Value;

			var domain = "https://indie-game-zone.vercel.app/";

			var payOS = new PayOS(clientId, apiKey, checksumKey);

			var paymentLinkRequest = new PaymentData(
				orderCode: transactionEntity.OrderCode,
				amount: (int)transactionEntity.Amount,
				description: transactionEntity.Description,
				items: [new("Donation", 1, (int)transactionEntity.Amount)],
				returnUrl: domain + "?success=true",
				cancelUrl: domain + "?canceled=true"
			);
			var response = await payOS.createPaymentLink(paymentLinkRequest);


			return response.checkoutUrl;
		}

		public async Task CreateTransactionForGameWalletPurchase(Guid userId, Guid gameId, string? couponCode, CancellationToken ct = default)
		{
			var wallet = await repositoryManager.WalletRepository.GetWalletByUserId(userId, true, ct);
			var game = await repositoryManager.GameRepository.GetGameById(gameId, false, ct);

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


			if (wallet.Balance < gamePriceAfterDiscount)
			{
				throw new NotEnoughCreditException("You don't have enough credits to buy this game");
			}
			var transactionEntity = new Transactions()
			{
				Id = Guid.NewGuid(),
				UserId = userId,
				GameId = gameId,
				Amount = gamePriceAfterDiscount,
				Description = $"Purchase of game {game.Name}",
				CreatedAt = DateTime.Now,
				Type = TransactionType.PurchaseGame,
				Status = TransactionStatus.Success
			};

			repositoryManager.TransactionRepository.CreateTransaction(transactionEntity);

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

		public async Task IPNAsync(WebhookData webhookData, CancellationToken ct = default)
		{
			var transaction = await repositoryManager.TransactionRepository.GetTransactionById(webhookData.orderCode, true);

			var clientId = configuration.GetSection("PayOSClientID").Value;
			var apiKey = configuration.GetSection("PayOSAPIKey").Value;
			var checksumKey = configuration.GetSection("PayOSChecksumKey").Value;

			var payOS = new PayOS(clientId, apiKey, checksumKey);
			if (webhookData.code == "00")
			{
				if (transaction.Type == TransactionType.Deposit)
				{
					var wallet = await repositoryManager.WalletRepository.GetWalletByUserId(transaction.UserId, true);
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

				transaction.Status = TransactionStatus.Success;
			}
			else
			{
				transaction.Status = TransactionStatus.Failed;
			}

			await repositoryManager.SaveAsync();
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

	}
}
