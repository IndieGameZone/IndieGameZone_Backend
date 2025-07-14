using IndieGameZone.Application.IServices;
using IndieGameZone.Domain.Constants;
using IndieGameZone.Domain.Entities;
using IndieGameZone.Domain.IRepositories;
using Microsoft.EntityFrameworkCore;

namespace IndieGameZone.Application.Services
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
			var achievement = await repositoryManager.AchievementRepository.GetAchievementByLevelAndType(likeCount, AchievementType.Like, false, ct);
			if (achievement == null || userAchievements.Any(u => u.AchievementId == achievement.Id))
			{
				return;
			}
			repositoryManager.UserAchievementRepository.AddUserAchievement(new UserAchievements
			{
				UserId = userId,
				AchievementId = achievement.Id
			});
			repositoryManager.NotificationRepository.CreateNotification(new Notifications
			{
				Id = Guid.NewGuid(),
				UserId = userId,
				Message = $"Congratulations! You have earned the {achievement.Name} achievement and receive a {achievement.DiscountAward}% discount.",
				IsRead = false,
				CreatedAt = DateTime.Now
			});
			repositoryManager.CouponRepository.CreateCoupon(new Coupons
			{
				Id = Guid.NewGuid(),
				Code = Guid.NewGuid().ToString(),
				Percentage = achievement.DiscountAward,
				IsUsed = false,
				EndDate = DateOnly.FromDateTime(DateTime.Now.AddDays(7)),
				UserId = userId
			});
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
