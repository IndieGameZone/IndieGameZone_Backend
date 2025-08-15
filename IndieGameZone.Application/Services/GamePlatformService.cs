using IndieGameZone.Application.IServices;
using IndieGameZone.Domain.Constants;
using IndieGameZone.Domain.Entities;
using IndieGameZone.Domain.Exceptions;
using IndieGameZone.Domain.IRepositories;
using IndieGameZone.Domain.RequestsAndResponses.Requests.GamePlatforms;
using MapsterMapper;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace IndieGameZone.Application.Services
{
	internal sealed class GamePlatformService : IGamePlatformService
	{
		private readonly IRepositoryManager repositoryManager;
		private readonly IMapper mapper;
		private readonly IBlobService blobService;
		private readonly UserManager<Users> userManager;

		public GamePlatformService(IRepositoryManager repositoryManager, IMapper mapper, IBlobService blobService, UserManager<Users> userManager)
		{
			this.repositoryManager = repositoryManager;
			this.mapper = mapper;
			this.blobService = blobService;
			this.userManager = userManager;
		}

		private async Task<bool> CheckGameOwnership(Guid userId, Guid gameId, CancellationToken ct = default)
		{
			var gameLibrary = await repositoryManager.LibraryRepository.GetLibraryByUserIdAndGameId(userId, gameId, false, ct);
			var game = await repositoryManager.GameRepository.GetGameById(gameId, false, ct);
			return gameLibrary != null || userId == game.DeveloperId;
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
			var game = await repositoryManager.GameRepository.GetGameById(gameId, false, ct);
			if (game is null)
			{
				throw new NotFoundException($"Game not found.");
			}
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
			var game = await repositoryManager.GameRepository.GetGameById(gameId, false, ct);
			if (game is null)
			{
				throw new NotFoundException($"Game not found.");
			}
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

			}
			gamePlatform.Version = gamePlatformForUpdateDto.Version;
			gamePlatform.DisplayName = gamePlatformForUpdateDto.DisplayName;

			await repositoryManager.SaveAsync(ct);
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

		public async Task<string> GetFilePassword(Guid userId, Guid gamePlatformId, CancellationToken ct = default)
		{
			var user = await userManager.Users.AsNoTracking().SingleOrDefaultAsync(u => u.Id == userId, ct);
			if (user is null)
			{
				throw new NotFoundException($"User not found.");
			}
			var gamePlatform = await repositoryManager.GamePlatformRepository.GetGamePlatformsById(gamePlatformId, false, ct);
			if (gamePlatform is null)
			{
				throw new NotFoundException($"Game platform not found.");
			}
			if (!await CheckGameOwnership(userId, gamePlatform.GameId, ct))
			{
				throw new BadRequestException("You must own this game to see file password.");
			}
			return gamePlatform.FilePassword;
		}
	}
}
