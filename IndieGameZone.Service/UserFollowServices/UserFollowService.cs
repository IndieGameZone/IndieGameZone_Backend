using IndieGameZone.Domain.Entities;
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
			var followingCount = await repositoryManager.UserFollowRepository.GetFollowingUsersByUserId(userId, false).CountAsync(ct);
			if (followingCount == 5 && !userAchievements.Any(u => u.AchievementId == Guid.Parse("b83dc1f6-cc35-4955-9a5d-3ae89a90e5d6")))
			{
				repositoryManager.UserAchievementRepository.AddUserAchievement(new UserAchievements
				{
					UserId = userId,
					AchievementId = Guid.Parse("b83dc1f6-cc35-4955-9a5d-3ae89a90e5d6")
				});
			}
			else if (followingCount == 10 && !userAchievements.Any(u => u.AchievementId == Guid.Parse("b186aeb1-033f-4937-a24c-d11b1989e7e2")))
			{
				repositoryManager.UserAchievementRepository.AddUserAchievement(new UserAchievements
				{
					UserId = userId,
					AchievementId = Guid.Parse("b186aeb1-033f-4937-a24c-d11b1989e7e2")
				});
			}
			else if (followingCount == 50 && !userAchievements.Any(u => u.AchievementId == Guid.Parse("5a8d9a1a-4b12-464b-8a70-d0309c3f355d")))
			{
				repositoryManager.UserAchievementRepository.AddUserAchievement(new UserAchievements
				{
					UserId = userId,
					AchievementId = Guid.Parse("5a8d9a1a-4b12-464b-8a70-d0309c3f355d")
				});
			}
			await repositoryManager.SaveAsync(ct);
		}

		public async Task FollowOrUnfollowUser(Guid followedUserId, Guid followingUserId, CancellationToken ct = default)
		{
			var userFollow = await repositoryManager.UserFollowRepository.GetFollow(followingUserId, followedUserId, false, ct);
			if (userFollow == null)
			{
				repositoryManager.UserFollowRepository.CreateFollow(new UserFollows { FollowedUserId = followedUserId, FollowingUserId = followingUserId });
				await repositoryManager.SaveAsync(ct);
				await CheckFollowAchievements(followingUserId, ct);
			}
			else
			{
				repositoryManager.UserFollowRepository.DeleteFollow(userFollow);
				await repositoryManager.SaveAsync(ct);
			}
		}

		public Task<int> GetFollowedUserNumber(Guid userId, CancellationToken ct = default)
		{
			return repositoryManager.UserFollowRepository.GetFollowedUsersByUserId(userId, false, ct).CountAsync(ct);
		}

		public Task<int> GetFollowingUserNumber(Guid userId, CancellationToken ct = default)
		{
			return repositoryManager.UserFollowRepository.GetFollowingUsersByUserId(userId, false, ct).CountAsync(ct);
		}

		public async Task<bool> IsFollowing(Guid followedUserId, Guid followingUserId, CancellationToken ct = default)
		{
			return await repositoryManager.UserFollowRepository.GetFollow(followingUserId, followedUserId, false, ct) != null;
		}
	}
}
