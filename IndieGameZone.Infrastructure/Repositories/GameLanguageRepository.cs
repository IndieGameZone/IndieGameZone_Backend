using IndieGameZone.Domain.Entities;
using IndieGameZone.Domain.IRepositories;
using IndieGameZone.Infrastructure.Persistence;

namespace IndieGameZone.Infrastructure.Repositories
{
	internal sealed class GameLanguageRepository : RepositoryBase<GameLanguages>, IGameLanguageRepository
	{
		private readonly AppDbContext appDbContext;

		public GameLanguageRepository(AppDbContext appDbContext) : base(appDbContext)
		{
			this.appDbContext = appDbContext;
		}

		public void CreateGameLanguage(IEnumerable<GameLanguages> gameLanguages) => appDbContext.GameLanguages.AddRange(gameLanguages);
	}
}
