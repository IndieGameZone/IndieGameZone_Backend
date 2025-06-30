using IndieGameZone.Domain.Entities;

namespace IndieGameZone.Domain.IRepositories
{
	public interface IUserAchievementRepository
	{
		void AddUserAchievement(UserAchievements userAchievements);
		IQueryable<UserAchievements> GetUserAchievementsByUserId(Guid userId, bool trackChange, CancellationToken ct = default);
	}
}
