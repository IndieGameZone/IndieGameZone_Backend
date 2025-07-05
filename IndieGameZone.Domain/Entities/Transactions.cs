using IndieGameZone.Domain.Constants;

namespace IndieGameZone.Domain.Entities
{
	public class Transactions
	{
		public Guid Id { get; set; }
		public long OrderCode { get; set; }
		public double Amount { get; set; }
		public string Description { get; set; } = string.Empty;
		public PaymentMethod PaymentMethod { get; set; }
		public TransactionStatus Status { get; set; }
		public TransactionType Type { get; set; }
		public DateTime CreatedAt { get; set; }
		public Guid UserId { get; set; }
		public Guid PurchaseUserId { get; set; }
		public Guid? GameId { get; set; }
		public Guid? CommercialPackageId { get; set; }
		public DateOnly? CommercialRegistrationStartDate { get; set; }
		public DateOnly? CommercialRegistrationEndDate { get; set; }

		// Navigation properties
		public virtual Users User { get; set; } = null!;
		public virtual Users PurchaseUser { get; set; } = null!;
		public virtual Games? Game { get; set; } = null!;
		public virtual CommercialPackages? CommercialPackage { get; set; } = null!;
		public virtual WithdrawRequests? WithdrawRequest { get; set; } = null!;
		public virtual CommercialRegistration? CommercialRegistration { get; set; } = null!;
	}
}
