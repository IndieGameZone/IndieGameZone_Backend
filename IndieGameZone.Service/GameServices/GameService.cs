using IndieGameZone.Application.BackgroundJobServices;
using IndieGameZone.Application.BlobService;
using IndieGameZone.Application.RecombeeServices;
using IndieGameZone.Domain.Constants;
using IndieGameZone.Domain.Entities;
using IndieGameZone.Domain.Exceptions;
using IndieGameZone.Domain.IRepositories;
using IndieGameZone.Domain.RequestFeatures;
using IndieGameZone.Domain.RequestsAndResponses.Requests.Games;
using IndieGameZone.Domain.RequestsAndResponses.Responses.Games;
using MapsterMapper;
using Microsoft.Extensions.Configuration;
using Quartz;

namespace IndieGameZone.Application.GameServices
{
	internal sealed class GameService : IGameService
	{
		private readonly IRepositoryManager repositoryManager;
		private readonly IMapper mapper;
		private readonly IBlobService blobService;
		private readonly IConfiguration configuration;
		private readonly ISchedulerFactory schedulerFactory;
		private readonly IRecombeeService recombeeService;

		public GameService(IRepositoryManager repositoryManager, IMapper mapper, IBlobService blobService, IConfiguration configuration, ISchedulerFactory schedulerFactory, IRecombeeService recombeeService)
		{
			this.repositoryManager = repositoryManager;
			this.mapper = mapper;
			this.blobService = blobService;
			this.configuration = configuration;
			this.schedulerFactory = schedulerFactory;
			this.recombeeService = recombeeService;
		}

		public async Task<(IEnumerable<GameForListReturnDto> games, MetaData metaData)> GetGames(GameParameters gameParameters, CancellationToken ct = default)
		{
			var gamesWithMetaData = await repositoryManager.GameRepository.GetGames(gameParameters, false, ct);
			var games = (mapper.Map<IEnumerable<GameForListReturnDto>>(gamesWithMetaData)).ToList();
			for (int i = 0; i < games.Count; i++)
			{
				var discount = await repositoryManager.DiscountRepository.GetActiveDiscountByGameId(gamesWithMetaData[i].Id, false, ct);
				games[i].PriceAfterDiscount = discount is not null ? games[i].Price - (games[i].Price * discount.Percentage / 100) : games[i].Price;
			}
			return (games, gamesWithMetaData.MetaData);
		}

		public async Task<GameForSingleReturnDto> GetGameById(Guid playerId, Guid gameId, CancellationToken ct = default)
		{
			var gameEntity = await repositoryManager.GameRepository.GetGameById(gameId, false, ct);
			if (gameEntity is null)
			{
				throw new NotFoundException($"Game not found.");
			}
			var gameDto = mapper.Map<GameForSingleReturnDto>(gameEntity);
			var discount = await repositoryManager.DiscountRepository.GetActiveDiscountByGameId(gameId, false, ct);
			gameDto.PriceAfterDiscount = discount is not null ? gameDto.Price - (gameDto.Price * discount.Percentage / 100) : gameDto.Price;

			await recombeeService.SendDetailViewEvent(playerId, gameId);
			return gameDto;
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

			//Handle Game Image Entities
			var existingGameInfos = await repositoryManager.GameImageRepository.GetGameImagesByGameId(gameId, false, ct);
			if (existingGameInfos is not null && existingGameInfos.Any())
			{
				foreach (var info in existingGameInfos)
				{
					if (info.Image != null)
					{
						await blobService.DeleteBlob(info.Image.Split('/').Last(), StorageContainer.STORAGE_CONTAINER);
					}
				}
			}

			await blobService.DeleteBlob(gameEntity.CoverImage.Split('/').Last(), StorageContainer.STORAGE_CONTAINER);

			repositoryManager.GameRepository.DeleteGame(gameEntity);
			await repositoryManager.SaveAsync(ct);

			await recombeeService.RemoveGameFromRecombee(gameId);
		}

		private async Task DeleteOldContentBeforeUpdate(Guid gameId, CancellationToken ct = default)
		{
			//Handle Game Image Entities
			var existingGameImages = await repositoryManager.GameImageRepository.GetGameImagesByGameId(gameId, false, ct);
			if (existingGameImages is not null && existingGameImages.Any())
			{
				foreach (var info in existingGameImages)
				{
					if (info.Image != null)
					{
						await blobService.DeleteBlob(info.Image.Split('/').Last(), StorageContainer.STORAGE_CONTAINER);
					}
				}
			}
			repositoryManager.GameImageRepository.DeleteGameImage(existingGameImages);

			//Handle Game Language
			repositoryManager.GameLanguageRepository.DeleteGameLanguage(await repositoryManager.GameLanguageRepository.GetGameLanguagesByGameId(gameId, false, ct));

			//Handle Game Tags
			repositoryManager.GameTagRepository.DeleteGameTag(await repositoryManager.GameTagRepository.GetGameTagsByGameId(gameId, false, ct));

			await repositoryManager.SaveAsync(ct);
		}

