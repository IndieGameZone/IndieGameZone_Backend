namespace IndieGameZone.Domain.Entities
{
	public class Orders
	{
		public Guid Id { get; set; }
		public double Amount { get; set; }
		public Guid UserId { get; set; }
		public Guid? GameId { get; set; }
		public Guid? CommercialPackageId { get; set; }
		public Guid? ActivationKeyId { get; set; }
		public Guid? DiscountId { get; set; }
		public DateOnly? CommercialRegistrationStartDate { get; set; }
		public DateOnly? CommercialRegistrationEndDate { get; set; }
		public DateTime CreatedAt { get; set; }

		// Navigation properties
		public virtual Discounts? Discount { get; set; } = null;
		public virtual ActivationKeys? ActivationKey { get; set; } = null;
		public virtual Users User { get; set; } = null!;
		public virtual Games? Game { get; set; } = null!;
		public virtual CommercialPackages? CommercialPackage { get; set; } = null!;
		public virtual Transactions Transaction { get; set; } = null!;
	}
}
