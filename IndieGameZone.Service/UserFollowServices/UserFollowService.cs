using IndieGameZone.Domain.Entities;
using IndieGameZone.Domain.Exceptions;
using IndieGameZone.Domain.IRepositories;
using Microsoft.EntityFrameworkCore;

namespace IndieGameZone.Application.UserFollowServices
{
	internal sealed class UserFollowService : IUserFollowService
	{
		private readonly IRepositoryManager repositoryManager;

		public UserFollowService(IRepositoryManager repositoryManager)
		{
			this.repositoryManager = repositoryManager;
		}

		private async Task CheckFollowAchievements(Guid userId, CancellationToken ct = default)
		{
			var userAchievements = repositoryManager.UserAchievementRepository.GetUserAchievementsByUserId(userId, false);
			var followingCount = await repositoryManager.UserFollowRepository.GetFolloweesByUserId(userId, false).CountAsync(ct);
			if (followingCount == 5 && !userAchievements.Any(u => u.AchievementId == Guid.Parse("b83dc1f6-cc35-4955-9a5d-3ae89a90e5d6")))
			{
				var achievement = await repositoryManager.AchievementRepository.GetAchievementById(Guid.Parse("b83dc1f6-cc35-4955-9a5d-3ae89a90e5d6"), false, ct);
				if (achievement is null)
					throw new NotFoundException("Achievement not found.");
				repositoryManager.UserAchievementRepository.AddUserAchievement(new UserAchievements
				{
					UserId = userId,
					AchievementId = Guid.Parse("b83dc1f6-cc35-4955-9a5d-3ae89a90e5d6")
				});
				repositoryManager.CouponRepository.CreateCoupon(new Coupons
				{
					Id = Guid.NewGuid(),
					Code = Guid.NewGuid().ToString(),
					Percentage = 3,
					IsUsed = false,
					EndDate = DateOnly.FromDateTime(DateTime.Now.AddDays(30)),
					UserId = userId
				});
				repositoryManager.NotificationRepository.CreateNotification(new Notifications
				{
					Id = Guid.NewGuid(),
					UserId = userId,
					Message = $"Congratulations! You have earned the {achievement.Name} achievement and a 3% discount coupon.",
					IsRead = false,
					CreatedAt = DateTime.Now
				});
			}
			else if (followingCount == 10 && !userAchievements.Any(u => u.AchievementId == Guid.Parse("b186aeb1-033f-4937-a24c-d11b1989e7e2")))
			{
				var achievement = await repositoryManager.AchievementRepository.GetAchievementById(Guid.Parse("b186aeb1-033f-4937-a24c-d11b1989e7e2"), false, ct);
				if (achievement is null)
					throw new NotFoundException("Achievement not found.");
				repositoryManager.UserAchievementRepository.AddUserAchievement(new UserAchievements
				{
					UserId = userId,
					AchievementId = Guid.Parse("b186aeb1-033f-4937-a24c-d11b1989e7e2")
				});
				repositoryManager.CouponRepository.CreateCoupon(new Coupons
				{
					Id = Guid.NewGuid(),
					Code = Guid.NewGuid().ToString(),
					Percentage = 4,
					IsUsed = false,
					EndDate = DateOnly.FromDateTime(DateTime.Now.AddDays(30)),
					UserId = userId
				});
				repositoryManager.NotificationRepository.CreateNotification(new Notifications
				{
					Id = Guid.NewGuid(),
					UserId = userId,
					Message = $"Congratulations! You have earned the {achievement.Name} achievement and a 4% discount coupon.",
					IsRead = false,
					CreatedAt = DateTime.Now
				});
			}
			else if (followingCount == 50 && !userAchievements.Any(u => u.AchievementId == Guid.Parse("5a8d9a1a-4b12-464b-8a70-d0309c3f355d")))
			{
				var achievement = await repositoryManager.AchievementRepository.GetAchievementById(Guid.Parse("5a8d9a1a-4b12-464b-8a70-d0309c3f355d"), false, ct);
				if (achievement is null)
					throw new NotFoundException("Achievement not found.");
				repositoryManager.UserAchievementRepository.AddUserAchievement(new UserAchievements
				{
					UserId = userId,
					AchievementId = Guid.Parse("5a8d9a1a-4b12-464b-8a70-d0309c3f355d")
				});
				repositoryManager.CouponRepository.CreateCoupon(new Coupons
				{
					Id = Guid.NewGuid(),
					Code = Guid.NewGuid().ToString(),
					Percentage = 5,
					IsUsed = false,
					EndDate = DateOnly.FromDateTime(DateTime.Now.AddDays(30)),
					UserId = userId
				});
				repositoryManager.NotificationRepository.CreateNotification(new Notifications
				{
					Id = Guid.NewGuid(),
					UserId = userId,
					Message = $"Congratulations! You have earned the {achievement.Name} achievement and a 5% discount coupon.",
					IsRead = false,
					CreatedAt = DateTime.Now
				});
			}
			await repositoryManager.SaveAsync(ct);
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
