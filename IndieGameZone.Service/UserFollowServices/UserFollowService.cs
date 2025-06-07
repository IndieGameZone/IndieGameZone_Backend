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

		public async Task FollowOrUnfollowUser(Guid followedUserId, Guid followingUserId, CancellationToken ct = default)
		{
			var userFollow = await repositoryManager.UserFollowRepository.GetFollow(followingUserId, followedUserId, false, ct);
			if (userFollow == null)
			{
				repositoryManager.UserFollowRepository.CreateFollow(new UserFollows { FollowedUserId = followedUserId, FollowingUserId = followingUserId });
			}
			else
			{
				repositoryManager.UserFollowRepository.DeleteFollow(userFollow);
			}
			await repositoryManager.SaveAsync(ct);
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
