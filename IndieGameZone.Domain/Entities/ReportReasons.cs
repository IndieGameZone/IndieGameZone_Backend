using IndieGameZone.Domain.Constants;

namespace IndieGameZone.Domain.Entities
{
	public class ReportReasons
	{
		public Guid Id { get; set; }
		public string Name { get; set; } = string.Empty;
		public ReportReasonTypeEnum Type { get; set; }

		//Navigation properties
		public virtual ICollection<Reports> Reports { get; set; } = new List<Reports>();
	}
}
