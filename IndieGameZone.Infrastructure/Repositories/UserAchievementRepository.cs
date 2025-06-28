using IndieGameZone.Domain.Entities;
using IndieGameZone.Domain.IRepositories;
using IndieGameZone.Domain.RequestFeatures;
using IndieGameZone.Infrastructure.Persistence;

namespace IndieGameZone.Infrastructure.Repositories
{
	internal sealed class UserAchievementRepository : RepositoryBase<UserAchievements>, IUserAchievementRepository
	{
		public UserAchievementRepository(AppDbContext appDbContext) : base(appDbContext)
		{
		}

		public void AddUserAchievement(UserAchievements userAchievements) => Create(userAchievements);

		public async Task<PagedList<UserAchievements>> GetUserAchievementsByUserId(Guid userId, UserAchievementParameters userAchievementParameters, bool trackChange, CancellationToken ct = default)
		{
			var userAchievements = FindByCondition(x => x.UserId == userId, trackChange);
			return await PagedList<UserAchievements>.ToPagedList(
				userAchievements,
				userAchievementParameters.PageNumber,
				userAchievementParameters.PageSize,
				ct
			);
		}
	}
}
