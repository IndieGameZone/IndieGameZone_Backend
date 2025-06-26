using IndieGameZone.Domain.Entities;
using IndieGameZone.Domain.IRepositories;
using IndieGameZone.Domain.RequestFeatures;
using IndieGameZone.Infrastructure.Extensions;
using IndieGameZone.Infrastructure.Persistence;
using Microsoft.EntityFrameworkCore;

namespace IndieGameZone.Infrastructure.Repositories
{
	internal sealed class GameCensorLogRepository : RepositoryBase<GameCensorLogs>, IGameCensorLogRepository
	{
		public GameCensorLogRepository(AppDbContext appDbContext) : base(appDbContext)
		{
		}

		public void CreateCensorLog(GameCensorLogs gameCensorLog) => Create(gameCensorLog);

		public async Task<PagedList<GameCensorLogs>> GetCensorLogByGameId(Guid gameId, GameCensorLogParameters gameCensorLogParameters, bool trackChange, CancellationToken ct = default)
		{
			var gameCensorLogs = FindByCondition(x => x.GameId == gameId, trackChange)
				.Include(x => x.Moderator)
				.Sort();

			return await PagedList<GameCensorLogs>.ToPagedList(gameCensorLogs, gameCensorLogParameters.PageNumber, gameCensorLogParameters.PageSize, ct);
		}
	}
}
