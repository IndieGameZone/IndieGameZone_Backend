using IndieGameZone.Domain.Entities;

namespace IndieGameZone.Domain.IRepositories
{
	public interface IGameStatusRepository
	{
		Task<IEnumerable<GameStatuses>> GetGameStatuses(bool trackChange, CancellationToken ct = default);
		Task<GameStatuses?> GetGameStatusById(Guid id, bool trackChange, CancellationToken ct = default);
		void CreateGameStatus(GameStatuses gameStatus);
		void DeleteGameStatus(GameStatuses gameStatus);
	}
}
