using IndieGameZone.Domain.Constants;

namespace IndieGameZone.Domain.Entities
{
	public class Transactions
	{
		public Guid Id { get; set; }
		public long OrderCode { get; set; }
		public double Amount { get; set; }
		public string Description { get; set; } = string.Empty;
		public TransactionStatus Status { get; set; }
		public TransactionType Type { get; set; }
		public DateTime CreatedAt { get; set; }
		public Guid UserId { get; set; }
		public Guid? GameId { get; set; }
		public Guid? CommercialPackageId { get; set; }

		// Navigation properties
		public virtual CommercialPackages? CommercialPackage { get; set; } = null!;
		public virtual Users User { get; set; } = null!;
		public virtual Games? Game { get; set; } = null!;
		public virtual WithdrawRequests WithdrawRequest { get; set; } = null!;
	}
}
