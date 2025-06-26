using IndieGameZone.Domain.Entities;
using IndieGameZone.Domain.RequestFeatures;

namespace IndieGameZone.Domain.IRepositories
{
	public interface IGameCensorLogRepository
	{
		void CreateCensorLog(GameCensorLogs gameCensorLog);
		Task<PagedList<GameCensorLogs>> GetCensorLogByGameId(Guid gameId, GameCensorLogParameters gameCensorLogParameters, bool trackChange, CancellationToken ct = default);
	}
}
