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
		private readonly AppDbContext appDbContext;

		public AchievementRepository(AppDbContext appDbContext) : base(appDbContext)
		{
			this.appDbContext = appDbContext;
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

		public async Task<PagedList<Achievements>> GetAchievementsByUser(Guid userId, AchievementParameters parameters, bool obtained, CancellationToken ct = default)
		{
			// Get achievement IDs based on user
			var userAchievementIds = appDbContext.UserAchievements
				.Where(ua => ua.UserId == userId)
				.Select(ua => ua.AchievementId);

			// Apply base query from RepositoryBase (using tracking if needed)
			var baseQuery = FindAll(trackChanges: false);

			var filteredQuery = obtained
				? baseQuery.Where(a => userAchievementIds.Contains(a.Id))
				: baseQuery.Where(a => !userAchievementIds.Contains(a.Id));

			// Apply sorting
			filteredQuery = filteredQuery.Sort();

			// Return paginated result
			return await PagedList<Achievements>.ToPagedList(filteredQuery, parameters.PageNumber, parameters.PageSize, ct);
		}
	}
}
