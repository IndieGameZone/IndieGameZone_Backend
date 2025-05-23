using IndieGameZone.Domain.Entities;
using IndieGameZone.Domain.IRepositories;
using IndieGameZone.Infrastructure.Extensions;
using IndieGameZone.Infrastructure.Persistence;
using Microsoft.EntityFrameworkCore;

namespace IndieGameZone.Infrastructure.Repositories
{
	internal sealed class GameStatusRepository : RepositoryBase<GameStatuses>, IGameStatusRepository
	{
		public GameStatusRepository(AppDbContext appDbContext) : base(appDbContext)
		{
		}

		public void CreateGameStatus(GameStatuses gameStatus) => Create(gameStatus);

		public void DeleteGameStatus(GameStatuses gameStatus) => Delete(gameStatus);

		public async Task<GameStatuses?> GetGameStatusById(Guid id, bool trackChange, CancellationToken ct = default) => await FindByCondition(c => c.Id.Equals(id), trackChange)
			.SingleOrDefaultAsync(ct);

		public async Task<IEnumerable<GameStatuses>> GetGameStatuses(bool trackChange, CancellationToken ct = default)
		{
			return await FindAll(trackChange)
				.Sort()
				.ToListAsync(ct);
		}
	}
}
