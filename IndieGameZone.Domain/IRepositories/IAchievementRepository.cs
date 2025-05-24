using IndieGameZone.Domain.Entities;
using IndieGameZone.Domain.RequestFeatures;

namespace IndieGameZone.Domain.IRepositories
{
	public interface IAchievementRepository
	{
		Task<PagedList<Achievements>> GetAchievements(AchievementParameters achievementParameters, bool trackChange, CancellationToken ct = default);
		Task<Achievements?> GetAchievementById(Guid id, bool trackChange, CancellationToken ct = default);
		void CreateAchievement(Achievements achievement);
		void DeleteAchievement(Achievements achievement);
	}
}
