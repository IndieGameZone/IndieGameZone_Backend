using IndieGameZone.Domain.Entities;

namespace IndieGameZone.Domain.IRepositories
{
	public interface IGameInfoRepository
	{
		void CreateGameInfo(IEnumerable<GameInfos> gameInfos);
	}
}
