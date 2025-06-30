using IndieGameZone.Domain.Entities;
using IndieGameZone.Domain.IRepositories;
using IndieGameZone.Infrastructure.Persistence;

namespace IndieGameZone.Infrastructure.Repositories
{
	internal sealed class UserAchievementRepository : RepositoryBase<UserAchievements>, IUserAchievementRepository
	{
		private readonly AppDbContext appDbContext;

		public UserAchievementRepository(AppDbContext appDbContext) : base(appDbContext)
		{
			this.appDbContext = appDbContext;
		}

		public void AddUserAchievement(UserAchievements userAchievements) => Create(userAchievements);

		public IQueryable<UserAchievements> GetUserAchievementsByUserId(Guid userId, bool trackChange, CancellationToken ct = default) => FindByCondition(x => x.UserId == userId, trackChange);
	}
}
