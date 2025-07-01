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
				.Sort();

			return await PagedList<Libraries>.ToPagedList(libraryEntities, libraryParameters.PageNumber, libraryParameters.PageSize, ct);
		}

		public IQueryable<Libraries> GetLibraryByUserId(Guid userId, bool trackChange) => FindByCondition(x => x.UserId == userId, trackChange);

		public async Task<Libraries?> GetLibraryByUserIdAndGameId(Guid userId, Guid gameId, bool trackChange, CancellationToken ct = default) => await
			FindByCondition(x => x.UserId == userId && x.GameId == gameId, trackChange)
			.FirstOrDefaultAsync(ct);
	}
}
