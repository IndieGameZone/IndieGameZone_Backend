using IndieGameZone.Domain.RequestFeatures;
using IndieGameZone.Domain.RequestsAndResponses.Requests.WithdrawRequests;
using IndieGameZone.Domain.RequestsAndResponses.Responses.WithdrawRequests;
using Microsoft.AspNetCore.Http;

namespace IndieGameZone.Application.IServices
{
	public interface IWithdrawRequestService
	{
		Task CreateWithdrawRequest(Guid userId, WithdrawRequestForCreationDto withdrawRequestForCreationDto, CancellationToken ct = default);
		Task<(IEnumerable<WithdrawRequestForReturnDto> withdrawRequests, MetaData metaData)> GetWithdrawRequestsByUserId(Guid userId, WithdrawRequestParameter withdrawRequestParameter, CancellationToken ct = default);
		Task<(IEnumerable<WithdrawRequestForReturnDto> withdrawRequests, MetaData metaData)> GetWithdrawRequests(WithdrawRequestParameter withdrawRequestParameter, CancellationToken ct = default);
		Task UpdateWithdrawRequest(Guid id, IFormFile imageProof, CancellationToken ct = default);
	}
}
