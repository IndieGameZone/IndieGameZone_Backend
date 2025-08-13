using IndieGameZone.Domain.Entities;
using IndieGameZone.Domain.IRepositories;
using IndieGameZone.Domain.RequestFeatures;
using IndieGameZone.Infrastructure.Extensions;
using IndieGameZone.Infrastructure.Persistence;
using Microsoft.EntityFrameworkCore;

namespace IndieGameZone.Infrastructure.Repositories
{
	internal sealed class WithdrawRequestRepository : RepositoryBase<WithdrawRequests>, IWithdrawRequestRepository
	{
		public WithdrawRequestRepository(AppDbContext appDbContext) : base(appDbContext)
		{
		}

		public void CreateWithdrawRequest(WithdrawRequests withdrawRequest) => Create(withdrawRequest);

		public async Task<WithdrawRequests?> GetWithdrawRequestById(Guid id, bool trackChange, CancellationToken ct = default) => await FindByCondition(w => w.Id == id, trackChange)
			.FirstOrDefaultAsync(ct);

		public async Task<PagedList<WithdrawRequests>> GetWithdrawRequests(WithdrawRequestParameter withdrawRequestParameter, bool trackChange, CancellationToken ct = default)
		{
			var withdrawRequests = FindAll(trackChange)
				.Include(w => w.User).ThenInclude(u => u.UserProfile)
				.Include(w => w.User).ThenInclude(u => u.Wallet)
				.Sort();

			return await PagedList<WithdrawRequests>.ToPagedList(withdrawRequests, withdrawRequestParameter.PageNumber, withdrawRequestParameter.PageSize, ct);
		}

		public async Task<PagedList<WithdrawRequests>> GetWithdrawRequestsByUserId(Guid userId, WithdrawRequestParameter withdrawRequestParameter, bool trackChange, CancellationToken ct = default)
		{
			var withdrawRequests = FindByCondition(w => w.UserId == userId, trackChange)
				.Include(w => w.User).ThenInclude(u => u.UserProfile)
				.Include(w => w.User).ThenInclude(u => u.Wallet)
				.Sort();
			return await PagedList<WithdrawRequests>.ToPagedList(withdrawRequests, withdrawRequestParameter.PageNumber, withdrawRequestParameter.PageSize, ct);
		}
	}
}
