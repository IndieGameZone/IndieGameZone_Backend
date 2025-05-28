using IndieGameZone.Domain.Entities;
using IndieGameZone.Domain.IRepositories;
using IndieGameZone.Domain.RequestFeatures;
using IndieGameZone.Infrastructure.Extensions;
using IndieGameZone.Infrastructure.Persistence;
using Microsoft.EntityFrameworkCore;

namespace IndieGameZone.Infrastructure.Repositories
{
	internal sealed class TransactionRepository : RepositoryBase<Transactions>, ITransactionRepository
	{
		public TransactionRepository(AppDbContext appDbContext) : base(appDbContext)
		{
		}

		public void CreateTransaction(Transactions transaction) => Create(transaction);

		public async Task<Transactions?> GetTransactionById(Guid id, bool trackChange, CancellationToken ct = default) => await
			FindByCondition(x => x.Id == id, trackChange).FirstOrDefaultAsync(ct);

		public Task<Transactions?> GetTransactionById(long orderCode, bool trackChange, CancellationToken ct = default) =>
			FindByCondition(x => x.OrderCode == orderCode, trackChange).Include(t => t.Game).FirstOrDefaultAsync(ct);

		public Task<PagedList<Transactions>> GetTransactions(TransactionParameters transactionParameters, bool trackChange, CancellationToken ct = default)
		{
			var transactionEntities = FindAll(trackChange)
				.Sort();

			return PagedList<Transactions>.ToPagedList(transactionEntities, transactionParameters.PageNumber, transactionParameters.PageSize, ct);
		}

		public Task<PagedList<Transactions>> GetTransactionsByUserId(Guid userId, TransactionParameters transactionParameters, bool trackChange, CancellationToken ct = default)
		{
			var transactionEntities = FindByCondition(x => x.UserId == userId, trackChange)
				.Sort();

			return PagedList<Transactions>.ToPagedList(transactionEntities, transactionParameters.PageNumber, transactionParameters.PageSize, ct);
		}
	}
}
