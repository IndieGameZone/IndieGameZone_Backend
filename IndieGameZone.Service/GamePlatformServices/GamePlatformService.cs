using IndieGameZone.Application.BlobService;
using IndieGameZone.Domain.Constants;
using IndieGameZone.Domain.Entities;
using IndieGameZone.Domain.IRepositories;
using IndieGameZone.Domain.RequestsAndResponses.Requests.GamePlatforms;
using IndieGameZone.Domain.RequestsAndResponses.Responses.GamePlatforms;
using MapsterMapper;

namespace IndieGameZone.Application.GamePlatformServices
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
		public async Task CreateGamePlatforms(Guid gameId, IEnumerable<GamePlatformForCreationDto> gamePlatformForCreationDtos, CancellationToken ct = default)
		{
			var gamePlatformEntities = mapper.Map<IEnumerable<GamePlatforms>>(gamePlatformForCreationDtos).ToList();
			for (int i = 0; i < gamePlatformEntities.Count; i++)
			{
				gamePlatformEntities[i].GameId = gameId;
				string filename = $"{Guid.NewGuid()}{Path.GetExtension(gamePlatformForCreationDtos.ElementAt(i).File.FileName)}";
				gamePlatformEntities[i].File = await blobService.UploadBlob(filename, StorageContainer.STORAGE_CONTAINER, gamePlatformForCreationDtos.ElementAt(i).File);
			}
			repositoryManager.GamePlatformRepository.CreateGamePlatform(gamePlatformEntities);
			await repositoryManager.SaveAsync(ct);
		}

		public async Task<IEnumerable<GamePlatformForReturnDto>> GetGamePlatformsByGameId(Guid gameId, CancellationToken ct = default)
		{
			var gamePlatformEntities = await repositoryManager.GamePlatformRepository.GetGamePlatformsByGameId(gameId, false, ct);
			return mapper.Map<IEnumerable<GamePlatformForReturnDto>>(gamePlatformEntities);
		}

		private async Task DeleteOldContentBeforeUpdate(Guid gameId, CancellationToken ct = default)
		{
			var existingGamePlatforms = await repositoryManager.GamePlatformRepository.GetGamePlatformsByGameId(gameId, false, ct);
			if (existingGamePlatforms is not null && existingGamePlatforms.Any())
			{
				foreach (var platform in existingGamePlatforms)
				{
					await blobService.DeleteBlob(platform.File.Split('/').Last(), StorageContainer.STORAGE_CONTAINER);
				}
			}
			repositoryManager.GamePlatformRepository.DeleteGamePlatform(existingGamePlatforms);
			await repositoryManager.SaveAsync(ct);
		}

		public async Task UpdateGamePlatformsByGameId(Guid gameId, IEnumerable<GamePlatformForUpdateDto> gamePlatformForUpdateDtos, CancellationToken ct = default)
		{
			await DeleteOldContentBeforeUpdate(gameId, ct);
			var newGamePlatformEntities = mapper.Map<IEnumerable<GamePlatforms>>(gamePlatformForUpdateDtos).ToList();
			for (int i = 0; i < newGamePlatformEntities.Count; i++)
			{
				newGamePlatformEntities[i].GameId = gameId;
				if (gamePlatformForUpdateDtos.ElementAt(i).File is not null && gamePlatformForUpdateDtos.ElementAt(i).File.Length > 0)
				{
					string filename = $"{Guid.NewGuid()}{Path.GetExtension(gamePlatformForUpdateDtos.ElementAt(i).File.FileName)}";
					newGamePlatformEntities[i].File = await blobService.UploadBlob(filename, StorageContainer.STORAGE_CONTAINER, gamePlatformForUpdateDtos.ElementAt(i).File);
				}
			}
			repositoryManager.GamePlatformRepository.CreateGamePlatform(newGamePlatformEntities);
			await repositoryManager.SaveAsync(ct);
		}
	}
}
