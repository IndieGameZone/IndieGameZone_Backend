using IndieGameZone.Domain.RequestFeatures;

namespace IndieGameZone.Application.IServices
{
	public interface IDownloadSlotService
	{
		Task<int> GetNumberOfDownloadSlots(Guid gameId, DownloadSlotParameters downloadSlotParameters, CancellationToken ct = default);
	}
}
