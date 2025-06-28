using IndieGameZone.Domain.RequestFeatures;
using IndieGameZone.Domain.RequestsAndResponses.Responses.UserAchievements;

namespace IndieGameZone.Application.UserAchievementServices
{
	public interface IUserAchievementService
	{
		Task<(IEnumerable<UserAchievementForReturnDto> userAchievements, MetaData metaData)> GetUserAchievementsForUser(Guid userId, UserAchievementParameters userAchievementParameters, CancellationToken ct = default);
	}
}
