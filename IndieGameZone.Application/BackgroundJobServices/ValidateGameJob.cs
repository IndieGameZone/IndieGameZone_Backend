using IndieGameZone.Application.IServices;
using IndieGameZone.Domain.Constants;
using IndieGameZone.Domain.Entities;
using IndieGameZone.Domain.IRepositories;
using Quartz;

namespace IndieGameZone.Application.BackgroundJobServices
{
	public class ValidateGameJob : IJob
	{
		private readonly IRepositoryManager repositoryManager;
		private readonly IAIService aIService;
		private readonly IRecombeeService recombeeService;

		public ValidateGameJob(IRepositoryManager repositoryManager, IAIService aIService, IRecombeeService recombeeService)
		{
			this.repositoryManager = repositoryManager;
			this.aIService = aIService;
			this.recombeeService = recombeeService;
		}

		public async Task Execute(IJobExecutionContext context)
		{
			var dataMap = context.MergedJobDataMap;
			Guid gameId = Guid.Parse(dataMap.GetString("gameId"));

			var game = await repositoryManager.GameRepository.GetGameById(gameId, true);
			var gameImages = await repositoryManager.GameImageRepository.GetGameImagesByGameId(gameId, false);

			if (!await aIService.AnalyzeText(game.Name) || !await aIService.AnalyzeText(game.Description) || !await aIService.AnalyzeText(game.ShortDescription) || !await aIService.AnalyzeImage(game.CoverImage))
			{
				game.CensorStatus = CensorStatus.PendingManualReview;
				var gameCensorLogs1 = new GameCensorLogs
				{
					Id = Guid.NewGuid(),
					GameId = gameId,
					CensorStatus = CensorStatus.PendingManualReview,
					CreatedAt = DateTime.Now
				};
				repositoryManager.GameCensorLogRepository.CreateCensorLog(gameCensorLogs1);
				await repositoryManager.SaveAsync();
				return;
			}
			else
			{
				foreach (var image in gameImages)
				{
					if (!(await aIService.AnalyzeImage(image.Image)))
					{
						game.CensorStatus = CensorStatus.PendingManualReview;
						var gameCensorLogs1 = new GameCensorLogs
						{
							Id = Guid.NewGuid(),
							GameId = gameId,
							CensorStatus = CensorStatus.PendingManualReview,
							CreatedAt = DateTime.Now
						};
						repositoryManager.GameCensorLogRepository.CreateCensorLog(gameCensorLogs1);
						await repositoryManager.SaveAsync();
						return;
					}
				}
			}
			game.CensoredAt = DateTime.Now;
			game.CensorStatus = CensorStatus.Approved;
			var gameCensorLogs = new GameCensorLogs
			{
				Id = Guid.NewGuid(),
				GameId = gameId,
				CensorStatus = CensorStatus.Approved,
				CensoredAt = DateTime.Now,
				CreatedAt = DateTime.Now
			};
			repositoryManager.GameCensorLogRepository.CreateCensorLog(gameCensorLogs);
			if (game.CensorStatus == CensorStatus.Approved)
			{
				repositoryManager.NotificationRepository.CreateNotification(new Domain.Entities.Notifications
				{
					Id = Guid.NewGuid(),
					UserId = game.DeveloperId,
					Message = $"Your game '{game.Name}' has been approved.",
					CreatedAt = DateTime.Now,
					IsRead = false
				});
			}
			await repositoryManager.SaveAsync();

			if (game.Visibility == GameVisibility.Public)
			{
				await recombeeService.PushGameToRecombee(game.Id);
			}
			else
			{
				await recombeeService.RemoveGameFromRecombee(game.Id);
			}
		}
	}
}
