using IndieGameZone.Domain.Constants;
using IndieGameZone.Domain.Entities;
using IndieGameZone.Domain.RequestFeatures;

namespace IndieGameZone.Domain.IRepositories
{
	public interface IGameRepository
	{
		Task<PagedList<Games>> GetGames(GameParameters gameParameters, bool trackChange, CancellationToken ct = default);
		Task<PagedList<Games>> GetActiveGames(ActiveGameParameters activeGameParameters, bool trackChange, CancellationToken ct = default);
		Task<IEnumerable<Games>> GetActiveGames(bool trackChange, CancellationToken ct = default);
		Task<PagedList<Games>> GetGamesByDeveloperId(Guid developerId, GameParameters gameParameters, bool trackChange, CancellationToken ct = default);
		Task<PagedList<Games>> GetActiveGamesByDeveloperId(Guid developerId, ActiveGameParameters activeGameParameters, bool trackChange, CancellationToken ct = default);
		Task<Games?> GetGameById(Guid id, bool trackChange, CancellationToken ct = default);
		Task<Games?> GetGameByIdWithActiveFile(Guid id, bool trackChange, CancellationToken ct = default);
		void CreateGame(Games game);
		void DeleteGame(Games game);
		IQueryable<Games> GetGamesBasedOnCensorStatus(CensorStatus censorStatus, bool trackChange);
		IQueryable<Games> GetGames(bool trackChange);
		Task<IEnumerable<Games>> GetTopDownloadedGames(int top, bool trackChange, CancellationToken ct = default);
		Task<IEnumerable<(Games game, double averageRating)>> GetTopRatedGames(int top = 10, bool trackChange = false, CancellationToken ct = default);
		Task<IEnumerable<Games>> GetRecentlyPublishedGames(int top = 10, bool trackChange = false, CancellationToken ct = default);

	}
}
