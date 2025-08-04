using IndieGameZone.Application.Hub;
using IndieGameZone.Application.IHub;
using IndieGameZone.Application.IServices;
using IndieGameZone.Domain.Constants;
using IndieGameZone.Domain.Entities;
using IndieGameZone.Domain.IRepositories;
using Microsoft.AspNetCore.SignalR;
using Microsoft.EntityFrameworkCore;

namespace IndieGameZone.Application.Services
{
	internal sealed class UserFollowService : IUserFollowService
	{
		private readonly IRepositoryManager repositoryManager;
		private readonly IHubContext<NotificationHub, INotificationHub> notificationHub;

		public UserFollowService(IRepositoryManager repositoryManager, IHubContext<NotificationHub, INotificationHub> notificationHub)
		{
			this.repositoryManager = repositoryManager;
			this.notificationHub = notificationHub;
		}

		private async Task CheckFollowAchievements(Guid userId, CancellationToken ct = default)
		{
			var userAchievements = repositoryManager.UserAchievementRepository.GetUserAchievementsByUserId(userId, false);
			var numberOfFollowee = await repositoryManager.UserFollowRepository.GetFolloweesByUserId(userId, false).CountAsync(ct);
			var achievement = await repositoryManager.AchievementRepository.GetAchievementByLevelAndType(numberOfFollowee, AchievementType.Follow, false, ct);
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
				Message = $"Congratulations! You have earned the {achievement.Name} achievement and receive a {achievement.DiscountAward}% discount.",
				IsRead = false,
				CreatedAt = DateTime.Now
			};
			repositoryManager.NotificationRepository.CreateNotification(notification);
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
			await notificationHub.Clients.User(userId.ToString()).SendNotification(notification);
		}

		public async Task FollowOrUnfollowUser(Guid followeeId, Guid followerId, CancellationToken ct = default)
		{
			var userFollow = await repositoryManager.UserFollowRepository.GetFollow(followerId, followeeId, false, ct);
			if (userFollow == null)
			{
				repositoryManager.UserFollowRepository.CreateFollow(new UserFollows { FolloweeId = followeeId, FollowerId = followerId });
				await repositoryManager.SaveAsync(ct);
				await CheckFollowAchievements(followerId, ct);
			}
			else
			{
				repositoryManager.UserFollowRepository.DeleteFollow(userFollow);
				await repositoryManager.SaveAsync(ct);
			}
		}

		public Task<int> GetNumberOfFollowee(Guid userId, CancellationToken ct = default)
		{
			return repositoryManager.UserFollowRepository.GetFolloweesByUserId(userId, false, ct).CountAsync(ct);
		}

		public Task<int> GetNumberOfFollower(Guid userId, CancellationToken ct = default)
		{
			return repositoryManager.UserFollowRepository.GetFollowersByUserId(userId, false, ct).CountAsync(ct);
		}

		public async Task<bool> IsFollowing(Guid followedUserId, Guid followingUserId, CancellationToken ct = default)
		{
			return await repositoryManager.UserFollowRepository.GetFollow(followingUserId, followedUserId, false, ct) != null;
		}
	}
}
