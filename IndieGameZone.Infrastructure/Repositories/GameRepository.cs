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
				.Include(x => x.Category)
				.Include(x => x.AgeRestriction)
				.Include(x => x.Developers)
				.Include(x => x.GameStatus)
				.Include(x => x.GamePlatforms).ThenInclude(x => x.Platform)
				.Include(x => x.GameTags).ThenInclude(x => x.Tag)
				.Include(x => x.GameLanguages).ThenInclude(x => x.Language)
				.Include(x => x.GameInfos)
				.FirstOrDefaultAsync(ct);
		}

		public async Task<PagedList<Games>> GetGames(GameParameters gameParameters, bool trackChange, CancellationToken ct = default)
		{
			var gameEntities = FindAll(trackChange)
				.Sort()
				.Include(x => x.Category)
				.Include(x => x.GameTags).ThenInclude(x => x.Tag);

			return await PagedList<Games>.ToPagedList(gameEntities, gameParameters.PageNumber, gameParameters.PageSize, ct);

		}
	}
}
