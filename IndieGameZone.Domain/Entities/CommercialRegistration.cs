namespace IndieGameZone.Domain.Entities
{
	public class CommercialRegistration
	{
		public Guid Id { get; set; }
		public DateTime StartDate { get; set; }
		public DateTime EndDate { get; set; }
		public Guid GameId { get; set; }
		public Guid CommercialPackageId { get; set; }

		//Navigation properties
		public Games Game { get; set; } = null!;
		public CommercialPackages CommercialPackage { get; set; } = null!;
	}
}
