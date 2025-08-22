using IndieGameZone.Application.BackgroundJobServices;
using IndieGameZone.Application.IServices;
using IndieGameZone.Domain.Constants;
using IndieGameZone.Domain.Entities;
using IndieGameZone.Domain.Exceptions;
using IndieGameZone.Domain.IRepositories;
using IndieGameZone.Domain.RequestFeatures;
using IndieGameZone.Domain.RequestsAndResponses.Requests.Games;
using IndieGameZone.Domain.RequestsAndResponses.Responses.Games;
using MapsterMapper;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Quartz;

namespace IndieGameZone.Application.Services
{
	internal sealed class GameService : IGameService
	{
		private readonly IRepositoryManager repositoryManager;
		private readonly IMapper mapper;
		private readonly IBlobService blobService;
		private readonly ISchedulerFactory schedulerFactory;
		private readonly IRecombeeService recombeeService;
		private readonly UserManager<Users> userManager;

		public GameService(IRepositoryManager repositoryManager, IMapper mapper, IBlobService blobService, ISchedulerFactory schedulerFactory, IRecombeeService recombeeService, UserManager<Users> userManager)
		{
			this.repositoryManager = repositoryManager;
			this.mapper = mapper;
			this.blobService = blobService;
			this.schedulerFactory = schedulerFactory;
			this.recombeeService = recombeeService;
			this.userManager = userManager;
		}

		private async Task CheckGamePriceChangeWithin28Days(Games gameEntity, GameForUpdateDto game)
		{
			if (gameEntity.Price != game.Price && gameEntity.UpdatedAt != null && (DateTime.Now - (DateTime)gameEntity.UpdatedAt).Days < 28)
			{
				throw new BadRequestException("You can only update the game once every 28 days.");
			}
			else if (gameEntity.Price != game.Price && gameEntity.UpdatedAt == null && (DateTime.Now - gameEntity.CreatedAt).Days < 28)
			{
				throw new BadRequestException("You can only update the game once every 28 days.");
			}
		}

