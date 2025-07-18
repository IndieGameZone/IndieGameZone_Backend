using IndieGameZone.Domain.Entities;
using IndieGameZone.Domain.IRepositories;
using IndieGameZone.Infrastructure.Persistence;

namespace IndieGameZone.Infrastructure.Repositories
{
	internal sealed class DownloadSlotRepository : RepositoryBase<DownloadSlots>, IDownloadSlotRepository
	{
		public DownloadSlotRepository(AppDbContext appDbContext) : base(appDbContext)
		{
		}

		public void CreateDownloadSlot(DownloadSlots downloadSlots) => Create(downloadSlots);

		public IQueryable<DownloadSlots> GetDownloadSlotsByGameId(Guid gameId, bool trackChange) => FindByCondition(ds => ds.GameId == gameId, trackChange);
	}
}