		public async Task<(IEnumerable<GameForListReturnDto> games, MetaData metaData)> GetGamesByDeveloperId(Guid developerId, GameParameters gameParameters, CancellationToken ct = default)
		{
			var gamesWithMetaData = await repositoryManager.GameRepository.GetGamesByDeveloperId(developerId, gameParameters, false, ct);
			var games = mapper.Map<IEnumerable<GameForListReturnDto>>(gamesWithMetaData);
			return (games, gamesWithMetaData.MetaData);
		}

		public async Task<Guid> CreateGame(Guid developerId, GameForCreationDto game, CancellationToken ct = default)
		{
			var gameEntity = mapper.Map<Games>(game);
			gameEntity.Id = Guid.NewGuid();
			gameEntity.DeveloperId = developerId;
			gameEntity.CreatedAt = DateTime.Now;
			gameEntity.NumberOfDownloads = 0;
			gameEntity.CensorStatus = CensorStatus.PendingAIReview;

			var gameImageEntities = new List<GameImages>();
			foreach (var image in game.GameImages)
			{
				gameImageEntities.Add(new GameImages
				{
					Id = Guid.NewGuid(),
					GameId = gameEntity.Id,
					Image = image
				});
			}
			repositoryManager.GameImageRepository.CreateGameImage(gameImageEntities);

			//Handle Game Language
			var gameLanguageEntitys = game.LanguageIds.Select(id => new GameLanguages { LanguageId = id, GameId = gameEntity.Id });
			repositoryManager.GameLanguageRepository.CreateGameLanguage(gameLanguageEntitys);

			//Handle Game Tags
			var gameTagEntitys = game.TagIds.Select(id => new GameTags { TagId = id, GameId = gameEntity.Id });
			repositoryManager.GameTagRepository.CreateGameTag(gameTagEntitys);

			//Handle Games
			repositoryManager.GameRepository.CreateGame(gameEntity);

			var gameCensorLogs = new GameCensorLogs
			{
				Id = Guid.NewGuid(),
				GameId = gameEntity.Id,
				CensorStatus = CensorStatus.PendingAIReview,
				CreatedAt = DateTime.Now
			};
			repositoryManager.GameCensorLogRepository.CreateCensorLog(gameCensorLogs);

			await repositoryManager.SaveAsync(ct);

			IJobDetail job = JobBuilder.Create<ValidateGameJob>()
				.WithIdentity("GameJob", "GameGroup")
				.UsingJobData("gameId", gameEntity.Id.ToString())
				.Build();

			ITrigger trigger = TriggerBuilder.Create()
				.WithIdentity("GameTrigger", "GameGroup")
				.StartNow()
				.Build();

			var scheduler = await schedulerFactory.GetScheduler(ct);

			await scheduler.ScheduleJob(job, trigger, ct);

			return gameEntity.Id;
		}

		public async Task UpdateGame(Guid developerId, Guid gameId, GameForUpdateDto game, CancellationToken ct = default)
		{
			await DeleteOldContentBeforeUpdate(gameId, ct);
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
			gameEntity.UpdatedAt = DateTime.Now;
			gameEntity.CensorStatus = CensorStatus.PendingAIReview;

			//Handle Game Images
			var gameImageEntities = new List<GameImages>();
			foreach (var image in game.GameImages)
			{
				gameImageEntities.Add(new GameImages
				{
					Id = Guid.NewGuid(),
					GameId = gameEntity.Id,
					Image = image,
				});
			}
			repositoryManager.GameImageRepository.CreateGameImage(gameImageEntities);

			//Handle Game Language
			var gameLanguageEntitys = game.LanguageIds.Select(id => new GameLanguages { LanguageId = id, GameId = gameEntity.Id });
			repositoryManager.GameLanguageRepository.CreateGameLanguage(gameLanguageEntitys);

			//Handle Game Tags
			var gameTagEntitys = game.TagIds.Select(id => new GameTags { TagId = id, GameId = gameEntity.Id });
			repositoryManager.GameTagRepository.CreateGameTag(gameTagEntitys);

			var gameCensorLogs = new GameCensorLogs
			{
				Id = Guid.NewGuid(),
				GameId = gameId,
				CensorStatus = CensorStatus.PendingAIReview,
				CreatedAt = DateTime.Now
			};
			repositoryManager.GameCensorLogRepository.CreateCensorLog(gameCensorLogs);

			await repositoryManager.SaveAsync(ct);

			IJobDetail job = JobBuilder.Create<ValidatePostJob>()
				.WithIdentity("GameJob", "GameGroup")
				.UsingJobData("gameId", gameEntity.Id.ToString())
				.Build();

			ITrigger trigger = TriggerBuilder.Create()
				.WithIdentity("GameTrigger", "GameGroup")
				.StartNow()
				.Build();

			var scheduler = await schedulerFactory.GetScheduler(ct);

			await scheduler.ScheduleJob(job, trigger, ct);
		}

