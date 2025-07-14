using IndieGameZone.Domain.RequestFeatures;
using IndieGameZone.Domain.RequestsAndResponses.Requests.Achievements;
using IndieGameZone.Domain.RequestsAndResponses.Responses.Achievements;

namespace IndieGameZone.Application.IServices
{
	public interface IAchievementService
	{
		Task CreateAchievement(AchievementForCreationDto achievementForCreationDto, CancellationToken ct = default);
		Task UpdateAchievement(Guid id, AchievementForUpdateDto achievementForUpdateDto, CancellationToken ct = default);
		Task DeleteAchievement(Guid id, CancellationToken ct = default);
		Task<AchievementForReturnDto> GetAchievementById(Guid id, CancellationToken ct = default);
		Task<(IEnumerable<AchievementForReturnDto> achievements, MetaData metaData)> GetAchievements(AchievementParameters achievementParameters, CancellationToken ct = default);
        Task<(IEnumerable<AchievementForReturnDto> achievements, MetaData metaData)> GetObtainedAchievementsByUser(Guid userId, AchievementParameters parameters, CancellationToken ct = default);
        Task<(IEnumerable<AchievementForReturnDto> achievements, MetaData metaData)> GetUnobtainedAchievementsByUser(Guid userId, AchievementParameters parameters, CancellationToken ct = default);

    }
}
