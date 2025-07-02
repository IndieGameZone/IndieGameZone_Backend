using IndieGameZone.Domain.Entities;
using IndieGameZone.Domain.RequestFeatures;

namespace IndieGameZone.Domain.IRepositories
{
	public interface ILibraryRepository
	{
		void AddGameToLibrary(Libraries libraries);
		Task<PagedList<Libraries>> GetLibraryByUserId(Guid userId, LibraryParameters libraryParameters, bool trackChange, CancellationToken ct = default);
		IQueryable<Libraries> GetLibraryByUserId(Guid userId, bool trackChange);
		Task<Libraries?> GetLibraryByUserIdAndGameId(Guid userId, Guid gameId, bool trackChange, CancellationToken ct = default);
        Task<IEnumerable<(Games game, int purchaseCount)>> GetTopSellingGames(int top = 10, CancellationToken ct = default);

    }
}
