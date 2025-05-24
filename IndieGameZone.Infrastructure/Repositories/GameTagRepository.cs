using IndieGameZone.Domain.Entities;
using IndieGameZone.Domain.IRepositories;
using IndieGameZone.Infrastructure.Persistence;

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
	}
}
