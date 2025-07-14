namespace IndieGameZone.Application.IServices
{
	public interface IUserFollowService
	{
		Task FollowOrUnfollowUser(Guid followerId, Guid followeeId, CancellationToken ct = default);
		Task<bool> IsFollowing(Guid followerId, Guid followeeId, CancellationToken ct = default);
		Task<int> GetNumberOfFollowee(Guid userId, CancellationToken ct = default);
		Task<int> GetNumberOfFollower(Guid userId, CancellationToken ct = default);
	}
}
