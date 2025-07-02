using IndieGameZone.Domain.Constants;
using IndieGameZone.Domain.Entities;
using IndieGameZone.Domain.IRepositories;
using IndieGameZone.Domain.RequestFeatures;
using IndieGameZone.Infrastructure.Extensions;
using IndieGameZone.Infrastructure.Persistence;
using Microsoft.EntityFrameworkCore;
using System;

namespace IndieGameZone.Infrastructure.Repositories
{
	internal sealed class GameRepository : RepositoryBase<Games>, IGameRepository
	{
		public GameRepository(AppDbContext appDbContext) : base(appDbContext)
		{
		}

		public void CreateGame(Games game) => Create(game);

		public void DeleteGame(Games game) => Delete(game);

		public async Task<PagedList<Games>> GetActiveGames(ActiveGameParameters activeGameParameters, bool trackChange, CancellationToken ct = default)
		{
			var gameEntities = FindByCondition(g => g.Visibility == GameVisibility.Public && g.CensorStatus == CensorStatus.Approved, trackChange)
				.Search(activeGameParameters.SearchTerm)
				.FilterByPrice(activeGameParameters.Price)
				.Include(x => x.Discounts).AsSplitQuery()
				.Include(x => x.GameTags).ThenInclude(x => x.Tag).FilterByTags(activeGameParameters.Tags).AsSplitQuery()
				.Include(x => x.GamePlatforms).FilterByPlatform(activeGameParameters.Platforms).AsSplitQuery()
				.Include(x => x.GameLanguages).FilterByLanguages(activeGameParameters.Languages).AsSplitQuery()
				.Include(x => x.Category).AsSplitQuery()
				.Sort();

			return await PagedList<Games>.ToPagedList(gameEntities, activeGameParameters.PageNumber, activeGameParameters.PageSize, ct);
		}

		public async Task<IEnumerable<Games>> GetActiveGames(bool trackChange, CancellationToken ct = default)
		{
			return await FindByCondition(g => g.Visibility == GameVisibility.Public && g.CensorStatus == CensorStatus.Approved, trackChange)
				.Include(x => x.GameTags).ThenInclude(x => x.Tag).AsSplitQuery()
				.Include(x => x.Category).AsSplitQuery()
				.Sort().ToListAsync();
		}

		public async Task<PagedList<Games>> GetActiveGamesByDeveloperId(Guid developerId, ActiveGameParameters activeGameParameters, bool trackChange, CancellationToken ct = default)
		{
			var gameEntities = FindByCondition(g => g.DeveloperId == developerId && g.Visibility == GameVisibility.Public && g.CensorStatus == CensorStatus.Approved, trackChange)
				.Search(activeGameParameters.SearchTerm)
				.FilterByPrice(activeGameParameters.Price)
				.Include(x => x.Discounts).AsSplitQuery()
				.Include(x => x.GameTags).ThenInclude(x => x.Tag).FilterByTags(activeGameParameters.Tags).AsSplitQuery()
				.Include(x => x.GamePlatforms).FilterByPlatform(activeGameParameters.Platforms).AsSplitQuery()
				.Include(x => x.GameLanguages).FilterByLanguages(activeGameParameters.Languages).AsSplitQuery()
				.Include(x => x.Category).AsSplitQuery()
				.Sort();

			return await PagedList<Games>.ToPagedList(gameEntities, activeGameParameters.PageNumber, activeGameParameters.PageSize, ct);
		}

		public async Task<Games?> GetGameById(Guid id, bool trackChange, CancellationToken ct = default)
		{
			return await FindByCondition(x => x.Id.Equals(id), trackChange)
				.Include(x => x.Category).AsSplitQuery()
				.Include(x => x.AgeRestriction).AsSplitQuery()
				.Include(x => x.Developer).ThenInclude(x => x.UserProfile).AsSplitQuery()
				.Include(x => x.GamePlatforms).ThenInclude(x => x.Platform).AsSplitQuery()
				.Include(x => x.GameTags).ThenInclude(x => x.Tag).AsSplitQuery()
				.Include(x => x.GameLanguages).ThenInclude(x => x.Language).AsSplitQuery()
				.Include(x => x.GameImages).AsSplitQuery()
				.Include(x => x.Discounts).AsSplitQuery()
				.FirstOrDefaultAsync(ct);
		}

