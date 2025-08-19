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

		public Task<ActivationKeys?> GetByGamePlatformId(Guid gamePlatformId, bool trackChange, CancellationToken ct = default)
		{
			var activationKey = FindByCondition(x => x.GamePlatformId == gamePlatformId && !x.IsUsed, trackChange)
				.FirstOrDefaultAsync(ct);
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
