using IndieGameZone.Domain.Entities;

namespace IndieGameZone.Domain.IRepositories
{
	public interface IDownloadSlotRepository
	{
		void CreateDownloadSlot(DownloadSlots downloadSlots);
		IQueryable<DownloadSlots> GetDownloadSlotsByGameId(Guid gameId, bool trackChange);
	}
}
