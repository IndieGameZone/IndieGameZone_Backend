using IndieGameZone.Domain.RequestFeatures;
using IndieGameZone.Domain.RequestsAndResponses.Responses.Libraries;

namespace IndieGameZone.Application.IServices
{
	public interface ILibraryService
	{
		Task<(IEnumerable<LibraryForReturnDto> libraries, MetaData metaData)> GetLibrariesByUserId(Guid userId, LibraryParameters libraryParameters, CancellationToken ct = default);
	}
}
