namespace IndieGameZone.Domain.Entities
{
	public class CommercialPackages
	{
		public Guid Id { get; set; }
		public string Name { get; set; } = string.Empty;
		public string Description { get; set; } = string.Empty;
		public double Duration { get; set; }
		public double Price { get; set; }

		//Navigation properties
		public ICollection<Transactions> Transactions { get; set; } = new List<Transactions>();
		public ICollection<CommercialRegistration> CommercialRegistrations { get; set; } = new List<CommercialRegistration>();
	}
}
