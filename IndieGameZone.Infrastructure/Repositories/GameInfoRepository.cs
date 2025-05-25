using IndieGameZone.Domain.Entities;
using IndieGameZone.Domain.IRepositories;
using IndieGameZone.Infrastructure.Persistence;
using Microsoft.EntityFrameworkCore;

namespace IndieGameZone.Infrastructure.Repositories
{
	internal sealed class GameInfoRepository : RepositoryBase<GameInfos>, IGameInfoRepository
	{
		private readonly AppDbContext appDbContext;

		public GameInfoRepository(AppDbContext appDbContext) : base(appDbContext)
		{
			this.appDbContext = appDbContext;
		}

		public void CreateGameInfo(IEnumerable<GameInfos> gameInfos) => appDbContext.GameInfos.AddRange(gameInfos);

		public void DeleteGameInfo(IEnumerable<GameInfos> gameInfos) => appDbContext.GameInfos.RemoveRange(gameInfos);

		public async Task<IEnumerable<GameInfos>> GetGameInfosByGameId(Guid gameId, bool trackChanges, CancellationToken ct = default) => await
			FindByCondition(x => x.GameId == gameId, trackChanges)
				.ToListAsync(ct);
	}
}
