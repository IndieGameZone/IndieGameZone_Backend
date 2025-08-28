using IndieGameZone.Domain.Constants;
using IndieGameZone.Domain.Entities;
using IndieGameZone.Domain.IRepositories;
using IndieGameZone.Domain.RequestFeatures;
using IndieGameZone.Infrastructure.Extensions;
using IndieGameZone.Infrastructure.Persistence;
using Microsoft.EntityFrameworkCore;

namespace IndieGameZone.Infrastructure.Repositories
{
	internal sealed class LibraryRepository : RepositoryBase<Libraries>, ILibraryRepository
	{
		public LibraryRepository(AppDbContext appDbContext) : base(appDbContext)
		{
		}

		public void AddGameToLibrary(Libraries libraries) => Create(libraries);

		public async Task<PagedList<Libraries>> GetLibraryByUserId(Guid userId, LibraryParameters libraryParameters, bool trackChange, CancellationToken ct = default)
		{
			var libraryEntities = FindByCondition(x => x.UserId == userId, trackChange)
				.Include(x => x.Game).ThenInclude(x => x.GameTags).ThenInclude(x => x.Tag).AsSplitQuery()
				.Include(x => x.Game).ThenInclude(x => x.Category).AsSplitQuery()
				.Include(x => x.Game).ThenInclude(x => x.Reviews).AsSplitQuery()
				.Sort();

			return await PagedList<Libraries>.ToPagedList(libraryEntities, libraryParameters.PageNumber, libraryParameters.PageSize, ct);
		}

		public IQueryable<Libraries> GetLibraryByUserId(Guid userId, bool trackChange) => FindByCondition(x => x.UserId == userId, trackChange);

		public async Task<Libraries?> GetLibraryByUserIdAndGameId(Guid userId, Guid gameId, bool trackChange, CancellationToken ct = default) => await
			FindByCondition(x => x.UserId == userId && x.GameId == gameId, trackChange)
			.FirstOrDefaultAsync(ct);

		public async Task<IEnumerable<(Games game, int purchaseCount)>> GetTopSellingGames(int top = 10, CancellationToken ct = default)
		{
			var topGames = await AppDbContext.Libraries
				.Where(l => l.Game.Price > 0)
				.GroupBy(l => l.GameId)
				.Select(g => new
				{
					GameId = g.Key,
					PurchaseCount = g.Count()
				})
				.OrderByDescending(g => g.PurchaseCount)
				.Take(top)
				.ToListAsync(ct);

			var gameIds = topGames.Select(g => g.GameId).ToList();

			var games = await AppDbContext.Games
				.Where(g => gameIds.Contains(g.Id) &&
							g.Visibility == GameVisibility.Public &&
							g.CensorStatus == CensorStatus.Approved &&
							g.Price > 0)
				.Include(g => g.Category).AsSplitQuery()
				.Include(g => g.GameTags).ThenInclude(gt => gt.Tag).AsSplitQuery()
				.ToListAsync(ct);

			return games.Select(game => (
				game,
				purchaseCount: topGames.First(t => t.GameId == game.Id).PurchaseCount
			));
		}

		public async Task<IEnumerable<(Games game, int purchaseCount)>> GetTopSellingGamesByDeveloper(Guid developerId, int top = 10, CancellationToken ct = default)
		{
			var topGames = await AppDbContext.Libraries
				.Where(l => l.Game.DeveloperId == developerId)
				.GroupBy(l => l.GameId)
				.Select(g => new
				{
					GameId = g.Key,
					PurchaseCount = g.Count()
				})
				.OrderByDescending(g => g.PurchaseCount)
				.Take(top)
				.ToListAsync(ct);

			var gameIds = topGames.Select(g => g.GameId).ToList();

			var games = await AppDbContext.Games
				.Where(g =>
					gameIds.Contains(g.Id) &&
					g.DeveloperId == developerId &&
					g.Visibility == GameVisibility.Public &&
					g.CensorStatus == CensorStatus.Approved)
				.Include(g => g.Category).AsSplitQuery()
				.Include(g => g.GameTags).ThenInclude(gt => gt.Tag).AsSplitQuery()
				.ToListAsync(ct);

			return games.Select(game => (
				game,
				purchaseCount: topGames.First(t => t.GameId == game.Id).PurchaseCount
			));
		}

	}
}
