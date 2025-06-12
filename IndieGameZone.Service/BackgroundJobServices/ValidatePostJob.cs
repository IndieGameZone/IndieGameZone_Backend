using IndieGameZone.Application.AIService;
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

			var blog = await repositoryManager.PostRepository.GetPostById(postId, true);

			if (await aIService.AnalyzeText(blog.Title) && await aIService.AnalyzeText(blog.Content) && await aIService.AnalyzeImage(blog.Image))
			{
				blog.Status = PostStatus.Approved;
			}
			else
			{
				blog.Status = PostStatus.Rejected;
			}
			blog.CensoredAt = DateTime.Now;
			await repositoryManager.SaveAsync();
		}
	}
}
