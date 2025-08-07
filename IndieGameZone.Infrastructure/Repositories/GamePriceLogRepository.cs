using IndieGameZone.Domain.Entities;
using IndieGameZone.Domain.IRepositories;
using IndieGameZone.Domain.RequestFeatures;
using IndieGameZone.Infrastructure.Extensions;
using IndieGameZone.Infrastructure.Persistence;

namespace IndieGameZone.Infrastructure.Repositories
{
	internal sealed class GamePriceLogRepository : RepositoryBase<GamePriceLogs>, IGamePriceLogRepository
	{
		public GamePriceLogRepository(AppDbContext appDbContext) : base(appDbContext)
		{
		}

		public void CreatePriceLog(GamePriceLogs gamePriceLog) => Create(gamePriceLog);

		public Task<PagedList<GamePriceLogs>> GetPriceLogByGameId(Guid gameId, GamePriceLogParameters gamePriceLogParameters, bool trackChange, CancellationToken ct = default)
		{
			var gamePriceLogs = FindByCondition(x => x.GameId == gameId, trackChange)
				.Sort();
			return PagedList<GamePriceLogs>.ToPagedList(gamePriceLogs, gamePriceLogParameters.PageNumber, gamePriceLogParameters.PageSize, ct);
		}
	}
}
