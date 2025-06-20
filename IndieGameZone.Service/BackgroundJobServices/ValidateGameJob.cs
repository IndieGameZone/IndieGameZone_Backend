using IndieGameZone.Application.AIService;
using IndieGameZone.Domain.Constants;
using IndieGameZone.Domain.IRepositories;
using Quartz;

namespace IndieGameZone.Application.BackgroundJobServices
{
	public class ValidateGameJob : IJob
	{
		private readonly IRepositoryManager repositoryManager;
		private readonly IAIService aIService;

		public ValidateGameJob(IRepositoryManager repositoryManager, IAIService aIService)
		{
			this.repositoryManager = repositoryManager;
			this.aIService = aIService;
		}

		public async Task Execute(IJobExecutionContext context)
		{
			var dataMap = context.MergedJobDataMap;
			Guid gameId = Guid.Parse(dataMap.GetString("gameId"));

			var game = await repositoryManager.GameRepository.GetGameById(gameId, true);

			if (await aIService.AnalyzeText(game.Name) && await aIService.AnalyzeText(game.Description) && await aIService.AnalyzeText(game.ShortDescription))
			{
				game.CensorStatus = CensorStatus.Approved;
			}
			else
			{
				game.CensorStatus = CensorStatus.PendingManualReview;
			}
			game.CensoredAt = DateTime.Now;
			await repositoryManager.SaveAsync();
		}
	}
}
