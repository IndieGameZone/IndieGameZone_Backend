using IndieGameZone.Domain.Entities;

namespace IndieGameZone.Domain.IRepositories
{
	public interface IGameTypeRepository
	{
		Task<IEnumerable<GameTypes>> GetGameTypes(bool trackChange, CancellationToken ct = default);
		Task<GameTypes?> GetGameTypeById(Guid id, bool trackChange, CancellationToken ct = default);
		void CreateGameType(GameTypes gameStatus);
		void DeleteGameType(GameTypes gameStatus);
	}
}
