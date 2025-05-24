using IndieGameZone.Domain.Entities;
using IndieGameZone.Domain.IRepositories;
using IndieGameZone.Domain.RequestFeatures;
using IndieGameZone.Infrastructure.Extensions;
using IndieGameZone.Infrastructure.Persistence;
using Microsoft.EntityFrameworkCore;

namespace IndieGameZone.Infrastructure.Repositories
{
	internal sealed class GameRepository : RepositoryBase<Games>, IGameRepository
	{
		public GameRepository(AppDbContext appDbContext) : base(appDbContext)
		{
		}

		public void CreateGame(Games game) => Create(game);

		public void DeleteGame(Games game) => Delete(game);

		public async Task<Games?> GetGameById(Guid id, bool trackChange, CancellationToken ct = default)
		{
			return await FindByCondition(x => x.Id.Equals(id), trackChange)
				.Include(x => x.Category).AsSplitQuery()
				.Include(x => x.AgeRestriction).AsSplitQuery()
				.Include(x => x.Developers).AsSplitQuery()
				.Include(x => x.GameStatus).AsSplitQuery()
				.Include(x => x.GamePlatforms).ThenInclude(x => x.Platform).AsSplitQuery()
				.Include(x => x.GameTags).ThenInclude(x => x.Tag).AsSplitQuery()
				.Include(x => x.GameLanguages).ThenInclude(x => x.Language).AsSplitQuery()
				.Include(x => x.GameInfos).AsSplitQuery()
				.FirstOrDefaultAsync(ct);
		}

		public async Task<PagedList<Games>> GetGames(GameParameters gameParameters, bool trackChange, CancellationToken ct = default)
		{
			var gameEntities = FindAll(trackChange)
				.Sort();

			return await PagedList<Games>.ToPagedList(gameEntities, gameParameters.PageNumber, gameParameters.PageSize, ct);

		}
	}
}
