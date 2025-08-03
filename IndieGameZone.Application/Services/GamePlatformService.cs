using IndieGameZone.Application.IServices;
using IndieGameZone.Domain.Constants;
using IndieGameZone.Domain.Entities;
using IndieGameZone.Domain.Exceptions;
using IndieGameZone.Domain.IRepositories;
using IndieGameZone.Domain.RequestsAndResponses.Requests.GamePlatforms;
using MapsterMapper;

namespace IndieGameZone.Application.Services
{
	internal sealed class GamePlatformService : IGamePlatformService
	{
		private readonly IRepositoryManager repositoryManager;
		private readonly IMapper mapper;
		private readonly IBlobService blobService;

		public GamePlatformService(IRepositoryManager repositoryManager, IMapper mapper, IBlobService blobService)
		{
			this.repositoryManager = repositoryManager;
			this.mapper = mapper;
			this.blobService = blobService;
		}

		private async Task DeleteOldGamePlatform(Guid gameId, IEnumerable<string> newGamePlatformsFile, CancellationToken ct)
		{
			var existingGamePlatforms = await repositoryManager.GamePlatformRepository.GetGamePlatformsByGameId(gameId, false, ct);
			var existingGameFileUrls = existingGamePlatforms.Select(gp => gp.File).ToList();
			if (existingGameFileUrls is null || !existingGameFileUrls.Any())
			{
				return;
			}
			var platformsToDelete = existingGameFileUrls.Except(newGamePlatformsFile);
			foreach (var platform in platformsToDelete)
			{
				await blobService.DeleteBlob(platform.Split('/').Last(), StorageContainer.STORAGE_CONTAINER);
			}
			repositoryManager.GamePlatformRepository.DeleteGamePlatform(existingGamePlatforms);
			await repositoryManager.SaveAsync(ct);
		}

		public async Task CreateGamePlatform(Guid gameId, ICollection<GamePlatformForCreationDto> gamePlatformForCreationDto, CancellationToken ct = default)
		{
			var gamePlatforms = mapper.Map<ICollection<GamePlatforms>>(gamePlatformForCreationDto);
			foreach (var gamePlatform in gamePlatforms)
			{
				gamePlatform.Id = Guid.NewGuid();
				gamePlatform.GameId = gameId;
				var blobName = gamePlatform.File.Split('/').Last();
				gamePlatform.Size = await blobService.GetBlobSize(blobName, StorageContainer.STORAGE_CONTAINER);
				gamePlatform.IsActive = true;
				gamePlatform.CreatedAt = DateTime.Now;
			}
			repositoryManager.GamePlatformRepository.CreateGamePlatform(gamePlatforms);
			await repositoryManager.SaveAsync(ct);
		}

		public async Task UpdateGamePlatform(Guid gameId, ICollection<GamePlatformForUpdateDto> gamePlatformForUpdateDto, CancellationToken ct = default)
		{
			var dbTransaction = await repositoryManager.BeginTransaction(ct);
			await DeleteOldGamePlatform(gameId, gamePlatformForUpdateDto.Select(gp => gp.File), ct);

			var gamePlatforms = mapper.Map<ICollection<GamePlatforms>>(gamePlatformForUpdateDto);
			foreach (var gamePlatform in gamePlatforms)
			{
				gamePlatform.Id = Guid.NewGuid();
				gamePlatform.GameId = gameId;
				var blobName = gamePlatform.File.Split('/').Last();
				gamePlatform.Size = await blobService.GetBlobSize(blobName, StorageContainer.STORAGE_CONTAINER);
				gamePlatform.IsActive = true;
				gamePlatform.CreatedAt = DateTime.Now;
			}

			repositoryManager.GamePlatformRepository.CreateGamePlatform(gamePlatforms);
			await repositoryManager.SaveAsync(ct);
			dbTransaction.Commit();
		}

		public async Task UpdateGamePlatformActivationStatus(Guid gamePlatformId, bool isActive, CancellationToken ct = default)
		{
			var gamePlatform = await repositoryManager.GamePlatformRepository.GetGamePlatformsById(gamePlatformId, true, ct);
			if (gamePlatform is null)
			{
				throw new NotFoundException($"Game platform not found.");
			}
			gamePlatform.IsActive = isActive;
			await repositoryManager.SaveAsync(ct);
		}

		public async Task UpdateGamePlatformById(Guid gamePlatformId, GamePlatformForUpdateDto gamePlatformForUpdateDto, CancellationToken ct = default)
		{
			var gamePlatform = await repositoryManager.GamePlatformRepository.GetGamePlatformsById(gamePlatformId, true, ct);
			if (gamePlatform is null)
			{
				throw new NotFoundException($"Game platform not found.");
			}
			if (gamePlatform.File != gamePlatformForUpdateDto.File)
			{
				var oldBlobName = gamePlatform.File.Split('/').Last();
				await blobService.DeleteBlob(oldBlobName, StorageContainer.STORAGE_CONTAINER);

				var blobName = gamePlatformForUpdateDto.File.Split('/').Last();
				gamePlatform.Size = await blobService.GetBlobSize(blobName, StorageContainer.STORAGE_CONTAINER);
				gamePlatform.File = gamePlatformForUpdateDto.File;
				gamePlatform.Version = gamePlatformForUpdateDto.Version;

				await repositoryManager.SaveAsync(ct);
			}
		}

		public async Task DeleteGamePlatform(Guid gamePlatformId, CancellationToken ct = default)
		{
			var gamePlatform = await repositoryManager.GamePlatformRepository.GetGamePlatformsById(gamePlatformId, true, ct);
			if (gamePlatform is null)
			{
				throw new NotFoundException($"Game platform not found.");
			}
			var blobName = gamePlatform.File.Split('/').Last();
			await blobService.DeleteBlob(blobName, StorageContainer.STORAGE_CONTAINER);
			repositoryManager.GamePlatformRepository.DeleteGamePlatform(gamePlatform);
			await repositoryManager.SaveAsync(ct);
		}
	}
}
