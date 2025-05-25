using IndieGameZone.Domain.Entities;
using IndieGameZone.Domain.IRepositories;
using IndieGameZone.Infrastructure.Persistence;
using Microsoft.EntityFrameworkCore;

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

		public void DeleteGameLanguage(IEnumerable<GameLanguages> gameLanguages) => appDbContext.GameLanguages.RemoveRange(gameLanguages);

		public async Task<IEnumerable<GameLanguages>> GetGameLanguagesByGameId(Guid gameId, bool trackChanges, CancellationToken ct = default) => await
			FindByCondition(gl => gl.GameId == gameId, trackChanges)
				.ToListAsync(ct);
	}
}
