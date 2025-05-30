using IndieGameZone.Domain.Entities;
using IndieGameZone.Domain.IRepositories;
using IndieGameZone.Infrastructure.Extensions;
using IndieGameZone.Infrastructure.Persistence;
using Microsoft.EntityFrameworkCore;

namespace IndieGameZone.Infrastructure.Repositories
{
	internal sealed class GameTypeRepository : RepositoryBase<GameTypes>, IGameTypeRepository
	{
		public GameTypeRepository(AppDbContext appDbContext) : base(appDbContext)
		{
		}

		public void CreateGameType(GameTypes gameStatus) => Create(gameStatus);

		public void DeleteGameType(GameTypes gameStatus) => Delete(gameStatus);

		public async Task<GameTypes?> GetGameTypeById(Guid id, bool trackChange, CancellationToken ct = default) => await FindByCondition(c => c.Id.Equals(id), trackChange)
			.SingleOrDefaultAsync(ct);

		public async Task<IEnumerable<GameTypes>> GetGameTypes(bool trackChange, CancellationToken ct = default)
		{
			return await FindAll(trackChange)
				.Sort()
				.ToListAsync(ct);
		}
	}
}
