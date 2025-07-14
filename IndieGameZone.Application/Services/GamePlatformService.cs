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

		public async Task CreateGamePlatform(Guid gameId, ICollection<GamePlatformForCreationDto> gamePlatformForCreationDto, CancellationToken ct = default)
		{
			var gamePlatforms = mapper.Map<ICollection<GamePlatforms>>(gamePlatformForCreationDto);
			foreach (var gamePlatform in gamePlatforms)
			{
				gamePlatform.Id = Guid.NewGuid();
				gamePlatform.GameId = gameId;
				var blobName = gamePlatform.File.Split('/').Last();
				gamePlatform.DisplayName = await blobService.GetBlobOriginalName(blobName, StorageContainer.STORAGE_CONTAINER);
				gamePlatform.Size = await blobService.GetBlobSize(blobName, StorageContainer.STORAGE_CONTAINER);
				gamePlatform.IsActive = true;
			}
			repositoryManager.GamePlatformRepository.CreateGamePlatform(gamePlatforms);
			await repositoryManager.SaveAsync(ct);
		}

		public async Task UpdateGamePlatform(Guid gameId, ICollection<GamePlatformForUpdateDto> gamePlatformForUpdateDto, CancellationToken ct = default)
		{
			var existingGamePlatforms = await repositoryManager.GamePlatformRepository.GetGamePlatformsByGameId(gameId, false, ct);
			if (existingGamePlatforms is not null && existingGamePlatforms.Any())
			{
				foreach (var platform in existingGamePlatforms)
				{
					if (platform.File != null)
					{
						await blobService.DeleteBlob(platform.File.Split('/').Last(), StorageContainer.STORAGE_CONTAINER);
					}
				}
			}
			repositoryManager.GamePlatformRepository.DeleteGamePlatform(existingGamePlatforms);

			var gamePlatforms = mapper.Map<ICollection<GamePlatforms>>(gamePlatformForUpdateDto);
			foreach (var gamePlatform in gamePlatforms)
			{
				gamePlatform.Id = Guid.NewGuid();
				gamePlatform.GameId = gameId;
				var blobName = gamePlatform.File.Split('/').Last();
				gamePlatform.DisplayName = blobName.Split('.').First();
				gamePlatform.Size = await blobService.GetBlobSize(blobName, StorageContainer.STORAGE_CONTAINER);
				gamePlatform.IsActive = true;
			}

			repositoryManager.GamePlatformRepository.CreateGamePlatform(gamePlatforms);
			await repositoryManager.SaveAsync(ct);
		}

		public async Task UpdateGamePlatformActivationStatus(Guid developerId, Guid gamePlatformId, bool isActive, CancellationToken ct = default)
		{
			var gamePlatform = await repositoryManager.GamePlatformRepository.GetGamePlatformsById(gamePlatformId, true, ct);
			if (gamePlatform is null)
			{
				throw new NotFoundException($"Game platform not found.");
			}
			var game = await repositoryManager.GameRepository.GetGameById(gamePlatform.GameId, false, ct);
			if (game.DeveloperId != developerId)
			{
				throw new ForbiddenException($"You are not authorized to update the game platform for this game.");
			}
			gamePlatform.IsActive = isActive;
			await repositoryManager.SaveAsync(ct);
		}
	}
}