		public async Task<(IEnumerable<GameForListReturnDto> games, MetaData metaData)> GetGames(GameParameters gameParameters, CancellationToken ct = default)
		{
			var gamesWithMetaData = await repositoryManager.GameRepository.GetGames(gameParameters, false, ct);
			var games = mapper.Map<IEnumerable<GameForListReturnDto>>(gamesWithMetaData).ToList();
			for (int i = 0; i < games.Count; i++)
			{
				var discount = await repositoryManager.DiscountRepository.GetActiveDiscountByGameId(gamesWithMetaData[i].Id, false, ct);
				games[i].PriceAfterDiscount = discount is not null ? games[i].Price - games[i].Price * discount.Percentage / 100 : games[i].Price;
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
			gameDto.PriceAfterDiscount = discount is not null ? gameDto.Price - gameDto.Price * discount.Percentage / 100 : gameDto.Price;

			if (playerId != Guid.Empty)
			{
				await recombeeService.SendDetailViewEvent(playerId, gameId);
			}
			return gameDto;
		}

		public async Task DeleteGame(Guid developerId, Guid gameId, CancellationToken ct = default)
		{
			var gameEntity = await repositoryManager.GameRepository.GetGameById(gameId, true, ct);
			if (gameEntity is null)
			{
				throw new NotFoundException($"Game not found.");
			}
			if (gameEntity.DeveloperId != developerId)
			{
				throw new ForbiddenException("You do not have permission to delete this game.");
			}

			//// Handle Game Platforms
			//var existingGamePlatforms = await repositoryManager.GamePlatformRepository.GetGamePlatformsByGameId(gameId, false, ct);
			//if (existingGamePlatforms is not null && existingGamePlatforms.Any())
			//{
			//	foreach (var platform in existingGamePlatforms)
			//	{
			//		await blobService.DeleteBlob(platform.File.Split('/').Last(), StorageContainer.STORAGE_CONTAINER);
			//	}
			//	repositoryManager.GamePlatformRepository.DeleteGamePlatform(existingGamePlatforms);
			//}

			////Handle Game Image Entities
			//var existingGameImages = await repositoryManager.GameImageRepository.GetGameImagesByGameId(gameId, false, ct);
			//if (existingGameImages is not null && existingGameImages.Any())
			//{
			//	foreach (var image in existingGameImages)
			//	{
			//		if (image.Image != null)
			//		{
			//			await blobService.DeleteBlob(image.Image.Split('/').Last(), StorageContainer.STORAGE_CONTAINER);
			//		}
			//	}
			//	repositoryManager.GameImageRepository.DeleteGameImage(existingGameImages);
			//}

			////Handle Game Language Entities
			//var existingGameLanguages = await repositoryManager.GameLanguageRepository.GetGameLanguagesByGameId(gameId, false, ct);
			//if (existingGameLanguages is not null && existingGameLanguages.Any())
			//{
			//	repositoryManager.GameLanguageRepository.DeleteGameLanguage(existingGameLanguages);
			//}

			////Handle Game Tag Entities
			//var existingGameTags = await repositoryManager.GameTagRepository.GetGameTagsByGameId(gameId, false, ct);
			//if (existingGameTags is not null && existingGameTags.Any())
			//{
			//	repositoryManager.GameTagRepository.DeleteGameTag(existingGameTags);
			//}

			//await blobService.DeleteBlob(gameEntity.CoverImage.Split('/').Last(), StorageContainer.STORAGE_CONTAINER);

			gameEntity.IsDeleted = true;
			await repositoryManager.SaveAsync(ct);

			await recombeeService.DeactiveGameFromRecombee(gameId);
		}

		private async Task DeleteOldContentBeforeUpdate(Guid gameId, CancellationToken ct = default)
		{
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
			var developer = await userManager.Users.AsNoTracking().SingleOrDefaultAsync(d => d.Id == developerId);
			if (developer is null)
			{
				throw new NotFoundException($"Developer not found.");
			}
			var ageRestriction = await repositoryManager.AgeRestrictionRepository.GetAgeRestrictionById(game.AgeRestrictionId, false, ct);
			if (ageRestriction is null)
			{
				throw new NotFoundException($"Age restriction not found.");
			}
			var category = await repositoryManager.CategoryRepository.GetCategoryById(game.CategoryId, false, ct);
			if (category is null)
			{
				throw new NotFoundException($"Category not found.");
			}
			if (!game.LanguageIds.Any())
			{
				throw new BadRequestException("At least one language must be selected.");
			}
			if (!game.TagIds.Any())
			{
				throw new BadRequestException("At least one tag must be selected.");
			}
			foreach (var languageId in game.LanguageIds)
			{
				var language = await repositoryManager.LanguageRepository.GetLanguageById(languageId, false, ct);
				if (language is null)
				{
					throw new NotFoundException($"Language not found.");
				}
			}
			foreach (var tagId in game.TagIds)
			{
				var tag = await repositoryManager.TagRepository.GetTagById(tagId, false, ct);
				if (tag is null)
				{
					throw new NotFoundException($"Tag not found.");
				}
			}
			if (!game.GameImages.Any())
			{
				throw new BadRequestException("No images provided.");
			}
			var gameEntity = mapper.Map<Games>(game);
			gameEntity.Id = Guid.NewGuid();
			gameEntity.DeveloperId = developerId;
			gameEntity.CreatedAt = DateTime.Now;
			gameEntity.NumberOfDownloads = 0;
			gameEntity.CensorStatus = game.Price == 0 ? CensorStatus.PendingAIReview : CensorStatus.PendingManualReview;

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
				CensorStatus = game.Price == 0 ? CensorStatus.PendingAIReview : CensorStatus.PendingManualReview,
				CreatedAt = DateTime.Now
			};
			repositoryManager.GameCensorLogRepository.CreateCensorLog(gameCensorLogs);

			var gamePriceLogs = new GamePriceLogs
			{
				Id = Guid.NewGuid(),
				GameId = gameEntity.Id,
				Price = gameEntity.Price,
				CreatedAt = DateTime.Now
			};
			repositoryManager.GamePriceLogRepository.CreatePriceLog(gamePriceLogs);

			await repositoryManager.SaveAsync(ct);

			await recombeeService.PushGameToRecombee(gameEntity.Id);

			if (game.Price == 0)
			{
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
			}

			return gameEntity.Id;
		}

