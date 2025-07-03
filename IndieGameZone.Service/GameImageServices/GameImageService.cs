
using IndieGameZone.Application.BlobService;
using IndieGameZone.Domain.Constants;
using IndieGameZone.Domain.Entities;
using IndieGameZone.Domain.Exceptions;
using IndieGameZone.Domain.IRepositories;

namespace IndieGameZone.Application.GameImageServices
{
	internal sealed class GameImageService : IGameImageService
	{
		private readonly IRepositoryManager repositoryManager;
		private readonly IBlobService blobService;

		public GameImageService(IRepositoryManager repositoryManager, IBlobService blobService)
		{
			this.repositoryManager = repositoryManager;
			this.blobService = blobService;
		}

		private async Task DeleteOldGameImages(Guid gameId, CancellationToken ct)
		{
			var existingGameImages = await repositoryManager.GameImageRepository.GetGameImagesByGameId(gameId, false, ct);
			if (existingGameImages is not null && existingGameImages.Any())
			{
				foreach (var info in existingGameImages)
				{
					await blobService.DeleteBlob(info.Image.Split('/').Last(), StorageContainer.STORAGE_CONTAINER);
				}
			}
			repositoryManager.GameImageRepository.DeleteGameImage(existingGameImages);
			await repositoryManager.SaveAsync(ct);
		}

		public async Task UpdateGameImages(Guid gameId, ICollection<string> images, CancellationToken ct = default)
		{
			if (images is null || !images.Any())
			{
				throw new BadRequestException("No images provided.");
			}
			await DeleteOldGameImages(gameId, ct);
			var gameImageEntities = new List<GameImages>();
			foreach (var image in images)
			{
				gameImageEntities.Add(new GameImages
				{
					Id = Guid.NewGuid(),
					GameId = gameId,
					Image = image,
				});
			}
			repositoryManager.GameImageRepository.CreateGameImage(gameImageEntities);
			await repositoryManager.SaveAsync(ct);
		}
	}
}
