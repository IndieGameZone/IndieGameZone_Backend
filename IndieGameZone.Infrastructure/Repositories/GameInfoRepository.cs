using IndieGameZone.Domain.Entities;
using IndieGameZone.Domain.IRepositories;
using IndieGameZone.Infrastructure.Persistence;
using Microsoft.EntityFrameworkCore;

namespace IndieGameZone.Infrastructure.Repositories
{
	internal sealed class GameInfoRepository : RepositoryBase<GameImages>, IGameInfoRepository
	{
		private readonly AppDbContext appDbContext;

		public GameInfoRepository(AppDbContext appDbContext) : base(appDbContext)
		{
			this.appDbContext = appDbContext;
		}

		public void CreateGameInfo(IEnumerable<GameImages> gameInfos) => appDbContext.GameInfos.AddRange(gameInfos);

		public void DeleteGameInfo(IEnumerable<GameImages> gameInfos) => appDbContext.GameInfos.RemoveRange(gameInfos);

		public async Task<IEnumerable<GameImages>> GetGameInfosByGameId(Guid gameId, bool trackChanges, CancellationToken ct = default) => await
			FindByCondition(x => x.GameId == gameId, trackChanges)
				.ToListAsync(ct);
	}
}
