using IndieGameZone.Domain.Constants;

namespace IndieGameZone.Domain.Entities
{
	public class WithdrawRequests
	{
		public Guid Id { get; set; }
		public string? ImageProof { get; set; }
		public double Amount { get; set; }
		public WithdrawTransferStatus Status { get; set; }
		public string? RejectReason { get; set; } = null;
		public DateTime? HandledAt { get; set; }
		public DateTime CreatedAt { get; set; }
		public Guid UserId { get; set; }


		// Navigation properties
		public virtual Users User { get; set; } = null!;
	}
}
