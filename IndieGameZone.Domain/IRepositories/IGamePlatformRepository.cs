using IndieGameZone.Domain.Entities;

namespace IndieGameZone.Domain.IRepositories
{
	public interface IGamePlatformRepository
	{
		void CreateGamePlatform(IEnumerable<GamePlatforms> gamePlatforms);
		void DeleteGamePlatform(IEnumerable<GamePlatforms> gamePlatforms);
		Task<IEnumerable<GamePlatforms>> GetGamePlatformsByGameId(Guid gameId, bool trackChanges, CancellationToken ct = default);
		Task<GamePlatforms?> GetGamePlatformsById(Guid gamePlatformId, bool trackChanges, CancellationToken ct = default);
	}
}
