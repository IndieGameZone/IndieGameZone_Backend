using IndieGameZone.Domain.Entities;
using IndieGameZone.Domain.IRepositories;
using IndieGameZone.Infrastructure.Persistence;
using Microsoft.EntityFrameworkCore;

namespace IndieGameZone.Infrastructure.Repositories
{
	internal sealed class GameTagRepository : RepositoryBase<GameTags>, IGameTagRepository
	{
		private readonly AppDbContext appDbContext;

		public GameTagRepository(AppDbContext appDbContext) : base(appDbContext)
		{
			this.appDbContext = appDbContext;
		}

		public void CreateGameTag(IEnumerable<GameTags> gameTags) => appDbContext.GameTags.AddRange(gameTags);

		public void DeleteGameTag(IEnumerable<GameTags> gameTags) => appDbContext.GameTags.RemoveRange(gameTags);

		public async Task<IEnumerable<GameTags>> GetGameTagsByGameId(Guid gameId, bool trackChanges, CancellationToken ct = default) => await
			FindByCondition(gt => gt.GameId.Equals(gameId), trackChanges)
				.ToListAsync(ct);
	}
}
