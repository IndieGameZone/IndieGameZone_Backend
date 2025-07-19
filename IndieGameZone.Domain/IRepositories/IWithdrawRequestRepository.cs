using IndieGameZone.Domain.Entities;
using IndieGameZone.Domain.RequestFeatures;

namespace IndieGameZone.Domain.IRepositories
{
	public interface IWithdrawRequestRepository
	{
		void CreateWithdrawRequest(WithdrawRequests withdrawRequest);
		Task<PagedList<WithdrawRequests>> GetWithdrawRequestsByUserId(Guid userId, WithdrawRequestParameter withdrawRequestParameter, bool trackChange, CancellationToken ct = default);
		Task<PagedList<WithdrawRequests>> GetWithdrawRequests(WithdrawRequestParameter withdrawRequestParameter, bool trackChange, CancellationToken ct = default);
		Task<WithdrawRequests?> GetWithdrawRequestById(Guid id, bool trackChange, CancellationToken ct = default);
	}
}
