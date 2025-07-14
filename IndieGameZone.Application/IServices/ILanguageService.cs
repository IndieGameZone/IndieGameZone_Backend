using IndieGameZone.Domain.RequestsAndResponses.Requests.Languages;
using IndieGameZone.Domain.RequestsAndResponses.Responses.Languages;

namespace IndieGameZone.Application.IServices
{
	public interface ILanguageService
	{
		Task CreateLanguage(LanguageForCreationDto languageForCreationDto, CancellationToken ct = default);
		Task UpdateLanguage(Guid id, LanguageForUpdateDto languageForUpdateDto, CancellationToken ct = default);
		Task DeleteLanguage(Guid id, CancellationToken ct = default);
		Task<LanguageForReturnDto> GetLanguageById(Guid id, CancellationToken ct = default);
		Task<IEnumerable<LanguageForReturnDto>> GetLanguages(CancellationToken ct = default);
	}
}
