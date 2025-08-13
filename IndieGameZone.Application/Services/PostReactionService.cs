using IndieGameZone.Application.Hub;
using IndieGameZone.Application.IHub;
using IndieGameZone.Application.IServices;
using IndieGameZone.Domain.Constants;
using IndieGameZone.Domain.Entities;
using IndieGameZone.Domain.IRepositories;
using IndieGameZone.Domain.RequestsAndResponses.Responses.Notifications;
using Microsoft.AspNetCore.SignalR;
using Microsoft.EntityFrameworkCore;

namespace IndieGameZone.Application.Services
{
	internal sealed class PostReactionService : IPostReactionService
	{
		private readonly IRepositoryManager repositoryManager;
		private readonly IHubContext<NotificationHub, INotificationHub> notificationHub;

		public PostReactionService(IRepositoryManager repositoryManager, IHubContext<NotificationHub, INotificationHub> notificationHub)
		{
			this.repositoryManager = repositoryManager;
			this.notificationHub = notificationHub;
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
			var notification = new Notifications
			{
				Id = Guid.NewGuid(),
				UserId = userId,
				Message = $"Congratulations! You have earned the {achievement.Name} achievement.",
				IsRead = false,
				CreatedAt = DateTime.Now
			};
			repositoryManager.NotificationRepository.CreateNotification(notification);
			await repositoryManager.SaveAsync(ct);
			await notificationHub.Clients.User(userId.ToString()).SendNotification(new NotificationForReturnDto
			{
				Id = notification.Id,
				Message = notification.Message,
				IsRead = notification.IsRead,
				CreatedAt = notification.CreatedAt,
				ReadAt = notification.ReadAt
			});
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
