using IndieGameZone.Domain.Entities;

namespace IndieGameZone.Domain.IRepositories
{
	public interface IGameInfoRepository
	{
		void CreateGameInfo(IEnumerable<GameInfos> gameInfos);
		void DeleteGameInfo(IEnumerable<GameInfos> gameInfos);
		Task<IEnumerable<GameInfos>> GetGameInfosByGameId(Guid gameId, bool trackChanges, CancellationToken ct = default);
	}
}
