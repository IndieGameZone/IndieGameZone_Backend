using IndieGameZone.Domain.Constants;

namespace IndieGameZone.Domain.Entities
{
	public class CommercialPackages
	{
		public Guid Id { get; set; }
		public string Name { get; set; } = string.Empty;
		public string Description { get; set; } = string.Empty;
		public int Duration { get; set; }
		public double Price { get; set; }
		public CommercialPackageType Type { get; set; }
		public bool IsDeleted { get; set; }

		//Navigation properties
		public ICollection<CommercialRegistrations> CommercialRegistrations { get; set; } = new List<CommercialRegistrations>();
		public ICollection<Orders> Orders { get; set; } = new List<Orders>();
	}
}
