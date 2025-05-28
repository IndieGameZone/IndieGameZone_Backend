using IndieGameZone.Domain.Entities;
using IndieGameZone.Domain.RequestFeatures;

namespace IndieGameZone.Domain.IRepositories
{
	public interface ITransactionRepository
	{
		void CreateTransaction(Transactions transaction);
		Task<Transactions?> GetTransactionById(Guid id, bool trackChange, CancellationToken ct = default);
		Task<Transactions?> GetTransactionById(long orderCode, bool trackChange, CancellationToken ct = default);
		Task<PagedList<Transactions>> GetTransactionsByUserId(Guid userId, TransactionParameters transactionParameters, bool trackChange, CancellationToken ct = default);
		Task<PagedList<Transactions>> GetTransactions(TransactionParameters transactionParameters, bool trackChange, CancellationToken ct = default);
	}
}
