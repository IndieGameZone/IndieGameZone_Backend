using IndieGameZone.Domain.Entities;
using IndieGameZone.Domain.RequestFeatures;

namespace IndieGameZone.Domain.IRepositories
{
	public interface IUserAchievementRepository
	{
		void AddUserAchievement(UserAchievements userAchievements);
		Task<PagedList<UserAchievements>> GetUserAchievementsByUserId(Guid userId, UserAchievementParameters userAchievementParameters, bool trackChange, CancellationToken ct = default);
		IQueryable<UserAchievements> GetUserAchievementsByUserId(Guid userId, bool trackChange, CancellationToken ct = default);
	}
}
