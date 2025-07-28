using IndieGameZone.Domain.Constants;

namespace IndieGameZone.Domain.Entities
{
	public class CommercialRegistrations
	{
		public Guid Id { get; set; }
		public DateOnly StartDate { get; set; }
		public DateOnly? EndDate { get; set; }
		public DateTime? CreatedAt { get; set; } = DateTime.Now;
		public CommercialRegistrationStatus? Status { get; set; } = CommercialRegistrationStatus.Pending;
        public Guid GameId { get; set; }
		public Guid CommercialPackageId { get; set; }

		//Navigation properties
		public Games Game { get; set; }
		public CommercialPackages CommercialPackage { get; set; }

	}
}
