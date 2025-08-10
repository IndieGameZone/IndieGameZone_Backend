using IndieGameZone.Domain.Entities;
using IndieGameZone.Domain.IRepositories;
using IndieGameZone.Domain.RequestFeatures;
using IndieGameZone.Infrastructure.Extensions;
using IndieGameZone.Infrastructure.Persistence;
using Microsoft.EntityFrameworkCore;

namespace IndieGameZone.Infrastructure.Repositories
{
	internal sealed class DownloadSlotRepository : RepositoryBase<DownloadSlots>, IDownloadSlotRepository
	{
		public DownloadSlotRepository(AppDbContext appDbContext) : base(appDbContext)
		{
		}

		public void CreateDownloadSlot(DownloadSlots downloadSlots) => Create(downloadSlots);

		public async Task<IEnumerable<(int day, double numberOfDownloads)>> GetDownloadCountsByGameIdAsync(Guid gameId, int year, int month, CancellationToken ct = default)
		{
			var startDate = new DateTime(year, month, 1);
			var endDate = startDate.AddMonths(1);

			// Step 1: Do grouping and projection in SQL-compatible form
			var groupedDownloads = await FindByCondition(
					d => d.GameId == gameId &&
						 d.DownloadAt >= startDate &&
						 d.DownloadAt < endDate,
					trackChanges: false)
				.GroupBy(d => d.DownloadAt.Day)
				.Select(g => new
				{
					Day = g.Key,
					Count = g.Count()
				})
				.ToListAsync(ct);

			// Step 2: Project into tuple in-memory
			return groupedDownloads
				.Select(g => (g.Day, (double)g.Count));
		}

		public IQueryable<DownloadSlots> GetDownloadSlotsByGameId(Guid gameId, DownloadSlotParameters downloadSlotParameters, bool trackChange)
		{
			return FindByCondition(ds => ds.GameId == gameId, trackChange)
				.FilterByMonthAndYear(downloadSlotParameters.Year, downloadSlotParameters.Month);
		}

        public async Task<int> GetTotalDownloadsByGameIdAsync(Guid gameId, CancellationToken ct = default)
        {
            return await FindByCondition(d => d.GameId == gameId, trackChanges: false)
                .CountAsync(ct);
        }

    }
}