		public async Task UpdateGame(Guid developerId, Guid gameId, GameForUpdateDto game, CancellationToken ct = default)
		{
			var dbTransaction = await repositoryManager.BeginTransaction(ct);
			await DeleteOldContentBeforeUpdate(gameId, ct);
			var ageRestriction = await repositoryManager.AgeRestrictionRepository.GetAgeRestrictionById(game.AgeRestrictionId, false, ct);
			if (ageRestriction is null)
			{
				throw new NotFoundException($"Age restriction not found.");
			}
			var category = await repositoryManager.CategoryRepository.GetCategoryById(game.CategoryId, false, ct);
			if (category is null)
			{
				throw new NotFoundException($"Category not found.");
			}
			if (!game.LanguageIds.Any())
			{
				throw new BadRequestException("At least one language must be selected.");
			}
			if (!game.TagIds.Any())
			{
				throw new BadRequestException("At least one tag must be selected.");
			}
			foreach (var languageId in game.LanguageIds)
			{
				var language = await repositoryManager.LanguageRepository.GetLanguageById(languageId, false, ct);
				if (language is null)
				{
					throw new NotFoundException($"Language not found.");
				}
			}
			foreach (var tagId in game.TagIds)
			{
				var tag = await repositoryManager.TagRepository.GetTagById(tagId, false, ct);
				if (tag is null)
				{
					throw new NotFoundException($"Tag not found.");
				}
			}
			var gameEntity = await repositoryManager.GameRepository.GetGameById(gameId, true, ct);
			await CheckGamePriceChangeWithin28Days(gameEntity, game);
			if (gameEntity is null)
			{
				throw new NotFoundException($"Game not found.");
			}
			if (gameEntity.DeveloperId != developerId)
			{
				throw new ForbiddenException("You do not have permission to update this game.");
			}
			if (game.CoverImage != gameEntity.CoverImage)
			{
				await blobService.DeleteBlob(gameEntity.CoverImage.Split('/').Last(), StorageContainer.STORAGE_CONTAINER);
			}
			mapper.Map(game, gameEntity);
			gameEntity.UpdatedAt = DateTime.Now;
			gameEntity.CensorStatus = game.Price == 0 ? CensorStatus.PendingAIReview : CensorStatus.PendingManualReview;

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
				CensorStatus = game.Price == 0 ? CensorStatus.PendingAIReview : CensorStatus.PendingManualReview,
				CreatedAt = DateTime.Now
			};
			repositoryManager.GameCensorLogRepository.CreateCensorLog(gameCensorLogs);

			if (gameEntity.Price != game.Price)
			{
				var gamePriceLogs = new GamePriceLogs
				{
					Id = Guid.NewGuid(),
					GameId = gameEntity.Id,
					Price = gameEntity.Price,
					CreatedAt = DateTime.Now
				};
				repositoryManager.GamePriceLogRepository.CreatePriceLog(gamePriceLogs);
			}

			await repositoryManager.SaveAsync(ct);

			//await UpdateCommercialRegistrationStatusBasedOnGameAsync(gameEntity.Id, ct);

			dbTransaction.Commit();

			if (game.Price == 0)
			{
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
			}
		}

