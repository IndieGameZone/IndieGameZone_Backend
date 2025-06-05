namespace IndieGameZone.Domain.Entities
{
	public class ReportReasons
	{
		public Guid Id { get; set; }
		public string Name { get; set; } = string.Empty;

		//Navigation properties
		public virtual ICollection<Reports> Reports { get; set; } = new HashSet<Reports>();
	}
}
