using IndieGameZone.Application.BlobService;
using IndieGameZone.Domain.Constants;
using IndieGameZone.Domain.Entities;
using IndieGameZone.Domain.Exceptions;
using IndieGameZone.Domain.IRepositories;
using IndieGameZone.Domain.RequestFeatures;
using IndieGameZone.Domain.RequestsAndResponses.Requests.Games;
using IndieGameZone.Domain.RequestsAndResponses.Responses.Games;
using MapsterMapper;

namespace IndieGameZone.Application.GameServices
{
	internal sealed class GameService : IGameService
	{
		private readonly IRepositoryManager repositoryManager;
		private readonly IMapper mapper;
		private readonly IBlobService blobService;

		public GameService(IRepositoryManager repositoryManager, IMapper mapper, IBlobService blobService)
		{
			this.repositoryManager = repositoryManager;
			this.mapper = mapper;
			this.blobService = blobService;
		}

		public async Task<(IEnumerable<GameForListReturnDto> games, MetaData metaData)> GetGames(GameParameters gameParameters, CancellationToken ct = default)
		{
			var gamesWithMetaData = await repositoryManager.GameRepository.GetGames(gameParameters, false, ct);
			var games = mapper.Map<IEnumerable<GameForListReturnDto>>(gamesWithMetaData);
			return (games, gamesWithMetaData.MetaData);
		}

		public async Task<GameForSingleReturnDto> GetGameById(Guid gameId, CancellationToken ct = default)
		{
			var gameEntity = await repositoryManager.GameRepository.GetGameById(gameId, false, ct);
			if (gameEntity is null)
			{
				throw new NotFoundException($"Game not found.");
			}
			return mapper.Map<GameForSingleReturnDto>(gameEntity);
		}

		public async Task DeleteGame(Guid developerId, Guid gameId, CancellationToken ct = default)
		{
			var gameEntity = await repositoryManager.GameRepository.GetGameById(gameId, false, ct);
			if (gameEntity is null)
			{
				throw new NotFoundException($"Game not found.");
			}
			if (gameEntity.DeveloperId != developerId)
			{
				throw new ForbiddenException("You do not have permission to delete this game.");
			}
			repositoryManager.GameRepository.DeleteGame(gameEntity);
			await repositoryManager.SaveAsync(ct);
		}

		public async Task<(IEnumerable<GameForListReturnDto> games, MetaData metaData)> GetGamesByDeveloperId(Guid developerId, GameParameters gameParameters, CancellationToken ct = default)
		{
			var gamesWithMetaData = await repositoryManager.GameRepository.GetGamesByDeveloperId(developerId, gameParameters, false, ct);
			var games = mapper.Map<IEnumerable<GameForListReturnDto>>(gamesWithMetaData);
			return (games, gamesWithMetaData.MetaData);
		}

		public async Task CreateGame(Guid developerId, GameForCreationDto game, CancellationToken ct = default)
		{
			var gameEntity = mapper.Map<Games>(game);
			gameEntity.Id = Guid.NewGuid();
			gameEntity.DeveloperId = developerId;
			gameEntity.ReleasedDate = DateTime.Now;
			gameEntity.IsActive = true;
			if (game.CoverImage is not null && game.CoverImage.Length > 0)
			{
				string coverImageFilename = $"{game.Name}CoverImage{Path.GetExtension(game.CoverImage.FileName)}";
				gameEntity.CoverImage = await blobService.UploadBlob(coverImageFilename, StorageContainer.STORAGE_CONTAINER, game.CoverImage);
			}

			// Handle Game Platforms
			var gamePlatformEntitys = (mapper.Map<IEnumerable<GamePlatforms>>(game.GamePlatforms)).ToList();
			for (int i = 0; i < gamePlatformEntitys.Count(); i++)
			{
				gamePlatformEntitys[i].GameId = gameEntity.Id;
				var platformName = repositoryManager.PlatformRepository.GetPlatformById(gamePlatformEntitys[i].PlatformId, false, ct);
				string filename = $"{game.Name}_{platformName}{Path.GetExtension(game.GamePlatforms.ElementAt(i).File.FileName)}";
				gamePlatformEntitys[i].File = await blobService.UploadBlob(filename, StorageContainer.STORAGE_CONTAINER, game.GamePlatforms.ElementAt(i).File);
			}
			repositoryManager.GamePlatformRepository.CreateGamePlatform(gamePlatformEntitys);

			//Handle Game Info Entities
			var gameInfoEntitys = (mapper.Map<IEnumerable<GameInfos>>(game.GameInfos)).ToList();
			for (int i = 0; i < gameInfoEntitys.Count(); i++)
			{
				gameInfoEntitys[i].GameId = gameEntity.Id;
			}
			repositoryManager.GameInfoRepository.CreateGameInfo(gameInfoEntitys);

			//Handle Game Language
			var gameLanguageEntitys = game.LanguageIds.Select(id => new GameLanguages { LanguageId = id, GameId = gameEntity.Id });
			repositoryManager.GameLanguageRepository.CreateGameLanguage(gameLanguageEntitys);

			//Handle Game Tags
			var gameTagEntitys = game.TagIds.Select(id => new GameTags { TagId = id, GameId = gameEntity.Id });
			repositoryManager.GameTagRepository.CreateGameTag(gameTagEntitys);


			//Handle Games
			repositoryManager.GameRepository.CreateGame(gameEntity);

			await repositoryManager.SaveAsync(ct);
		}

		public Task UpdateGame(Guid developerId, Guid gameId, GameForUpdateDto game, CancellationToken ct = default)
		{
			throw new NotImplementedException();
		}
	}
}
