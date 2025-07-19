namespace IndieGameZone.Domain.Entities
{
	public class WithdrawRequests
	{
		public Guid Id { get; set; }
		public string ImageProof { get; set; } = string.Empty;
		public bool IsTransfered { get; set; }
		public DateTime CreatedAt { get; set; }
		public Guid UserId { get; set; }


		// Navigation properties
		public virtual Users User { get; set; } = null!;
	}
}
