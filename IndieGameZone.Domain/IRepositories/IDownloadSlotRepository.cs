using IndieGameZone.Domain.Entities;
using IndieGameZone.Domain.RequestFeatures;

namespace IndieGameZone.Domain.IRepositories
{
	public interface IDownloadSlotRepository
	{
		void CreateDownloadSlot(DownloadSlots downloadSlots);
		IQueryable<DownloadSlots> GetDownloadSlotsByGameId(Guid gameId, DownloadSlotParameters downloadSlotParameters, bool trackChange);
		Task<IEnumerable<(int day, double numberOfDownloads)>> GetDownloadCountsByGameIdAsync(Guid gameId, int year, int month, CancellationToken ct = default);

	}
}
