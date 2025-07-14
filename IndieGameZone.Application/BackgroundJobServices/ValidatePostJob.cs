using IndieGameZone.Application.IServices;
using IndieGameZone.Domain.Constants;
using IndieGameZone.Domain.IRepositories;
using Quartz;

namespace IndieGameZone.Application.BackgroundJobServices
{
	public class ValidatePostJob : IJob
	{
		private readonly IRepositoryManager repositoryManager;
		private readonly IAIService aIService;

		public ValidatePostJob(IRepositoryManager repositoryManager, IAIService aIService)
		{
			this.repositoryManager = repositoryManager;
			this.aIService = aIService;
		}

		public async Task Execute(IJobExecutionContext context)
		{
			var dataMap = context.MergedJobDataMap;
			Guid postId = Guid.Parse(dataMap.GetString("postId"));

			var post = await repositoryManager.PostRepository.GetPostById(postId, true);

			if (await aIService.AnalyzeText(post.Title) && await aIService.AnalyzeText(post.Content))
			{
				post.Status = PostStatus.Approved;
			}
			else
			{
				post.Status = PostStatus.PendingManualReview;
			}
			post.CensoredAt = DateTime.Now;
			await repositoryManager.SaveAsync();
		}
	}
}
