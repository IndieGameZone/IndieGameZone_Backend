using IndieGameZone.Domain.Entities;
using IndieGameZone.Domain.IRepositories;
using IndieGameZone.Infrastructure.Extensions;
using IndieGameZone.Infrastructure.Persistence;
using Microsoft.EntityFrameworkCore;

namespace IndieGameZone.Infrastructure.Repositories
{
	internal sealed class PlatformRepository : RepositoryBase<Platforms>, IPlatformRepository
	{
		public PlatformRepository(AppDbContext appDbContext) : base(appDbContext)
		{
		}

		public void CreatePlatform(Platforms platform) => Create(platform);

		public void DeletePlatform(Platforms platform) => Delete(platform);

		public async Task<Platforms?> GetPlatformById(Guid id, bool trackChange, CancellationToken ct = default) => await FindByCondition(x => x.Id == id, trackChange)
			.FirstOrDefaultAsync(ct);

		public async Task<IEnumerable<Platforms>> GetPlatforms(bool trackChange, CancellationToken ct = default)
		{
			return await FindAll(trackChange)
				.Sort()
				.ToListAsync(ct);
		}
	}
}