		public async Task<(IEnumerable<GameForListReturnDto> games, MetaData metaData)> GetActiveGames(ActiveGameParameters activeGameParameters, CancellationToken ct = default)
		{
			var gamesWithMetaData = await repositoryManager.GameRepository.GetActiveGames(activeGameParameters, false, ct);
			var games = mapper.Map<IEnumerable<GameForListReturnDto>>(gamesWithMetaData).ToList();
			for (int i = 0; i < games.Count; i++)
			{
				var discount = await repositoryManager.DiscountRepository.GetActiveDiscountByGameId(gamesWithMetaData[i].Id, false, ct);
				games[i].PriceAfterDiscount = discount is not null ? games[i].Price - games[i].Price * discount.Percentage / 100 : games[i].Price;
				games[i].HasCommercial = await repositoryManager.CommercialRegistrationRepository.GetCategoryCommercialRegistrationByGameId(gamesWithMetaData[i].Id, false, ct) is not null;
			}
			return (games, gamesWithMetaData.MetaData);
		}

		public async Task UpdateActiveStatus(Guid moderatorId, Guid gameId, GameActivationDto gameActivationDto, CancellationToken ct = default)
		{
			var moderator = await userManager.Users.AsNoTracking().SingleOrDefaultAsync(d => d.Id == moderatorId);
			if (moderator is null)
			{
				throw new NotFoundException($"Moderator not found.");
			}
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

			if (gameActivationDto.CensorStatus == CensorStatus.Approved)
			{
				repositoryManager.NotificationRepository.CreateNotification(new Notifications
				{
					Id = Guid.NewGuid(),
					UserId = gameEntity.DeveloperId,
					Message = $"Your game '{gameEntity.Name}' has been approved.",
					CreatedAt = DateTime.Now,
					IsRead = false
				});
			}
			else if (gameActivationDto.CensorStatus == CensorStatus.Rejected)
			{
				repositoryManager.NotificationRepository.CreateNotification(new Notifications
				{
					Id = Guid.NewGuid(),
					UserId = gameEntity.DeveloperId,
					Message = $"Your game '{gameEntity.Name}' has been rejected. Reason: {gameActivationDto.CensorReason}",
					CreatedAt = DateTime.Now,
					IsRead = false
				});
			}

			await repositoryManager.SaveAsync(ct);

			if (gameEntity.Visibility == GameVisibility.Public && gameEntity.CensorStatus == CensorStatus.Approved)
			{
				await recombeeService.ActiveGameFromRecombee(gameId);
			}
			else
			{
				await recombeeService.DeactiveGameFromRecombee(gameId);
			}

			//await UpdateCommercialRegistrationStatusBasedOnGameAsync(gameId, ct);
		}

		public async Task<string> IncreaseNumberOfDownload(Guid userId, Guid gamePlatformId, CancellationToken ct = default)
		{
			var gamePlatform = await repositoryManager.GamePlatformRepository.GetGamePlatformsById(gamePlatformId, false, ct);
			var game = await repositoryManager.GameRepository.GetGameById(gamePlatform.GameId, true, ct);
			var roles = await userManager.GetRolesAsync(await userManager.FindByIdAsync(userId.ToString()));
			if (roles.Contains(RoleEnum.Player.ToString()) || userId != game.DeveloperId)
			{
				var downlaodSlot = new DownloadSlots
				{
					Id = Guid.NewGuid(),
					UserId = userId,
					GameId = game.Id,
					DownloadAt = DateTime.Now,
				};
				repositoryManager.DownloadSlotRepository.CreateDownloadSlot(downlaodSlot);
				game.NumberOfDownloads++;
			}
			var library = await repositoryManager.LibraryRepository.GetLibraryByUserIdAndGameId(userId, game.Id, false, ct);
			if (library is null)
			{
				repositoryManager.LibraryRepository.AddGameToLibrary(new Libraries
				{
					UserId = userId,
					GameId = game.Id,
					PurchasedAt = DateTime.Now
				});
			}
			await repositoryManager.SaveAsync(ct);

			return gamePlatform.File;
		}

