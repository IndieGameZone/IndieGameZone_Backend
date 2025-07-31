using IndieGameZone.Domain.Constants;

namespace IndieGameZone.Domain.RequestsAndResponses.Requests.WithdrawRequests
{
	public class WithdrawRequestForUpdateDto
	{
		public string? ImageProof { get; init; }
		public WithdrawTransferStatus Status { get; init; }
		public string? RejectReason { get; init; }
	}
}
