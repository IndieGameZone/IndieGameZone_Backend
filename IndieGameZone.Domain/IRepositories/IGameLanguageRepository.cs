using IndieGameZone.Domain.Entities;

namespace IndieGameZone.Domain.IRepositories
{
	public interface IGameLanguageRepository
	{
		void CreateGameLanguage(IEnumerable<GameLanguages> gameLanguages);
	}
}
