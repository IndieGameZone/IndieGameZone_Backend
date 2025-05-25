using IndieGameZone.Domain.Entities;

namespace IndieGameZone.Domain.IRepositories
{
	public interface IGameLanguageRepository
	{
		void CreateGameLanguage(IEnumerable<GameLanguages> gameLanguages);
		void DeleteGameLanguage(IEnumerable<GameLanguages> gameLanguages);
		Task<IEnumerable<GameLanguages>> GetGameLanguagesByGameId(Guid gameId, bool trackChanges, CancellationToken ct = default);
	}
}