		public async Task<(IEnumerable<GameForListReturnDto> games, MetaData metaData)> GetActiveGamesByDeveloperId(Guid developerId, ActiveGameParameters activeGameParameters, CancellationToken ct = default)
		{
			var gamesWithMetaData = await repositoryManager.GameRepository.GetActiveGamesByDeveloperId(developerId, activeGameParameters, false, ct);
			var games = mapper.Map<IEnumerable<GameForListReturnDto>>(gamesWithMetaData).ToList();
			for (int i = 0; i < games.Count; i++)
			{
				var discount = await repositoryManager.DiscountRepository.GetActiveDiscountByGameId(gamesWithMetaData[i].Id, false, ct);
				games[i].PriceAfterDiscount = discount is not null ? games[i].Price - games[i].Price * discount.Percentage / 100 : games[i].Price;
			}
			return (games, gamesWithMetaData.MetaData);
		}

		public async Task<PlatformFileDto> GetGamePlatformFile(Guid gameId, CancellationToken ct = default)
		{
			var platformFile = mapper.Map<PlatformFileDto>(await repositoryManager.GameRepository.GetGameById(gameId, false, ct));
			return platformFile ?? throw new NotFoundException($"Game file not found.");
		}

		public async Task<PlatformFileDto> GetActiveGamePlatformFile(Guid gameId, CancellationToken ct = default)
		{
			var platformFile = mapper.Map<PlatformFileDto>(await repositoryManager.GameRepository.GetGameByIdWithActiveFile(gameId, false, ct));
			return platformFile ?? throw new NotFoundException($"Game file not found.");
		}

		public async Task<IEnumerable<GameForListReturnDto>> GetRecommendedGamesForUser(Guid userId, CancellationToken ct = default)
		{
			var user = await userManager.Users.AsNoTracking().SingleOrDefaultAsync(d => d.Id == userId);
			if (user is null)
			{
				throw new NotFoundException($"User not found.");
			}
			await recombeeService.GetRecommendedGamesForUser(userId);
			var gameRecommendations = await repositoryManager.GameRecommendationRepository.GetRecommendationsByUserId(userId, false, ct);
			if (gameRecommendations is null || !gameRecommendations.Any())
			{
				return Enumerable.Empty<GameForListReturnDto>();
			}
			var games = new List<GameForListReturnDto>();
			foreach (var recommendation in gameRecommendations)
			{
				var game = await repositoryManager.GameRepository.GetGameById(recommendation.GameId, false, ct);
				if (game != null)
				{
					var gameDto = mapper.Map<GameForListReturnDto>(game);
					var discount = await repositoryManager.DiscountRepository.GetActiveDiscountByGameId(game.Id, false, ct);
					gameDto.PriceAfterDiscount = discount is not null ? gameDto.Price - gameDto.Price * discount.Percentage / 100 : gameDto.Price;
					games.Add(gameDto);
				}
			}
			return games;

		}

		public async Task<(int total, int approve, int reject, int manual, int ai)> GetNumberOfGameBasedOnCensorStatus(CancellationToken ct = default)
		{
			var total = await repositoryManager.GameRepository.GetGames(false).CountAsync();
			var approve = await repositoryManager.GameRepository.GetGamesBasedOnCensorStatus(CensorStatus.Approved, false).CountAsync();
			var reject = await repositoryManager.GameRepository.GetGamesBasedOnCensorStatus(CensorStatus.Rejected, false).CountAsync();
			var manual = await repositoryManager.GameRepository.GetGamesBasedOnCensorStatus(CensorStatus.PendingManualReview, false).CountAsync();
			var ai = await repositoryManager.GameRepository.GetGamesBasedOnCensorStatus(CensorStatus.PendingAIReview, false).CountAsync();
			return (total, approve, reject, manual, ai);
		}

		public async Task<bool> CheckGameOwnership(Guid userId, Guid gameId, CancellationToken ct = default)
		{
			var gameLibrary = await repositoryManager.LibraryRepository.GetLibraryByUserIdAndGameId(userId, gameId, false, ct);
			return gameLibrary != null;
		}

