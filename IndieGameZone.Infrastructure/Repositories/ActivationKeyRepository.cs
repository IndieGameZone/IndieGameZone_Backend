using IndieGameZone.Domain.Entities;
using IndieGameZone.Domain.IRepositories;
using IndieGameZone.Infrastructure.Persistence;
using Microsoft.EntityFrameworkCore;

namespace IndieGameZone.Infrastructure.Repositories
{
	internal sealed class ActivationKeyRepository : RepositoryBase<ActivationKeys>, IActivationKeyRepository
	{
		private readonly AppDbContext appDbContext;

		public ActivationKeyRepository(AppDbContext appDbContext) : base(appDbContext)
		{
			this.appDbContext = appDbContext;
		}

		public async Task CreateForDev(ActivationKeys activationKey)
		{
			await appDbContext.ActivationKeys
				.Where(x => x.GameId == activationKey.GameId && x.IsActive && x.IsCreatedByDev)
				.ExecuteUpdateAsync(x => x.SetProperty(y => y.IsActive, y => false));
			Create(activationKey);
		}

		public async Task CreateForModerator(ActivationKeys activationKey)
		{
			await appDbContext.ActivationKeys
				.Where(x => x.GameId == activationKey.GameId && x.IsActive && x.IsCreatedByModerator)
				.ExecuteUpdateAsync(x => x.SetProperty(y => y.IsActive, y => false));
			Create(activationKey);
		}

		public async Task<IEnumerable<ActivationKeys>> GetByGameId(Guid gameId, bool trackChange, CancellationToken ct = default)
		{
			var activationKey = await FindByCondition(x => x.GameId == gameId && !x.IsUsed && x.IsActive, trackChange)
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
