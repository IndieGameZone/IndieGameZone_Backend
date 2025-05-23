using IndieGameZone.Domain.Entities;

namespace IndieGameZone.Domain.IRepositories
{
	public interface ILanguageRepository
	{
		Task<IEnumerable<Languages>> GetLanguages(bool trackChange, CancellationToken ct = default);
		Task<Languages?> GetLanguageById(Guid id, bool trackChange, CancellationToken ct = default);
		void CreateLanguage(Languages language);
		void DeleteLanguage(Languages language);

	}
}
