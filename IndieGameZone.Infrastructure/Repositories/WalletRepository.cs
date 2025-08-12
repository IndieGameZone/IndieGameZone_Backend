using IndieGameZone.Domain.Entities;
using IndieGameZone.Domain.IRepositories;
using IndieGameZone.Infrastructure.Persistence;
using Microsoft.EntityFrameworkCore;

namespace IndieGameZone.Infrastructure.Repositories
{
	internal sealed class WalletRepository : RepositoryBase<Wallets>, IWalletRepository
	{
		public WalletRepository(AppDbContext appDbContext) : base(appDbContext)
		{
		}

		public void CreateWallet(Wallets wallet) => Create(wallet);

		public async Task<Wallets?> GetWalletByUserId(Guid userId, bool trackChange, CancellationToken ct = default) => await
			FindByCondition(x => x.UserId == userId, trackChange)
			.FirstOrDefaultAsync(ct);

        public async Task<double> GetTotalBalanceByUserIdsAsync(IEnumerable<Guid> userIds, CancellationToken ct = default)
        {
            return await FindByCondition(w => userIds.Contains(w.UserId), false)
                .SumAsync(w => w.Balance, ct);
        }

    }
}
