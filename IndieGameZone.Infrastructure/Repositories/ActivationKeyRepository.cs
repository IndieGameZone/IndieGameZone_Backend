using IndieGameZone.Domain.Entities;
using IndieGameZone.Domain.IRepositories;
using IndieGameZone.Infrastructure.Persistence;
using Microsoft.EntityFrameworkCore;

namespace IndieGameZone.Infrastructure.Repositories
{
	internal sealed class ActivationKeyRepository : RepositoryBase<ActivationKeys>, IActivationKeyRepository
	{
		public ActivationKeyRepository(AppDbContext appDbContext) : base(appDbContext)
		{
		}

		public async Task<IEnumerable<ActivationKeys>> GetByGameId(Guid gameId, bool trackChange, CancellationToken ct = default)
		{
			var activationKey = await FindByCondition(x => x.GameId == gameId && !x.IsUsed, trackChange)
				.ToListAsync(ct);
			return activationKey;
		}

		public Task<ActivationKeys?> GetByKey(string key, bool trackChange, CancellationToken ct = default)
		{
			var activationKey = FindByCondition(x => x.Key == key, trackChange)
				.FirstOrDefaultAsync(ct);
			return activationKey;
		}
	}
}
