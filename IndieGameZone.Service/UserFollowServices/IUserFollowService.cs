namespace IndieGameZone.Application.UserFollowServices
{
	public interface IUserFollowService
	{
		Task FollowOrUnfollowUser(Guid followingUserId, Guid followedUserId, CancellationToken ct = default);
		Task<bool> IsFollowing(Guid followingUserId, Guid followedUserId, CancellationToken ct = default);
		Task<int> GetFollowedUserNumber(Guid userId, CancellationToken ct = default);
		Task<int> GetFollowingUserNumber(Guid userId, CancellationToken ct = default);
	}
}
