using IndieGameZone.Domain.RequestFeatures;
using IndieGameZone.Domain.RequestsAndResponses.Requests.Transactions;
using IndieGameZone.Domain.RequestsAndResponses.Responses.Transactions;
using Net.payOS.Types;

namespace IndieGameZone.Application.TransactionServices
{
	public interface ITransactionService
	{
		Task<string> CreateTransactionForDeposit(Guid userId, TransactionForDepositCreationDto transaction, CancellationToken ct = default);
		Task<string> CreateTransactionForGamePurchase(Guid userId, Guid gameId, TransactionForGameCreation transactionForGameCreation, CancellationToken ct = default);
		Task<string> CreateTransactionForDonation(Guid userId, Guid gameId, TransactionForDonationCreationDto transactionForDonationCreationDto, CancellationToken ct = default);
		Task<string> CreateTransactionForCommercialPurchase(Guid userId, Guid gameId, Guid commercialPackageId, TransactionForCommercialDto dto, CancellationToken ct = default);
		Task<(IEnumerable<TransactionForReturnDto> transactions, MetaData metaData)> GetTransactionsByUserId(Guid userId, TransactionParameters transactionParameters, bool trackChange, CancellationToken ct = default);
		Task<(IEnumerable<TransactionForReturnDto> transactions, MetaData metaData)> GetTransactions(TransactionParameters transactionParameters, bool trackChange, CancellationToken ct = default);
		Task IPNAsync(WebhookData webhookData, bool isSuccess, CancellationToken ct = default);
		Task Cancel(long orderCode, CancellationToken ct = default);
	}
}
