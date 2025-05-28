using IndieGameZone.Domain.RequestFeatures;
using IndieGameZone.Domain.RequestsAndResponses.Requests.Transactions;
using IndieGameZone.Domain.RequestsAndResponses.Responses.Transactions;
using Net.payOS.Types;

namespace IndieGameZone.Application.TransactionServices
{
	public interface ITransactionService
	{
		Task<string> CreateTransactionForDeposit(TransactionForCreationDto transaction);
		Task<string> CreateTransactionForPurchase(TransactionForCreationDto transaction);
		Task<string> CreateTransactionForDonation(TransactionForCreationDto transaction);
		Task<(IEnumerable<TransactionForReturnDto> transactions, MetaData metaData)> GetTransactionsByUserId(string userId, TransactionParameters transactionParameters, bool trackChange);
		Task<(IEnumerable<TransactionForReturnDto> transactions, MetaData metaData)> GetTransactions(TransactionParameters transactionParameters, bool trackChange);
		Task IPNAsync(WebhookData webhookData);
	}
}
