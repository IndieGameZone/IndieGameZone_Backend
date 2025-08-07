using IndieGameZone.Domain.Entities;
using IndieGameZone.Domain.RequestFeatures;

namespace IndieGameZone.Domain.IRepositories
{
	public interface IGamePriceLogRepository
	{
		void CreatePriceLog(GamePriceLogs gamePriceLog);
		Task<PagedList<GamePriceLogs>> GetPriceLogByGameId(Guid gameId, GamePriceLogParameters gamePriceLogParameters, bool trackChange, CancellationToken ct = default);
	}
}
