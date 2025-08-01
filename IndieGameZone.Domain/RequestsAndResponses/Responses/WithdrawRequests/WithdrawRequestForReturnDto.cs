using IndieGameZone.Domain.Constants;

namespace IndieGameZone.Domain.RequestsAndResponses.Responses.WithdrawRequests
{
	public class WithdrawRequestForReturnDto
	{
		public Guid Id { get; init; }
		public string? ImageProof { get; init; }
		public double Amount { get; init; }
		public WithdrawTransferStatus Status { get; init; }
		public string? RejectReason { get; init; } = null;
		public DateTime HandledAt { get; init; }
		public DateTime CreatedAt { get; init; }
	}
}
