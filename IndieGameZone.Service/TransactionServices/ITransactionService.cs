using IndieGameZone.Domain.RequestFeatures;
using IndieGameZone.Domain.RequestsAndResponses.Requests.Transactions;
using IndieGameZone.Domain.RequestsAndResponses.Responses.Transactions;
using Net.payOS.Types;

namespace IndieGameZone.Application.TransactionServices
{
	public interface ITransactionService
	{
		Task<string> CreateTransactionForDeposit(Guid userId, TransactionForCreationDto transaction, CancellationToken ct = default);
		Task CreateTransactionForGamePurchase(Guid userId, Guid gameId, TransactionForCreationDto transaction, CancellationToken ct = default);
		Task CreateTransactionForCommercialPurchase(Guid userId, Guid commercialPackageId, CancellationToken ct = default);
		//Task<string> CreateTransactionForDonation(TransactionForCreationDto transaction, CancellationToken ct = default);
		Task<(IEnumerable<TransactionForReturnDto> transactions, MetaData metaData)> GetTransactionsByUserId(Guid userId, TransactionParameters transactionParameters, bool trackChange, CancellationToken ct = default);
		Task<(IEnumerable<TransactionForReturnDto> transactions, MetaData metaData)> GetTransactions(TransactionParameters transactionParameters, bool trackChange, CancellationToken ct = default);
		Task IPNAsync(WebhookData webhookData, CancellationToken ct = default);
	}
}
