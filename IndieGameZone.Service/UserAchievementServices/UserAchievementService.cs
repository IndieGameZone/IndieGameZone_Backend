using IndieGameZone.Domain.IRepositories;
using IndieGameZone.Domain.RequestFeatures;
using IndieGameZone.Domain.RequestsAndResponses.Responses.UserAchievements;
using MapsterMapper;

namespace IndieGameZone.Application.UserAchievementServices
{
	internal sealed class UserAchievementService : IUserAchievementService
	{
		private readonly IRepositoryManager repositoryManager;
		private readonly IMapper mapper;

		public UserAchievementService(IRepositoryManager repositoryManager, IMapper mapper)
		{
			this.repositoryManager = repositoryManager;
			this.mapper = mapper;
		}
		public async Task<(IEnumerable<UserAchievementForReturnDto> userAchievements, MetaData metaData)> GetUserAchievementsForUser(Guid userId, UserAchievementParameters userAchievementParameters, CancellationToken ct = default)
		{
			var userAchievementsWithMetaData = await repositoryManager.UserAchievementRepository.GetUserAchievementsByUserId(userId, userAchievementParameters, false, ct);
			var userAchievements = mapper.Map<IEnumerable<UserAchievementForReturnDto>>(userAchievementsWithMetaData);
			return (userAchievements, userAchievementsWithMetaData.MetaData);
		}
	}
}