		public async Task<(IEnumerable<GameForBannerReturnDto> games, MetaData metaData)> GetTodayHomepageBannerGamesAsync(CancellationToken ct = default)
		{
			var gamesWithMetaData = (await repositoryManager.GameRepository
				.GetTodayHomepageBannerGamesAsync(false, ct)).ToList();

			var games = mapper.Map<List<GameForBannerReturnDto>>(gamesWithMetaData);

			for (int i = 0; i < games.Count; i++)
			{
				var discount = await repositoryManager.DiscountRepository
					.GetActiveDiscountByGameId(gamesWithMetaData[i].Id, false, ct);

				games[i].PriceAfterDiscount = discount is not null
					? games[i].Price - (games[i].Price * discount.Percentage / 100)
					: games[i].Price;
			}

			var metaData = new MetaData
			{
				CurrentPage = 1,
				PageSize = games.Count,
				TotalCount = games.Count,
				TotalPages = 1
			};

			return (games, metaData);
		}

		public async Task<(IEnumerable<GameForListReturnDto> games, MetaData metaData)> GetTodayCategoryBannerGamesAsync(CancellationToken ct = default)
		{
			var gamesWithMetaData = (await repositoryManager.GameRepository.GetTodayCategoryBannerGamesAsync(false, ct)).ToList();

			var games = mapper.Map<List<GameForListReturnDto>>(gamesWithMetaData);

			for (int i = 0; i < games.Count; i++)
			{
				var discount = await repositoryManager.DiscountRepository.GetActiveDiscountByGameId(gamesWithMetaData[i].Id, false, ct);
				games[i].PriceAfterDiscount = discount is not null
					? games[i].Price - (games[i].Price * discount.Percentage / 100)
					: games[i].Price;
			}

			var metaData = new MetaData
			{
				CurrentPage = 1,
				PageSize = games.Count,
				TotalCount = games.Count,
				TotalPages = 1
			};

			return (games, metaData);
		}

		private async Task UpdateCommercialRegistrationStatusBasedOnGameAsync(Guid gameId, CancellationToken ct = default)
		{
			var today = DateOnly.FromDateTime(TimeZoneInfo.ConvertTimeFromUtc(
				DateTime.UtcNow,
				TimeZoneInfo.FindSystemTimeZoneById("SE Asia Standard Time")));

			int updated = 0;

			// Get Active registrations
			var activeRegistrations = await repositoryManager.CommercialRegistrationRepository
				.GetActiveRegistrationsByGameIdAsync(gameId, trackChanges: true, ct);

			foreach (var reg in activeRegistrations)
			{
				// Still within commercial period
				if (reg.StartDate <= today && (!reg.EndDate.HasValue || today <= reg.EndDate.Value))
				{
					bool isStillEligible = reg.Game.Visibility == GameVisibility.Public &&
										   reg.Game.CensorStatus == CensorStatus.Approved;

					if (!isStillEligible)
					{
						reg.Status = CommercialRegistrationStatus.Failed;
						updated++;
					}
				}
			}

			// Get Failed registrations
			var failedRegistrations = await repositoryManager.CommercialRegistrationRepository
				.GetFailedRegistrationsByGameIdAsync(gameId, trackChanges: true, ct);

			foreach (var reg in failedRegistrations)
			{
				if (reg.StartDate <= today && (!reg.EndDate.HasValue || today <= reg.EndDate.Value))
				{
					bool isNowEligible = reg.Game.Visibility == GameVisibility.Public &&
										 reg.Game.CensorStatus == CensorStatus.Approved;

					if (isNowEligible)
					{
						reg.Status = CommercialRegistrationStatus.Active;
						updated++;
					}
				}
			}

			if (updated > 0)
			{
				await repositoryManager.SaveAsync(ct);
			}
		}

	}
}
