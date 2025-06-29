namespace IndieGameZone.Domain.Entities
{
	public class CommercialRegistration
	{
		public Guid Id { get; set; }
		public DateOnly StartDate { get; set; }
		public DateOnly? EndDate { get; set; }
		public Guid GameId { get; set; }
		public Guid CommercialPackageId { get; set; }

		//Navigation properties
		public Transactions Transaction { get; set; }
		public Games Game { get; set; }
		public CommercialPackages CommercialPackage { get; set; }
	}
}
