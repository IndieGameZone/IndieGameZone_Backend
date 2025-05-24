using IndieGameZone.Domain.Entities;

namespace IndieGameZone.Domain.IRepositories
{
	public interface IGamePlatformRepository
	{
		void CreateGamePlatform(IEnumerable<GamePlatforms> gamePlatforms);
	}
}
