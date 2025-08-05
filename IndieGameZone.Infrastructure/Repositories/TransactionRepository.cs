using IndieGameZone.Domain.Constants;
using IndieGameZone.Domain.Entities;
using IndieGameZone.Domain.IRepositories;
using IndieGameZone.Domain.RequestFeatures;
using IndieGameZone.Domain.RequestsAndResponses.Responses.DashBoard;
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
			FindByCondition(x => x.Id == id, trackChange)
			.Include(t => t.User).ThenInclude(t => t.UserProfile).AsSplitQuery()
			.Include(t => t.PurchaseUser).ThenInclude(t => t.UserProfile).AsSplitQuery()
			.Include(t => t.Game).AsSplitQuery()
			.FirstOrDefaultAsync(ct);

		public Task<Transactions?> GetTransactionById(long orderCode, bool trackChange, CancellationToken ct = default) =>
			FindByCondition(x => x.OrderCode == orderCode, trackChange)
			.Include(t => t.User).ThenInclude(t => t.UserProfile).AsSplitQuery()
			.Include(t => t.PurchaseUser).ThenInclude(t => t.UserProfile).AsSplitQuery()
			.Include(t => t.Game).AsSplitQuery()
			.FirstOrDefaultAsync(ct);

		public Task<PagedList<Transactions>> GetTransactions(TransactionParameters transactionParameters, bool trackChange, CancellationToken ct = default)
		{
			var transactionEntities = FindAll(trackChange)
				.FilterByTransactionTypes(transactionParameters.TransactionTypes)
				.Include(t => t.User).ThenInclude(t => t.UserProfile).AsSplitQuery()
				.Include(t => t.PurchaseUser).ThenInclude(t => t.UserProfile).AsSplitQuery()
				.Include(t => t.Game).AsSplitQuery()
				.Sort();

			return PagedList<Transactions>.ToPagedList(transactionEntities, transactionParameters.PageNumber, transactionParameters.PageSize, ct);
		}

		public Task<PagedList<Transactions>> GetTransactionsByUserId(Guid userId, TransactionParameters transactionParameters, bool trackChange, CancellationToken ct = default)
		{
			var transactionEntities = FindByCondition(x => x.UserId == userId, trackChange)
				.FilterByTransactionTypes(transactionParameters.TransactionTypes)
				.Include(t => t.User).ThenInclude(t => t.UserProfile).AsSplitQuery()
				.Include(t => t.PurchaseUser).ThenInclude(t => t.UserProfile).AsSplitQuery()
				.Include(t => t.Game).AsSplitQuery()
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

        public async Task<double> GetTotalRevenueForDeveloper(Guid developerId, RevenueRange range, CancellationToken ct = default)
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
                    rangeStart = now.Date.AddDays(-diff); // Start of current week (Monday)
                    break;

                case RevenueRange.Month:
                    rangeStart = new DateTime(now.Year, now.Month, 1);
                    break;

                case RevenueRange.Year:
                    rangeStart = new DateTime(now.Year, 1, 1);
                    break;

                case RevenueRange.AllTime:
                default:
                    rangeStart = DateTime.MinValue;
                    break;
            }

            return await FindAll(false)
                .Where(t =>
                    t.Type == TransactionType.PurchaseGame &&
                    t.Status == TransactionStatus.Success &&
                    t.UserId == developerId &&
                    t.CreatedAt >= rangeStart &&
                    t.CreatedAt <= now)
                .SumAsync(t => t.Amount, ct);
        }

        public async Task<double> GetTotalRevenueForDeveloper(Guid developerId, DateTime startDate, DateTime endDate, CancellationToken ct = default)
        {
             return await FindAll(false)
                .Where(t =>
                    t.Type == TransactionType.PurchaseGame &&
                    t.Status == TransactionStatus.Success &&
                    t.UserId == developerId &&
                    t.CreatedAt >= startDate &&
                    t.CreatedAt <= endDate)
                .SumAsync(t => t.Amount, ct);
        }

        public async Task<DateTime?> GetFirstTransactionDateForDeveloper(Guid developerId, CancellationToken ct = default)
        {
            return await FindAll(false)
                .Where(t =>
                    t.Type == TransactionType.PurchaseGame &&
                    t.Status == TransactionStatus.Success &&
                    t.UserId == developerId)
                .OrderBy(t => t.CreatedAt)
                .Select(t => (DateTime?)t.CreatedAt)
                .FirstOrDefaultAsync(ct);
        }

        public async Task<IEnumerable<RevenueByDayForReturnDto>> GetRevenueByMonthAsync(Guid developerId, int year, int month, CancellationToken ct = default)
        {
            var transactions = await FindAll(false)
                .Where(t =>
                    t.Type == TransactionType.PurchaseGame &&
                    t.Status == TransactionStatus.Success &&
                    t.UserId == developerId &&
                    t.CreatedAt.Year == year &&
                    t.CreatedAt.Month == month)
                .ToListAsync(ct);

            var groupedByDay = transactions
                .GroupBy(t => t.CreatedAt.Day)
                .Select(g => new RevenueByDayForReturnDto
                {
                    Day = g.Key,
                    Revenue = g.Sum(t => t.Amount)
                })
                .ToList();

            // Fill in missing days with 0 revenue
            var daysInMonth = DateTime.DaysInMonth(year, month);
            var fullReport = Enumerable.Range(1, daysInMonth)
                .Select(day => groupedByDay.FirstOrDefault(d => d.Day == day) ?? new RevenueByDayForReturnDto
                {
                    Day = day,
                    Revenue = 0
                })
                .OrderBy(r => r.Day)
                .ToList();

            return fullReport;
        }

        public async Task<double> GetTotalRevenueForGame(Guid gameId, DateTime start, DateTime end, CancellationToken ct = default)
        {
            return await FindAll(false)
                .Where(t => t.Type == TransactionType.PurchaseGame &&
                            t.Status == TransactionStatus.Success &&
                            t.GameId == gameId &&
                            t.CreatedAt >= start &&
                            t.CreatedAt <= end)
                .SumAsync(t => t.Amount, ct);
        }

        public async Task<DateTime?> GetFirstTransactionDateForGame(Guid gameId, CancellationToken ct = default)
        {
            return await FindAll(false)
                .Where(t => t.Type == TransactionType.PurchaseGame &&
                            t.Status == TransactionStatus.Success &&
                            t.GameId == gameId)
                .OrderBy(t => t.CreatedAt)
                .Select(t => (DateTime?)t.CreatedAt)
                .FirstOrDefaultAsync(ct);
        }

    }
}
