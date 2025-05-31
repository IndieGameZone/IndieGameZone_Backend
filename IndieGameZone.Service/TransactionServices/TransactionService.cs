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

		public TransactionService(IRepositoryManager repositoryManager, IMapper mapper, IConfiguration configuration)
		{
			this.repositoryManager = repositoryManager;
			this.mapper = mapper;
			this.configuration = configuration;
		}

		public async Task<string> CreateTransactionForDeposit(TransactionForCreationDto transaction, CancellationToken ct = default)
		{
			Random random = new Random();
			var transactionEntity = mapper.Map<Transactions>(transaction);
			transactionEntity.Id = Guid.NewGuid();
			transactionEntity.OrderCode = random.Next(100000, 999999);
			transactionEntity.CreatedAt = DateTime.Now;
			transactionEntity.Type = TransactionType.Deposit;
			transactionEntity.Status = TransactionStatus.Pending;
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
				returnUrl: domain + "?success=true",
				cancelUrl: domain + "?canceled=true"
			);
			var response = await payOS.createPaymentLink(paymentLinkRequest);

			return response.checkoutUrl;
		}

		public async Task<string> CreateTransactionForDonation(TransactionForCreationDto transaction, CancellationToken ct = default)
		{
			Random random = new Random();
			var transactionEntity = mapper.Map<Transactions>(transaction);
			transactionEntity.Id = Guid.NewGuid();
			transactionEntity.OrderCode = random.Next(100000, 999999);
			transactionEntity.CreatedAt = DateTime.Now;
			transactionEntity.Type = TransactionType.Donation;
			transactionEntity.Status = TransactionStatus.Pending;
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
				items: [new("Donation", 1, (int)transaction.Amount)],
				returnUrl: domain + "?success=true",
				cancelUrl: domain + "?canceled=true"
			);
			var response = await payOS.createPaymentLink(paymentLinkRequest);

			return response.checkoutUrl;
		}

		public async Task CreateTransactionForPurchase(TransactionForCreationDto transaction, CancellationToken ct = default)
		{
			Random random = new Random();
			var wallet = await repositoryManager.WalletRepository.GetWalletByUserId(transaction.UserId, true, ct);
			if (wallet.Balance < transaction.Amount)
			{
				throw new NotEnoughCreditException("You don't have enough credits to buy this game");
			}
			var transactionEntity = mapper.Map<Transactions>(transaction);
			transactionEntity.Id = Guid.NewGuid();
			transactionEntity.OrderCode = random.Next(100000, 999999);
			transactionEntity.CreatedAt = DateTime.Now;
			transactionEntity.Type = TransactionType.Purchase;
			transactionEntity.Status = TransactionStatus.Success;

			repositoryManager.TransactionRepository.CreateTransaction(transactionEntity);

			wallet.Balance -= transactionEntity.Amount;

			var game = await repositoryManager.GameRepository.GetGameById((Guid)transaction.GameId, false, ct);

			var developerId = (await repositoryManager.GameRepository.GetGameById((Guid)transaction.GameId, false, ct)).DeveloperId;

			var developerWallet = await repositoryManager.WalletRepository.GetWalletByUserId(developerId, true, ct);

			developerWallet.Balance += game.Price * 0.8; // 80% to developer
			developerWallet.Balance += transactionEntity.Amount - game.Price; // Donation amount to developer

			var libraryEntity = new Libraries
			{
				UserId = transaction.UserId,
				GameId = (Guid)transaction.GameId,
				PurchasedAt = DateTime.Now
			};
			repositoryManager.LibraryRepository.AddGameToLibrary(libraryEntity);

			await repositoryManager.SaveAsync(ct);

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

				transaction.Status = TransactionStatus.Success;
			}
			else
			{
				transaction.Status = TransactionStatus.Failed;
			}

			await repositoryManager.SaveAsync();
		}
	}
}
