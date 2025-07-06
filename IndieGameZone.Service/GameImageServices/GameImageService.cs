
using IndieGameZone.Application.BackgroundJobServices;
using IndieGameZone.Application.BlobService;
using IndieGameZone.Domain.Constants;
using IndieGameZone.Domain.Entities;
using IndieGameZone.Domain.Exceptions;
using IndieGameZone.Domain.IRepositories;
using Quartz;

namespace IndieGameZone.Application.GameImageServices
{
	internal sealed class GameImageService : IGameImageService
	{
		private readonly IRepositoryManager repositoryManager;
		private readonly IBlobService blobService;
		private readonly ISchedulerFactory schedulerFactory;

		public GameImageService(IRepositoryManager repositoryManager, IBlobService blobService, ISchedulerFactory schedulerFactory)
		{
			this.repositoryManager = repositoryManager;
			this.blobService = blobService;
			this.schedulerFactory = schedulerFactory;
		}

		private async Task DeleteOldGameImages(Guid gameId, IEnumerable<string> newGameImages, CancellationToken ct)
		{
			var existingGameImages = await repositoryManager.GameImageRepository.GetGameImagesByGameId(gameId, false, ct);
			var existingImageUrls = existingGameImages.Select(x => x.Image).ToList();
			if (existingImageUrls is null || !existingImageUrls.Any())
			{
				return;
			}
			var imagesToDelete = existingImageUrls.Except(newGameImages);
			foreach (var image in imagesToDelete)
			{
				await blobService.DeleteBlob(image.Split('/').Last(), StorageContainer.STORAGE_CONTAINER);
			}
			repositoryManager.GameImageRepository.DeleteGameImage(existingGameImages);
			await repositoryManager.SaveAsync(ct);
		}

		public async Task UpdateGameImages(Guid gameId, ICollection<string> images, CancellationToken ct = default)
		{
			if (images is null || !images.Any())
			{
				throw new BadRequestException("No images provided.");
			}
			var dbTransaction = await repositoryManager.BeginTransaction(ct);
			await DeleteOldGameImages(gameId, images, ct);
			var game = await repositoryManager.GameRepository.GetGameById(gameId, true, ct);
			game.UpdatedAt = DateTime.Now;
			game.CensorStatus = CensorStatus.PendingAIReview;
			var gameImageEntities = new List<GameImages>();
			foreach (var image in images)
			{
				gameImageEntities.Add(new GameImages
				{
					Id = Guid.NewGuid(),
					GameId = gameId,
					Image = image,
				});
			}
			repositoryManager.GameImageRepository.CreateGameImage(gameImageEntities);

			var gameCensorLogs = new GameCensorLogs
			{
				Id = Guid.NewGuid(),
				GameId = gameId,
				CensorStatus = CensorStatus.PendingAIReview,
				CreatedAt = DateTime.Now
			};
			repositoryManager.GameCensorLogRepository.CreateCensorLog(gameCensorLogs);

			await repositoryManager.SaveAsync(ct);
			dbTransaction.Commit();

			IJobDetail job = JobBuilder.Create<ValidateGameJob>()
				.WithIdentity("GameImageJob", "GameImageGroup")
				.UsingJobData("gameId", gameId.ToString())
				.Build();

			ITrigger trigger = TriggerBuilder.Create()
				.WithIdentity("GameImageTrigger", "GameImageGroup")
				.StartNow()
				.Build();

			var scheduler = await schedulerFactory.GetScheduler(ct);

			await scheduler.ScheduleJob(job, trigger, ct);
		}
	}
}
