namespace IndieGameZone.Domain.Entities
{
	public class WithdrawRequests
	{
		public Guid TransactionId { get; set; }
		public string ImageProof { get; set; } = string.Empty;
		public DateTime CreatedAt { get; set; }


		// Navigation properties
		public virtual Transactions Transaction { get; set; } = null!;
	}
}
