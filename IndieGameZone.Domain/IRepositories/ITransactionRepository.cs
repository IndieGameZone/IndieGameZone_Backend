using IndieGameZone.Domain.Constants;
using IndieGameZone.Domain.Entities;
using IndieGameZone.Domain.RequestFeatures;
using IndieGameZone.Domain.RequestsAndResponses.Responses.DashBoard;

namespace IndieGameZone.Domain.IRepositories
{
	public interface ITransactionRepository
	{
		void CreateTransaction(Transactions transaction);
		Task<Transactions?> GetTransactionById(Guid id, bool trackChange, CancellationToken ct = default);
		Task<Transactions?> GetTransactionById(long orderCode, bool trackChange, CancellationToken ct = default);
		Task<PagedList<Transactions>> GetTransactionsByUserId(Guid userId, TransactionParameters transactionParameters, bool trackChange, CancellationToken ct = default);
		Task<PagedList<Transactions>> GetTransactions(TransactionParameters transactionParameters, bool trackChange, CancellationToken ct = default);
        Task<bool> IsOrderCodeExistsAsync(long orderCode, CancellationToken ct = default);
        Task<double> GetTotalRevenueFromGamePurchase(RevenueRange range, CancellationToken ct = default);
		Task<double> GetTotalRevenueFromCommercialPackagePurchase(RevenueRange range, CancellationToken ct = default);
        Task<double> GetTotalRevenueForDeveloper(Guid developerId, RevenueRange range, CancellationToken ct = default);
        Task<double> GetTotalRevenueForDeveloper(Guid developerId, DateTime startDate, DateTime endDate, CancellationToken ct = default);
        Task<DateTime?> GetFirstTransactionDateForDeveloper(Guid developerId, CancellationToken ct = default);
        Task<IEnumerable<RevenueByDayForReturnDto>> GetRevenueByMonthAsync(Guid developerId, int year, int month, CancellationToken ct = default);
        Task<double> GetTotalRevenueForGame(Guid gameId, DateTime start, DateTime end, CancellationToken ct = default);
        Task<DateTime?> GetFirstTransactionDateForGame(Guid gameId, CancellationToken ct = default);
        Task<IEnumerable<Transactions>> GetSuccessfulTransactionsByGameIdAsync(Guid gameId, int year, int month, CancellationToken ct = default);

    }
}
