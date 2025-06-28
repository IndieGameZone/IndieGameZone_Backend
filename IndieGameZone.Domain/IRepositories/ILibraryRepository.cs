using IndieGameZone.Domain.Entities;
using IndieGameZone.Domain.RequestFeatures;

namespace IndieGameZone.Domain.IRepositories
{
	public interface ILibraryRepository
	{
		void AddGameToLibrary(Libraries libraries);
		Task<PagedList<Libraries>> GetLibraryByUserId(Guid userId, LibraryParameters libraryParameters, bool trackChange, CancellationToken ct = default);
		IQueryable<Libraries> GetLibraryByUserId(Guid userId, bool trackChange);
	}
}
