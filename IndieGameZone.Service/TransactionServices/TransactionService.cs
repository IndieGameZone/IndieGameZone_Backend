using IndieGameZone.Domain.Constants;
using IndieGameZone.Domain.Entities;
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

		public async Task<string> CreateTransactionForDeposit(TransactionForCreationDto transaction)
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

		public async Task<string> CreateTransactionForDonation(TransactionForCreationDto transaction)
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

		public Task<string> CreateTransactionForPurchase(TransactionForCreationDto transaction)
		{
			throw new NotImplementedException();
		}

		public Task<(IEnumerable<TransactionForReturnDto> transactions, MetaData metaData)> GetTransactions(TransactionParameters transactionParameters, bool trackChange)
		{
			throw new NotImplementedException();
		}

		public Task<(IEnumerable<TransactionForReturnDto> transactions, MetaData metaData)> GetTransactionsByUserId(string userId, TransactionParameters transactionParameters, bool trackChange)
		{
			throw new NotImplementedException();
		}

		public async Task IPNAsync(WebhookData webhookData)
		{
			var transaction = await repositoryManager.TransactionRepository.GetTransactionById(webhookData.orderCode, true);
			var wallet = await repositoryManager.WalletRepository.GetWalletByUserId(transaction.UserId, true);
			var clientId = configuration.GetSection("PayOSClientID").Value;
			var apiKey = configuration.GetSection("PayOSAPIKey").Value;
			var checksumKey = configuration.GetSection("PayOSChecksumKey").Value;

			var payOS = new PayOS(clientId, apiKey, checksumKey);
			if (webhookData.code == "00")
			{
				wallet.Balance += transaction.Amount;
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
