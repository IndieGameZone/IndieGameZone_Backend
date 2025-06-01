namespace IndieGameZone.Domain.RequestsAndResponses.Responses.WithdrawRequests
{
	public class WithdrawRequestForReturnDto
	{
		public Guid TransactionId { get; init; }
		public string ImageProof { get; init; }
		public bool IsTransfered { get; init; }
		public DateTime CreatedAt { get; init; }
	}
}
