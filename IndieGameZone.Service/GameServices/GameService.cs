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

			// Handle Game Platforms
			var existingGamePlatforms = await repositoryManager.GamePlatformRepository.GetGamePlatformsByGameId(gameId, false, ct);
			if (existingGamePlatforms is not null && existingGamePlatforms.Any())
			{
				foreach (var platform in existingGamePlatforms)
				{
					await blobService.DeleteBlob(platform.File.Split('/').Last(), StorageContainer.STORAGE_CONTAINER);
				}
			}
			repositoryManager.GamePlatformRepository.DeleteGamePlatform(existingGamePlatforms);

			//Handle Game Info Entities
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

			//Handle Game Language
			repositoryManager.GameLanguageRepository.DeleteGameLanguage(await repositoryManager.GameLanguageRepository.GetGameLanguagesByGameId(gameId, false, ct));

			//Handle Game Tags
			repositoryManager.GameTagRepository.DeleteGameTag(await repositoryManager.GameTagRepository.GetGameTagsByGameId(gameId, false, ct));
			await repositoryManager.SaveAsync(ct);

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
				string filename = $"{Guid.NewGuid()}{Path.GetExtension(game.GamePlatforms.ElementAt(i).File.FileName)}";
				gamePlatformEntitys[i].File = await blobService.UploadBlob(filename, StorageContainer.STORAGE_CONTAINER, game.GamePlatforms.ElementAt(i).File);
			}
			repositoryManager.GamePlatformRepository.CreateGamePlatform(gamePlatformEntitys);

			//Handle Game Info Entities
			var gameInfoEntitys = (mapper.Map<IEnumerable<GameInfos>>(game.GameInfos)).ToList();
			for (int i = 0; i < gameInfoEntitys.Count(); i++)
			{
				gameInfoEntitys[i].Id = Guid.NewGuid();
				gameInfoEntitys[i].GameId = gameEntity.Id;
				if (game.GameInfos.ElementAt(i).Image is not null && game.GameInfos.ElementAt(i).Image.Length > 0)
				{
					string infoImageFilename = $"{game.Name}Image{i + 1}{Path.GetExtension(game.GameInfos.ElementAt(i).Image.FileName)}";
					gameInfoEntitys[i].Image = await blobService.UploadBlob(infoImageFilename, StorageContainer.STORAGE_CONTAINER, game.GameInfos.ElementAt(i).Image);
				}
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

		public async Task UpdateGame(Guid developerId, Guid gameId, GameForUpdateDto game, CancellationToken ct = default)
		{
			var gameEntity = await repositoryManager.GameRepository.GetGameById(gameId, true, ct);
			if (gameEntity is null)
			{
				throw new NotFoundException($"Game not found.");
			}
			if (gameEntity.DeveloperId != developerId)
			{
				throw new ForbiddenException("You do not have permission to update this game.");
			}
			mapper.Map(game, gameEntity);
			if (game.CoverImage is not null && game.CoverImage.Length > 0)
			{
				await blobService.DeleteBlob(gameEntity.CoverImage.Split('/').Last(), StorageContainer.STORAGE_CONTAINER);
				string coverImageFilename = $"{game.Name}CoverImage{Path.GetExtension(game.CoverImage.FileName)}";
				gameEntity.CoverImage = await blobService.UploadBlob(coverImageFilename, StorageContainer.STORAGE_CONTAINER, game.CoverImage);
			}

			// Handle Game Platforms
			var existingGamePlatforms = await repositoryManager.GamePlatformRepository.GetGamePlatformsByGameId(gameId, false, ct);
			if (existingGamePlatforms is not null && existingGamePlatforms.Any())
			{
				foreach (var platform in existingGamePlatforms)
				{
					await blobService.DeleteBlob(platform.File.Split('/').Last(), StorageContainer.STORAGE_CONTAINER);
				}
			}
			repositoryManager.GamePlatformRepository.DeleteGamePlatform(existingGamePlatforms);
			var gamePlatformEntitys = (mapper.Map<IEnumerable<GamePlatforms>>(game.GamePlatforms)).ToList();
			for (int i = 0; i < gamePlatformEntitys.Count(); i++)
			{
				gamePlatformEntitys[i].GameId = gameEntity.Id;
				if (game.GamePlatforms.ElementAt(i).File is not null && game.GamePlatforms.ElementAt(i).File.Length > 0)
				{
					string filename = $"{Guid.NewGuid()}{Path.GetExtension(game.GamePlatforms.ElementAt(i).File.FileName)}";
					gamePlatformEntitys[i].File = await blobService.UploadBlob(filename, StorageContainer.STORAGE_CONTAINER, game.GamePlatforms.ElementAt(i).File);
				}
			}
			repositoryManager.GamePlatformRepository.CreateGamePlatform(gamePlatformEntitys);

			//Handle Game Info Entities
			var existingGameInfos = await repositoryManager.GameInfoRepository.GetGameInfosByGameId(gameEntity.Id, false, ct);
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
			var gameInfoEntitys = (mapper.Map<IEnumerable<GameInfos>>(game.GameInfos)).ToList();
			for (int i = 0; i < gameInfoEntitys.Count(); i++)
			{
				gameInfoEntitys[i].Id = Guid.NewGuid();
				gameInfoEntitys[i].GameId = gameEntity.Id;
				if (game.GameInfos.ElementAt(i).Image is not null && game.GameInfos.ElementAt(i).Image.Length > 0)
				{
					//await blobService.DeleteBlob(gameEntity.GamePlatforms.ElementAt(i).File.Split('/').Last(), StorageContainer.STORAGE_CONTAINER);
					string infoImageFilename = $"{game.Name}Image{i + 1}{Path.GetExtension(game.GameInfos.ElementAt(i).Image.FileName)}";
					gameInfoEntitys[i].Image = await blobService.UploadBlob(infoImageFilename, StorageContainer.STORAGE_CONTAINER, game.GameInfos.ElementAt(i).Image);
				}
			}
			repositoryManager.GameInfoRepository.CreateGameInfo(gameInfoEntitys);

			//Handle Game Language
			repositoryManager.GameLanguageRepository.DeleteGameLanguage(await repositoryManager.GameLanguageRepository.GetGameLanguagesByGameId(gameId, false, ct));
			var gameLanguageEntitys = game.LanguageIds.Select(id => new GameLanguages { LanguageId = id, GameId = gameEntity.Id });
			repositoryManager.GameLanguageRepository.CreateGameLanguage(gameLanguageEntitys);

			//Handle Game Tags
			repositoryManager.GameTagRepository.DeleteGameTag(await repositoryManager.GameTagRepository.GetGameTagsByGameId(gameId, false, ct));
			var gameTagEntitys = game.TagIds.Select(id => new GameTags { TagId = id, GameId = gameEntity.Id });
			repositoryManager.GameTagRepository.CreateGameTag(gameTagEntitys);

			await repositoryManager.SaveAsync(ct);
		}
	}
}
