using IndieGameZone.Domain.Entities;
using IndieGameZone.Domain.IRepositories;
using IndieGameZone.Infrastructure.Persistence;

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
	}
}
