using IndieGameZone.Domain.Entities;
using IndieGameZone.Domain.Exceptions;
using IndieGameZone.Domain.IRepositories;
using IndieGameZone.Domain.RequestFeatures;
using IndieGameZone.Domain.RequestsAndResponses.Requests.Achievements;
using IndieGameZone.Domain.RequestsAndResponses.Responses.Achievements;
using MapsterMapper;

namespace IndieGameZone.Application.AchievementServices
{
	internal sealed class AchievementService : IAchievementService
	{
		private readonly IRepositoryManager repositoryManager;
		private readonly IMapper mapper;

		public AchievementService(IRepositoryManager repositoryManager, IMapper mapper)
		{
			this.repositoryManager = repositoryManager;
			this.mapper = mapper;
		}
		public async Task CreateAchievement(AchievementForCreationDto achievementForCreationDto, CancellationToken ct = default)
		{
			var achievementEntity = mapper.Map<Achievements>(achievementForCreationDto);
			achievementEntity.Id = Guid.NewGuid();
			repositoryManager.AchievementRepository.CreateAchievement(achievementEntity);
            await repositoryManager.SaveAsync(ct);
		}

		public async Task DeleteAchievement(Guid id, CancellationToken ct = default)
		{
			var achievementEntity = await repositoryManager.AchievementRepository.GetAchievementById(id, false, ct);
			if (achievementEntity is null)
			{
				throw new NotFoundException($"Achievement not found.");
			}
			repositoryManager.AchievementRepository.DeleteAchievement(achievementEntity);
			await repositoryManager.SaveAsync(ct);
		}

		public async Task<AchievementForReturnDto> GetAchievementById(Guid id, CancellationToken ct = default)
		{
			var achievementEntity = await repositoryManager.AchievementRepository.GetAchievementById(id, false, ct);
			if (achievementEntity is null)
			{
				throw new NotFoundException($"Achievement not found.");
			}
			return mapper.Map<AchievementForReturnDto>(achievementEntity);
		}

		public async Task<(IEnumerable<AchievementForReturnDto> achievements, MetaData metaData)> GetAchievements(AchievementParameters achievementParameters, CancellationToken ct = default)
		{
			var achievementsWithMetaData = await repositoryManager.AchievementRepository.GetAchievements(achievementParameters, false, ct);
			var achievements = mapper.Map<IEnumerable<AchievementForReturnDto>>(achievementsWithMetaData);
			return (achievements, achievementsWithMetaData.MetaData);
		}

        public async Task<(IEnumerable<AchievementForReturnDto> achievements, MetaData metaData)> GetObtainedAchievementsByUser(Guid userId, AchievementParameters parameters, CancellationToken ct = default)
        {
            var obtainedPaged = await repositoryManager.AchievementRepository.GetAchievementsByUser(userId, parameters, obtained: true, ct);
            var dtos = mapper.Map<IEnumerable<AchievementForReturnDto>>(obtainedPaged);
            return (dtos, obtainedPaged.MetaData);
        }

        public async Task<(IEnumerable<AchievementForReturnDto> achievements, MetaData metaData)> GetUnobtainedAchievementsByUser(Guid userId, AchievementParameters parameters, CancellationToken ct = default)
        {
            var unobtainedPaged = await repositoryManager.AchievementRepository.GetAchievementsByUser(userId, parameters, obtained: false, ct);
            var dtos = mapper.Map<IEnumerable<AchievementForReturnDto>>(unobtainedPaged);
            return (dtos, unobtainedPaged.MetaData);
        }

        public async Task UpdateAchievement(Guid id, AchievementForUpdateDto achievementForUpdateDto, CancellationToken ct = default)
		{
			var achievementEntity = await repositoryManager.AchievementRepository.GetAchievementById(id, true, ct);
			if (achievementEntity is null)
			{
				throw new NotFoundException($"Achievement not found.");
			}
			mapper.Map(achievementForUpdateDto, achievementEntity);
			await repositoryManager.SaveAsync(ct);
		}
	}
}
