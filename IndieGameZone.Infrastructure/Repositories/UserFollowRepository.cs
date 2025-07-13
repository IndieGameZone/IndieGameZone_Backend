using IndieGameZone.Domain.Entities;
using IndieGameZone.Domain.IRepositories;
using IndieGameZone.Infrastructure.Persistence;
using Microsoft.EntityFrameworkCore;

namespace IndieGameZone.Infrastructure.Repositories
{
	internal sealed class UserFollowRepository : RepositoryBase<UserFollows>, IUserFollowRepository
	{
		public UserFollowRepository(AppDbContext appDbContext) : base(appDbContext)
		{
		}

		public void CreateFollow(UserFollows userFollow) => Create(userFollow);

		public void DeleteFollow(UserFollows userFollow) => Delete(userFollow);

		public async Task<UserFollows?> GetFollow(Guid followingUserId, Guid followedUserId, bool trackChange, CancellationToken ct = default) => await
			FindByCondition(x => x.FollowerId == followingUserId && x.FolloweeId == followedUserId, trackChange).FirstOrDefaultAsync(ct);

		public IQueryable<UserFollows> GetFollowedUsersByUserId(Guid followedUserId, bool trackChange, CancellationToken ct = default) => FindByCondition(x => x.FolloweeId == followedUserId, trackChange);

		public IQueryable<UserFollows> GetFollowingUsersByUserId(Guid followingUserId, bool trackChange, CancellationToken ct = default) => FindByCondition(x => x.FollowerId == followingUserId, trackChange);
	}
}
