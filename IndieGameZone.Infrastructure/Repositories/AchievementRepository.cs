using IndieGameZone.Domain.Entities;
using IndieGameZone.Domain.IRepositories;
using IndieGameZone.Domain.RequestFeatures;
using IndieGameZone.Infrastructure.Extensions;
using IndieGameZone.Infrastructure.Persistence;
using Microsoft.EntityFrameworkCore;

namespace IndieGameZone.Infrastructure.Repositories
{
	internal sealed class AchievementRepository : RepositoryBase<Achievements>, IAchievementRepository
	{
		public AchievementRepository(AppDbContext appDbContext) : base(appDbContext)
		{
		}

		public void CreateAchievement(Achievements achievement) => Create(achievement);

		public void DeleteAchievement(Achievements achievement) => Delete(achievement);

		public async Task<Achievements?> GetAchievementById(Guid id, bool trackChange, CancellationToken ct = default) => await FindByCondition(a => a.Id.Equals(id), trackChange)
			.SingleOrDefaultAsync(ct);

		public async Task<PagedList<Achievements>> GetAchievements(AchievementParameters achievementParameters, bool trackChange, CancellationToken ct = default)
		{
			var achievementEntities = FindAll(trackChange)
				.Sort();

			return await PagedList<Achievements>.ToPagedList(achievementEntities, achievementParameters.PageNumber, achievementParameters.PageSize, ct);
		}
	}
}
