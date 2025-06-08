using IndieGameZone.Domain.Entities;
using IndieGameZone.Domain.IRepositories;
using IndieGameZone.Infrastructure.Persistence;
using Microsoft.EntityFrameworkCore;

namespace IndieGameZone.Infrastructure.Repositories
{
	internal sealed class GameTagRepository : RepositoryBase<GameTags>, IGameTagRepository
	{
		public GameTagRepository(AppDbContext appDbContext) : base(appDbContext)
		{
		}

		public void CreateGameTag(IEnumerable<GameTags> gameTags) => CreateRange(gameTags);

		public void DeleteGameTag(IEnumerable<GameTags> gameTags) => DeleteRange(gameTags);

		public async Task<IEnumerable<GameTags>> GetGameTagsByGameId(Guid gameId, bool trackChanges, CancellationToken ct = default) => await
			FindByCondition(gt => gt.GameId.Equals(gameId), trackChanges)
				.ToListAsync(ct);
	}
}
