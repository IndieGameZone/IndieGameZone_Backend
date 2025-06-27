using IndieGameZone.Domain.Entities;
using IndieGameZone.Domain.IRepositories;
using IndieGameZone.Infrastructure.Persistence;
using Microsoft.EntityFrameworkCore;

namespace IndieGameZone.Infrastructure.Repositories
{
	internal sealed class GameRecommendationRepository : RepositoryBase<GameRecommendations>, IGameRecommendationRepository
	{
		public GameRecommendationRepository(AppDbContext appDbContext) : base(appDbContext)
		{
		}

		public void AddRecommendations(IEnumerable<GameRecommendations> recommendations) => CreateRange(recommendations);

		public async Task<IEnumerable<GameRecommendations>> GetRecommendationsByUserId(Guid userId, bool trackChanges, CancellationToken ct = default) => await
			FindByCondition(r => r.UserId == userId, trackChanges)
			.ToListAsync(ct);

		public void RemoveRecommendations(IEnumerable<GameRecommendations> recommendations) => DeleteRange(recommendations);
	}
}
