using IndieGameZone.Application.BlobService;
using IndieGameZone.Domain.Constants;
using IndieGameZone.Domain.Entities;
using IndieGameZone.Domain.IRepositories;
using IndieGameZone.Domain.RequestsAndResponses.Requests.GameInfos;
using IndieGameZone.Domain.RequestsAndResponses.Responses.GameInfos;
using MapsterMapper;

namespace IndieGameZone.Application.GameInfoServices
{
	internal sealed class GameInfoService : IGameInfoService
	{
		private readonly IRepositoryManager repositoryManager;
		private readonly IMapper mapper;
		private readonly IBlobService blobService;

		public GameInfoService(IRepositoryManager repositoryManager, IMapper mapper, IBlobService blobService)
		{
			this.repositoryManager = repositoryManager;
			this.mapper = mapper;
			this.blobService = blobService;
		}
		public async Task CreateGameInfo(Guid gameId, IEnumerable<GameInfoForCreationDto> gameInfoForCreationDtos, CancellationToken ct = default)
		{
			var gameInfoEntities = (mapper.Map<IEnumerable<GameImages>>(gameInfoForCreationDtos)).ToList();
			var game = await repositoryManager.GameRepository.GetGameById(gameId, false, ct);
			for (int i = 0; i < gameInfoEntities.Count; i++)
			{
				gameInfoEntities[i].GameId = gameId;
				gameInfoEntities[i].Id = Guid.NewGuid();
				if (gameInfoForCreationDtos.ElementAt(i).Image is not null && gameInfoForCreationDtos.ElementAt(i).Image.Length > 0)
				{
					string infoImageFilename = $"{game.Name}Image{i + 1}{Path.GetExtension(gameInfoForCreationDtos.ElementAt(i).Image.FileName)}";
					gameInfoEntities[i].Image = await blobService.UploadBlob(infoImageFilename, StorageContainer.STORAGE_CONTAINER, gameInfoForCreationDtos.ElementAt(i).Image);
				}
			}
			repositoryManager.GameInfoRepository.CreateGameInfo(gameInfoEntities);
			await repositoryManager.SaveAsync(ct);
		}

		public async Task<IEnumerable<GameInfoForReturnDto>> GetGameInfosByGameId(Guid gameId, CancellationToken ct = default)
		{
			var gameInfoEntities = await repositoryManager.GameInfoRepository.GetGameInfosByGameId(gameId, false, ct);
			return mapper.Map<IEnumerable<GameInfoForReturnDto>>(gameInfoEntities);
		}

		public async Task UpdateGameInfosByGameId(Guid gameId, IEnumerable<GameInfoForUpdateDto> gameInfoForUpdateDtos, CancellationToken ct = default)
		{
			var game = await repositoryManager.GameRepository.GetGameById(gameId, false, ct);
			var existingGameInfos = await repositoryManager.GameInfoRepository.GetGameInfosByGameId(gameId, false, ct);
			if (existingGameInfos is not null && existingGameInfos.Any())
			{
				foreach (var info in existingGameInfos)
				{
					if (info.Image is not null)
					{
						await blobService.DeleteBlob(info.Image.Split('/').Last(), StorageContainer.STORAGE_CONTAINER);
					}
				}
			}
			repositoryManager.GameInfoRepository.DeleteGameInfo(existingGameInfos);

			var newGameInfoEntities = mapper.Map<IEnumerable<GameImages>>(gameInfoForUpdateDtos).ToList();
			for (int i = 0; i < newGameInfoEntities.Count; i++)
			{
				newGameInfoEntities[i].Id = Guid.NewGuid();
				newGameInfoEntities[i].GameId = gameId;
				if (gameInfoForUpdateDtos.ElementAt(i).Image is not null && gameInfoForUpdateDtos.ElementAt(i).Image.Length > 0)
				{
					//await blobService.DeleteBlob(gameEntity.GamePlatforms.ElementAt(i).File.Split('/').Last(), StorageContainer.STORAGE_CONTAINER);
					string infoImageFilename = $"{game.Name}Image{i + 1}{Path.GetExtension(gameInfoForUpdateDtos.ElementAt(i).Image.FileName)}";
					newGameInfoEntities[i].Image = await blobService.UploadBlob(infoImageFilename, StorageContainer.STORAGE_CONTAINER, gameInfoForUpdateDtos.ElementAt(i).Image);
				}
			}
			repositoryManager.GameInfoRepository.CreateGameInfo(newGameInfoEntities);
			await repositoryManager.SaveAsync(ct);
		}
	}
}
