using IndieGameZone.Application.BlobService;
using IndieGameZone.Domain.Constants;
using IndieGameZone.Domain.Entities;
using IndieGameZone.Domain.IRepositories;
using IndieGameZone.Domain.RequestsAndResponses.Requests.GamePlatforms;
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

		public async Task CreateGamePlatform(Guid gameId, ICollection<GamePlatformForCreationDto> gamePlatformForCreationDto, CancellationToken ct = default)
		{
			var gamePlatforms = mapper.Map<ICollection<GamePlatforms>>(gamePlatformForCreationDto);
			foreach (var gamePlatform in gamePlatforms)
			{
				gamePlatform.Id = Guid.NewGuid();
				gamePlatform.GameId = gameId;
				var blobName = gamePlatform.File.Split('/').Last();
				gamePlatform.DisplayName = blobName.Split("%2A").Last();
				gamePlatform.Size = await blobService.GetBlobSize(blobName, StorageContainer.STORAGE_CONTAINER);
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
			}

			repositoryManager.GamePlatformRepository.CreateGamePlatform(gamePlatforms);
			await repositoryManager.SaveAsync(ct);
		}
	}
}
