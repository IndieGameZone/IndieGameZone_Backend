
using IndieGameZone.Domain.Entities;
using IndieGameZone.Domain.IRepositories;
using Microsoft.EntityFrameworkCore;

namespace IndieGameZone.Application.PostReactionServices
{
	internal sealed class PostReactionService : IPostReactionService
	{
		private readonly IRepositoryManager repositoryManager;

		public PostReactionService(IRepositoryManager repositoryManager)
		{
			this.repositoryManager = repositoryManager;
		}

		private async Task CheckLikeAchievement(Guid userId, CancellationToken ct = default)
		{
			var userAchievements = repositoryManager.UserAchievementRepository.GetUserAchievementsByUserId(userId, false);
			var likeCount = await repositoryManager.PostReactionRepository.GetReactionsByUserId(userId, false).CountAsync(ct);
			if (likeCount == 1 && !userAchievements.Any(u => u.AchievementId == Guid.Parse("8e8cbf44-001f-4060-bd8a-bc6213a81cc0")))
			{
				repositoryManager.UserAchievementRepository.AddUserAchievement(new UserAchievements
				{
					UserId = userId,
					AchievementId = Guid.Parse("8e8cbf44-001f-4060-bd8a-bc6213a81cc0")
				});
			}
			else if (likeCount == 10 && !userAchievements.Any(u => u.AchievementId == Guid.Parse("10b1990c-cce0-45ed-bcfd-d86ed7a3ae1c")))
			{
				repositoryManager.UserAchievementRepository.AddUserAchievement(new UserAchievements
				{
					UserId = userId,
					AchievementId = Guid.Parse("10b1990c-cce0-45ed-bcfd-d86ed7a3ae1c")
				});
			}
			else if (likeCount == 50 && !userAchievements.Any(u => u.AchievementId == Guid.Parse("d49ff353-2b75-4879-8a0b-4d7c16ed4a69")))
			{
				repositoryManager.UserAchievementRepository.AddUserAchievement(new UserAchievements
				{
					UserId = userId,
					AchievementId = Guid.Parse("d49ff353-2b75-4879-8a0b-4d7c16ed4a69")
				});
			}
			await repositoryManager.SaveAsync(ct);
		}
		public async Task CreateOrDeleteReactions(Guid userId, Guid postId, CancellationToken ct = default)
		{
			var reaction = await repositoryManager.PostReactionRepository.GetReaction(userId, postId, false, ct);
			if (reaction == null)
			{
				repositoryManager.PostReactionRepository.CreateReactions(new PostReactions { PostId = postId, UserId = userId });
			}
			else
			{
				repositoryManager.PostReactionRepository.DeleteReactions(reaction);
			}
			await repositoryManager.SaveAsync(ct);

			await CheckLikeAchievement(userId, ct);
		}

		public Task<int> GetNumberOfLikesByPostId(Guid postId, CancellationToken ct = default)
		{
			return repositoryManager.PostReactionRepository.GetReactionsByPostId(postId, false, ct).CountAsync();
		}

		public async Task<bool> IsPostLikedByUser(Guid userId, Guid postId, CancellationToken ct = default)
		{
			var reaction = await repositoryManager.PostReactionRepository.GetReaction(userId, postId, false, ct);
			return reaction != null;
		}
	}
}
