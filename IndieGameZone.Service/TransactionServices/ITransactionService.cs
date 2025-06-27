using IndieGameZone.Domain.RequestFeatures;
using IndieGameZone.Domain.RequestsAndResponses.Requests.Transactions;
using IndieGameZone.Domain.RequestsAndResponses.Responses.Transactions;
using Net.payOS.Types;

namespace IndieGameZone.Application.TransactionServices
{
	public interface ITransactionService
	{
		Task<string> CreateTransactionForDeposit(Guid userId, TransactionForDepositCreationDto transaction, CancellationToken ct = default);
		Task CreateTransactionForGameWalletPurchase(Guid userId, Guid gameId, string? couponCode, CancellationToken ct = default);
		Task<string> CreateTransactionForGamePayOSPurchase(Guid userId, Guid gameId, string? couponCode, CancellationToken ct = default);
		Task<string> CreateTransactionForDonation(Guid userId, Guid gameId, TransactionForDonationCreationDto transactionForDonationCreationDto, CancellationToken ct = default);
		Task<(IEnumerable<TransactionForReturnDto> transactions, MetaData metaData)> GetTransactionsByUserId(Guid userId, TransactionParameters transactionParameters, bool trackChange, CancellationToken ct = default);
		Task<(IEnumerable<TransactionForReturnDto> transactions, MetaData metaData)> GetTransactions(TransactionParameters transactionParameters, bool trackChange, CancellationToken ct = default);
		Task IPNAsync(WebhookData webhookData, CancellationToken ct = default);
	}
}
