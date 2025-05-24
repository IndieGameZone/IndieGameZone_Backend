using IndieGameZone.Domain.Entities;
using IndieGameZone.Domain.IRepositories;
using IndieGameZone.Infrastructure.Persistence;

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
	}
}
