using IndieGameZone.Domain.Entities;

namespace IndieGameZone.Domain.IRepositories
{
	public interface IUserFollowRepository
	{
		void CreateFollow(UserFollows userFollow);
		void DeleteFollow(UserFollows userFollow);
		Task<UserFollows?> GetFollow(Guid followingUserId, Guid followedUserId, bool trackChange, CancellationToken ct = default);
		IQueryable<UserFollows> GetFollowedUsersByUserId(Guid followedUserId, bool trackChange, CancellationToken ct = default);
		IQueryable<UserFollows> GetFollowingUsersByUserId(Guid followingUserId, bool trackChange, CancellationToken ct = default);
	}
}
