using IndieGameZone.Application.IServices;
using IndieGameZone.Domain.IRepositories;
using Quartz;

namespace IndieGameZone.Application.BackgroundJobServices
{
	public class ValidateCommentJob : IJob
	{
		private readonly IRepositoryManager repositoryManager;
		private readonly IAIService aIService;

		public ValidateCommentJob(IRepositoryManager repositoryManager, IAIService aIService)
		{
			this.repositoryManager = repositoryManager;
			this.aIService = aIService;
		}
		public async Task Execute(IJobExecutionContext context)
		{
			var dataMap = context.MergedJobDataMap;
			Guid commentId = Guid.Parse(dataMap.GetString("commentId"));

			var comment = await repositoryManager.PostCommentRepository.GetCommentById(commentId, true);
			if (await aIService.AnalyzeText(comment.Content))
			{
				comment.IsActive = true;
			}
			else
			{
				comment.IsActive = false;
			}
			await repositoryManager.SaveAsync();
		}
	}
}
