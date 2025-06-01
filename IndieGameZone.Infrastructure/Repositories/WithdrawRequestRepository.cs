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

		public async Task<WithdrawRequests?> GetWithdrawRequestByTransactionId(Guid transactionId, bool trackChange, CancellationToken ct = default) => await FindByCondition(w => w.TransactionId == transactionId, trackChange)
			.FirstOrDefaultAsync(ct);

		public async Task<PagedList<WithdrawRequests>> GetWithdrawRequests(WithdrawRequestParameter withdrawRequestParameter, bool trackChange, CancellationToken ct = default)
		{
			var withdrawRequests = FindAll(trackChange)
				.Sort();

			return await PagedList<WithdrawRequests>.ToPagedList(withdrawRequests, withdrawRequestParameter.PageNumber, withdrawRequestParameter.PageSize, ct);
		}

		public Task<PagedList<WithdrawRequests>> GetWithdrawRequestsByUserId(Guid userId, WithdrawRequestParameter withdrawRequestParameter, bool trackChange, CancellationToken ct = default)
		{
			var withdrawRequests = FindAll(trackChange)
				.Include(w => w.Transaction).Where(w => w.Transaction.UserId == userId)
				.Sort();
			return PagedList<WithdrawRequests>.ToPagedList(withdrawRequests, withdrawRequestParameter.PageNumber, withdrawRequestParameter.PageSize, ct);
		}
	}
}
