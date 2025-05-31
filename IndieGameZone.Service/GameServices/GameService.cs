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
			var games = (mapper.Map<IEnumerable<GameForListReturnDto>>(gamesWithMetaData)).ToList();
			for (int i = 0; i < games.Count; i++)
			{
				var discount = await repositoryManager.DiscountRepository.GetActiveDiscountByGameId(gamesWithMetaData[i].Id, false, ct);
				games[i].PriceAfterDiscount = discount is not null ? games[i].Price - (games[i].Price * discount.Percentage / 100) : games[i].Price;
			}
			return (games, gamesWithMetaData.MetaData);
		}

		public async Task<GameForSingleReturnDto> GetGameById(Guid gameId, CancellationToken ct = default)
		{
			var gameEntity = await repositoryManager.GameRepository.GetGameById(gameId, false, ct);
			if (gameEntity is null)
			{
				throw new NotFoundException($"Game not found.");
			}
			var gameDto = mapper.Map<GameForSingleReturnDto>(gameEntity);
			var discount = await repositoryManager.DiscountRepository.GetActiveDiscountByGameId(gameId, false, ct);
			gameDto.PriceAfterDiscount = discount is not null ? gameDto.Price - (gameDto.Price * discount.Percentage / 100) : gameDto.Price;
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

			//Handle Game Info Entities
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
			gameEntity.Status = GameStatus.Approved;
			if (game.CoverImage is not null && game.CoverImage.Length > 0)
			{
				string coverImageFilename = $"{game.Name}CoverImage{Path.GetExtension(game.CoverImage.FileName)}";
				gameEntity.CoverImage = await blobService.UploadBlob(coverImageFilename, StorageContainer.STORAGE_CONTAINER, game.CoverImage);
			}
			//Handle Game Images
			if (game.GameImages is not null && game.GameImages.Count > 0)
			{
				var gameImageEntitys = game.GameImages.Select(async image => new GameImages
				{
					Id = Guid.NewGuid(),
					GameId = gameEntity.Id,
					Image = await blobService.UploadBlob($"{Guid.NewGuid()}{Path.GetExtension(image.FileName)}", StorageContainer.STORAGE_CONTAINER, image)
				});
				repositoryManager.GameImageRepository.CreateGameImage(await Task.WhenAll(gameImageEntitys));
			}

			//Handle Game Language
			var gameLanguageEntitys = game.LanguageIds.Select(id => new GameLanguages { LanguageId = id, GameId = gameEntity.Id });
			repositoryManager.GameLanguageRepository.CreateGameLanguage(gameLanguageEntitys);

			//Handle Game Tags
			var gameTagEntitys = game.TagIds.Select(id => new GameTags { TagId = id, GameId = gameEntity.Id });
			repositoryManager.GameTagRepository.CreateGameTag(gameTagEntitys);


			//Handle Games
			repositoryManager.GameRepository.CreateGame(gameEntity);

			await repositoryManager.SaveAsync(ct);

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
			if (game.CoverImage is not null && game.CoverImage.Length > 0)
			{
				await blobService.DeleteBlob(gameEntity.CoverImage.Split('/').Last(), StorageContainer.STORAGE_CONTAINER);
				string coverImageFilename = $"{game.Name}CoverImage{Path.GetExtension(game.CoverImage.FileName)}";
				gameEntity.CoverImage = await blobService.UploadBlob(coverImageFilename, StorageContainer.STORAGE_CONTAINER, game.CoverImage);
			}

			//Handle Game Images
			if (game.GameImages is not null && game.GameImages.Count > 0)
			{
				var gameImageEntities = new List<GameImages>();

				foreach (var image in game.GameImages)
				{
					var uploadedUrl = await blobService.UploadBlob(
						$"{Guid.NewGuid()}{Path.GetExtension(image.FileName)}",
						StorageContainer.STORAGE_CONTAINER,
						image);

					gameImageEntities.Add(new GameImages
					{
						Id = Guid.NewGuid(),
						GameId = gameEntity.Id,
						Image = uploadedUrl
					});
				}
				repositoryManager.GameImageRepository.CreateGameImage(gameImageEntities);
				await repositoryManager.SaveAsync(ct);
			}

			//Handle Game Language
			var gameLanguageEntitys = game.LanguageIds.Select(id => new GameLanguages { LanguageId = id, GameId = gameEntity.Id });
			repositoryManager.GameLanguageRepository.CreateGameLanguage(gameLanguageEntitys);

			//Handle Game Tags
			var gameTagEntitys = game.TagIds.Select(id => new GameTags { TagId = id, GameId = gameEntity.Id });
			repositoryManager.GameTagRepository.CreateGameTag(gameTagEntitys);

			await repositoryManager.SaveAsync(ct);
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

		public async Task UpdateActiveStatus(Guid gameId, CancellationToken ct = default)
		{
			var gameEntity = await repositoryManager.GameRepository.GetGameById(gameId, true, ct);
			if (gameEntity is null)
			{
				throw new NotFoundException($"Game not found.");
			}
			if (gameEntity.Status == GameStatus.Approved)
			{
				gameEntity.Status = GameStatus.Rejected;
			}
			else
			{
				gameEntity.Status = GameStatus.Approved;
			}
			await repositoryManager.SaveAsync(ct);
		}
	}
}
