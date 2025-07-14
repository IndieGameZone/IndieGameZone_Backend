using IndieGameZone.Domain.Entities;

namespace IndieGameZone.Domain.IRepositories
{
	public interface IUserFollowRepository
	{
		void CreateFollow(UserFollows userFollow);
		void DeleteFollow(UserFollows userFollow);
		Task<UserFollows?> GetFollow(Guid followerId, Guid followeeId, bool trackChange, CancellationToken ct = default);
		IQueryable<UserFollows> GetFolloweesByUserId(Guid followeeId, bool trackChange, CancellationToken ct = default);
		IQueryable<UserFollows> GetFollowersByUserId(Guid followerId, bool trackChange, CancellationToken ct = default);
	}
}
