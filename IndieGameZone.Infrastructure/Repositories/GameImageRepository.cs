using IndieGameZone.Domain.Entities;
using IndieGameZone.Domain.IRepositories;
using IndieGameZone.Infrastructure.Persistence;
using Microsoft.EntityFrameworkCore;

namespace IndieGameZone.Infrastructure.Repositories
{
	internal sealed class GameImageRepository : RepositoryBase<GameImages>, IGameImageRepository
	{
		private readonly AppDbContext appDbContext;

		public GameImageRepository(AppDbContext appDbContext) : base(appDbContext)
		{
			this.appDbContext = appDbContext;
		}

		public void CreateGameImage(IEnumerable<GameImages> gameImages) => appDbContext.GameImages.AddRange(gameImages);

		public void DeleteGameImage(IEnumerable<GameImages> gameImages) => appDbContext.GameImages.RemoveRange(gameImages);

		public async Task<IEnumerable<GameImages>> GetGameImagesByGameId(Guid gameId, bool trackChanges, CancellationToken ct = default) => await
			FindByCondition(x => x.GameId == gameId, trackChanges)
				.ToListAsync(ct);
	}
}
