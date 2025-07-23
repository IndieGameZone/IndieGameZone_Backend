namespace IndieGameZone.Domain.Entities
{
	public class AgeRestrictions
	{
		public Guid Id { get; set; }
		public string Code { get; set; } = string.Empty;
		public string Description { get; set; } = string.Empty;
		public bool IsDeleted { get; set; }

		//Navigation properties
		public virtual ICollection<Games> Games { get; set; } = new HashSet<Games>();
	}
}