		public async Task<(IEnumerable<GameForListReturnDto> games, MetaData metaData)> GetActiveGames(ActiveGameParameters activeGameParameters, CancellationToken ct = default)
		{
			var gamesWithMetaData = await repositoryManager.GameRepository.GetActiveGames(activeGameParameters, false, ct);
			var games = (mapper.Map<IEnumerable<GameForListReturnDto>>(gamesWithMetaData)).ToList();
			for (int i = 0; i < games.Count; i++)
			{
				var discount = await repositoryManager.DiscountRepository.GetActiveDiscountByGameId(gamesWithMetaData[i].Id, false, ct);
				games[i].PriceAfterDiscount = discount is not null ? games[i].Price - (games[i].Price * discount.Percentage / 100) : games[i].Price;
			}
			return (games, gamesWithMetaData.MetaData);
		}

		public async Task UpdateActiveStatus(Guid moderatorId, Guid gameId, GameActivationDto gameActivationDto, CancellationToken ct = default)
		{
			var gameEntity = await repositoryManager.GameRepository.GetGameById(gameId, true, ct);
			if (gameEntity is null)
			{
				throw new NotFoundException($"Game not found.");
			}
			gameEntity.CensorStatus = gameActivationDto.CensorStatus;

			var gameCensorLogs = new GameCensorLogs
			{
				Id = Guid.NewGuid(),
				GameId = gameId,
				ModeratorId = moderatorId,
				CensorStatus = gameActivationDto.CensorStatus,
				CensorReason = gameActivationDto.CensorReason,
				CensoredAt = DateTime.Now,
				CreatedAt = DateTime.Now
			};
			repositoryManager.GameCensorLogRepository.CreateCensorLog(gameCensorLogs);

			await repositoryManager.SaveAsync(ct);

			if (gameEntity.Visibility == GameVisibility.Public && gameEntity.CensorStatus == CensorStatus.Approved)
			{
				await recombeeService.PushGameToRecombee(gameId);
			}
		}

		public async Task<string> IncreaseNumberOfDownload(Guid gamePlatformId, CancellationToken ct = default)
		{
			var gamePlatform = await repositoryManager.GamePlatformRepository.GetGamePlatformsById(gamePlatformId, false, ct);
			var game = await repositoryManager.GameRepository.GetGameById(gamePlatform.GameId, true, ct);
			game.NumberOfDownloads++;
			await repositoryManager.SaveAsync(ct);

			return gamePlatform.File;
		}

		public async Task<(IEnumerable<GameForListReturnDto> games, MetaData metaData)> GetActiveGamesByDeveloperId(Guid developerId, ActiveGameParameters activeGameParameters, CancellationToken ct = default)
		{
			var gamesWithMetaData = await repositoryManager.GameRepository.GetActiveGamesByDeveloperId(developerId, activeGameParameters, false, ct);
			var games = (mapper.Map<IEnumerable<GameForListReturnDto>>(gamesWithMetaData)).ToList();
			for (int i = 0; i < games.Count; i++)
			{
				var discount = await repositoryManager.DiscountRepository.GetActiveDiscountByGameId(gamesWithMetaData[i].Id, false, ct);
				games[i].PriceAfterDiscount = discount is not null ? games[i].Price - (games[i].Price * discount.Percentage / 100) : games[i].Price;
			}
			return (games, gamesWithMetaData.MetaData);
		}

		public async Task<PlatformFileDto> GetGamePlatformFile(Guid gameId, CancellationToken ct = default)
		{
			var platformFile = mapper.Map<PlatformFileDto>(await repositoryManager.GameRepository.GetGameById(gameId, false, ct));
			return platformFile ?? throw new NotFoundException($"Game not found.");
		}
	}
}
