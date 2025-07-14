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

		public async Task<UserFollows?> GetFollow(Guid followerId, Guid followeeId, bool trackChange, CancellationToken ct = default) => await
			FindByCondition(x => x.FollowerId == followerId && x.FolloweeId == followeeId, trackChange).FirstOrDefaultAsync(ct);

		public IQueryable<UserFollows> GetFolloweesByUserId(Guid followeeId, bool trackChange, CancellationToken ct = default) => FindByCondition(x => x.FolloweeId == followeeId, trackChange);

		public IQueryable<UserFollows> GetFollowersByUserId(Guid followerId, bool trackChange, CancellationToken ct = default) => FindByCondition(x => x.FollowerId == followerId, trackChange);
	}
}
