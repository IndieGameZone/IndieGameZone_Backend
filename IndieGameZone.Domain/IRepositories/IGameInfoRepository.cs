using IndieGameZone.Domain.Entities;

namespace IndieGameZone.Domain.IRepositories
{
	public interface IGameInfoRepository
	{
		void CreateGameInfo(IEnumerable<GameImages> gameInfos);
		void DeleteGameInfo(IEnumerable<GameImages> gameInfos);
		Task<IEnumerable<GameImages>> GetGameInfosByGameId(Guid gameId, bool trackChanges, CancellationToken ct = default);
	}
}
