using IndieGameZone.Domain.Entities;

namespace IndieGameZone.Domain.IRepositories
{
	public interface IGameImageRepository
	{
		void CreateGameImage(IEnumerable<GameImages> gameImages);
		void DeleteGameImage(IEnumerable<GameImages> gameImages);
		Task<IEnumerable<GameImages>> GetGameImagesByGameId(Guid gameId, bool trackChanges, CancellationToken ct = default);
	}
}