		public async Task<PagedList<Games>> GetGames(GameParameters gameParameters, bool trackChange, CancellationToken ct = default)
		{
			var gameEntities = FindAll(trackChange)
				.FilterByCensorStatus(gameParameters.CensorStatus)
				.Search(gameParameters.SearchTerm)
				.Include(x => x.Discounts).AsSplitQuery()
				.Include(x => x.GameTags).ThenInclude(x => x.Tag).AsSplitQuery()
				.Include(x => x.Category).AsSplitQuery()
				.Sort();

			return await PagedList<Games>.ToPagedList(gameEntities, gameParameters.PageNumber, gameParameters.PageSize, ct);

		}

		public IQueryable<Games> GetGames(bool trackChange) => FindAll(trackChange);

		public IQueryable<Games> GetGamesBasedOnCensorStatus(CensorStatus censorStatus, bool trackChange) =>
			FindByCondition(g => g.CensorStatus == censorStatus, trackChange);

		public async Task<PagedList<Games>> GetGamesByDeveloperId(Guid developerId, GameParameters gameParameters, bool trackChange, CancellationToken ct = default)
		{
			var gameEntities = FindByCondition(g => g.DeveloperId == developerId, trackChange)
				.FilterByCensorStatus(gameParameters.CensorStatus)
				.Search(gameParameters.SearchTerm)
				.Include(x => x.Discounts).AsSplitQuery()
				.Include(x => x.GameTags).ThenInclude(x => x.Tag).AsSplitQuery()
				.Include(x => x.Category).AsSplitQuery()
				.Sort();

			return await PagedList<Games>.ToPagedList(gameEntities, gameParameters.PageNumber, gameParameters.PageSize, ct);
		}

        public async Task<IEnumerable<Games>> GetTopDownloadedGames(int top, bool trackChange, CancellationToken ct = default)
        {
            return await FindByCondition(g => g.Visibility == GameVisibility.Public && g.CensorStatus == CensorStatus.Approved, trackChange)
                .OrderByDescending(g => g.NumberOfDownloads)
                .Take(top)
                .Include(g => g.Category).AsSplitQuery()
                .Include(g => g.GameTags).ThenInclude(gt => gt.Tag).AsSplitQuery()
                .ToListAsync(ct);
        }

        public async Task<IEnumerable<(Games game, double averageRating)>> GetTopRatedGames(int top = 10, bool trackChange = false, CancellationToken ct = default)
        {
            var gameRatings = await AppDbContext.Reviews
                .GroupBy(r => r.GameId)
                .Select(g => new
                {
                    GameId = g.Key,
                    AverageRating = g.Average(r => r.Rating)
                })
                .OrderByDescending(g => g.AverageRating)
                .Take(top)
                .ToListAsync(ct);

            var gameIds = gameRatings.Select(x => x.GameId).ToList();

            var games = await AppDbContext.Games
                .Where(g => gameIds.Contains(g.Id) && g.Visibility == GameVisibility.Public && g.CensorStatus == CensorStatus.Approved)
                .Include(g => g.Category).AsSplitQuery()
                .Include(g => g.GameTags).ThenInclude(gt => gt.Tag).AsSplitQuery()
                .ToListAsync(ct);

            return games.Select(g => (
                g,
                averageRating: gameRatings.First(x => x.GameId == g.Id).AverageRating
            ));
        }

        public async Task<IEnumerable<Games>> GetRecentlyPublishedGames(int top = 10, bool trackChange = false, CancellationToken ct = default)
        {
            return await AppDbContext.Games
                .Where(g => g.Visibility == GameVisibility.Public && g.CensorStatus == CensorStatus.Approved)
                .OrderByDescending(g => g.CreatedAt)
                .Include(g => g.Category).AsSplitQuery()
                .Include(g => g.GameTags).ThenInclude(gt => gt.Tag).AsSplitQuery()
                .Take(top)
                .ToListAsync(ct);
        }

    }
}
