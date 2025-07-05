using IndieGameZone.Domain.Entities;
using IndieGameZone.Domain.IRepositories;
using IndieGameZone.Infrastructure.Persistence;
using Microsoft.EntityFrameworkCore;

namespace IndieGameZone.Infrastructure.Repositories
{
	internal sealed class GamePlatformRepository : RepositoryBase<GamePlatforms>, IGamePlatformRepository
	{
		private readonly AppDbContext appDbContext;

		public GamePlatformRepository(AppDbContext appDbContext) : base(appDbContext)
		{
			this.appDbContext = appDbContext;
		}

		public void CreateGamePlatform(IEnumerable<GamePlatforms> gamePlatforms) => appDbContext.GamePlatforms.AddRange(gamePlatforms);

		public void DeleteGamePlatform(IEnumerable<GamePlatforms> gamePlatforms) => appDbContext.GamePlatforms.RemoveRange(gamePlatforms);

		public async Task<IEnumerable<GamePlatforms>> GetGameActivePlatformsByGameId(Guid gameId, bool trackChanges, CancellationToken ct = default) => await
			FindByCondition(gp => gp.GameId.Equals(gameId) && gp.IsActive, trackChanges).ToListAsync(ct);

		public async Task<IEnumerable<GamePlatforms>> GetGamePlatformsByGameId(Guid gameId, bool trackChanges, CancellationToken ct = default) => await
			FindByCondition(gp => gp.GameId.Equals(gameId), trackChanges).ToListAsync(ct);

		public async Task<GamePlatforms?> GetGamePlatformsById(Guid gamePlatformId, bool trackChanges, CancellationToken ct = default) => await
			FindByCondition(gp => gp.Id.Equals(gamePlatformId), trackChanges).FirstOrDefaultAsync(ct);
	}
}
