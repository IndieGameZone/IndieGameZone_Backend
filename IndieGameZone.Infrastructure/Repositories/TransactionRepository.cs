using IndieGameZone.Domain.Constants;
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

        public async Task<bool> IsOrderCodeExistsAsync(long orderCode, CancellationToken ct = default)
        {
            return await AppDbContext.Transactions.AnyAsync(t => t.OrderCode == orderCode, ct);
        }

        public async Task<double> GetTotalRevenueFromGamePurchase(RevenueRange range, CancellationToken ct = default)
        {
            return await CalculateTotalRevenue(TransactionType.PurchaseGame, range, ct);
        }

        public async Task<double> GetTotalRevenueFromCommercialPackagePurchase(RevenueRange range, CancellationToken ct = default)
        {
            return await CalculateTotalRevenue(TransactionType.PurchaseCommercialPackage, range, ct);
        }
        private async Task<double> CalculateTotalRevenue(TransactionType type, RevenueRange range, CancellationToken ct)
        {
            var now = DateTime.Now;
            DateTime rangeStart;

            switch (range)
            {
                case RevenueRange.Day:
                    rangeStart = now.Date;
                    break;

                case RevenueRange.Week:
                    int diff = (7 + (now.DayOfWeek - DayOfWeek.Monday)) % 7;
                    rangeStart = now.Date.AddDays(-diff); // start of current week (Monday)
                    break;

                case RevenueRange.Month:
                    rangeStart = new DateTime(now.Year, now.Month, 1);
                    break;

                case RevenueRange.Year:
                    rangeStart = new DateTime(now.Year, 1, 1);
                    break;

                default:
                    rangeStart = DateTime.MinValue;
                    break;
            }

            return await FindAll(false)
                .Where(t =>
                    t.Type == type &&
                    t.Status == TransactionStatus.Success &&
                    t.CreatedAt >= rangeStart &&
                    t.CreatedAt <= now)
                .SumAsync(t => t.Amount, ct);
        }
    }
}
