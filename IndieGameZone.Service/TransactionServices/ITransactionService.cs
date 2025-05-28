using IndieGameZone.Domain.RequestFeatures;
using IndieGameZone.Domain.RequestsAndResponses.Requests.Transactions;
using IndieGameZone.Domain.RequestsAndResponses.Responses.Transactions;
using Net.payOS.Types;

namespace IndieGameZone.Application.TransactionServices
{
	public interface ITransactionService
	{
		Task<string> CreateTransactionForDeposit(TransactionForCreationDto transaction, CancellationToken ct = default);
		Task CreateTransactionForPurchase(TransactionForCreationDto transaction, CancellationToken ct = default);
		Task<string> CreateTransactionForDonation(TransactionForCreationDto transaction, CancellationToken ct = default);
		Task<(IEnumerable<TransactionForReturnDto> transactions, MetaData metaData)> GetTransactionsByUserId(Guid userId, TransactionParameters transactionParameters, bool trackChange, CancellationToken ct = default);
		Task<(IEnumerable<TransactionForReturnDto> transactions, MetaData metaData)> GetTransactions(TransactionParameters transactionParameters, bool trackChange, CancellationToken ct = default);
		Task IPNAsync(WebhookData webhookData, CancellationToken ct = default);
	}
}
