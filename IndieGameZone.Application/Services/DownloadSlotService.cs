using IndieGameZone.Application.IServices;
using IndieGameZone.Domain.IRepositories;
using IndieGameZone.Domain.RequestFeatures;
using Microsoft.EntityFrameworkCore;

namespace IndieGameZone.Application.Services
{
	public class DownloadSlotService : IDownloadSlotService
	{
		private readonly IRepositoryManager repositoryManager;

		public DownloadSlotService(IRepositoryManager repositoryManager)
		{
			this.repositoryManager = repositoryManager;
		}
		public async Task<int> GetNumberOfDownloadSlots(Guid gameId, DownloadSlotParameters downloadSlotParameters, CancellationToken ct = default)
		{
			return await repositoryManager.DownloadSlotRepository.GetDownloadSlotsByGameId(gameId, downloadSlotParameters, false).CountAsync(ct);
		}
	}
}
