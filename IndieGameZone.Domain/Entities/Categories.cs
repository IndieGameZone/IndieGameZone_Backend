namespace IndieGameZone.Domain.Entities
{
	public class Categories
	{
		public Guid Id { get; set; }
		public string Name { get; set; } = string.Empty;

		// Navigation property
		public virtual ICollection<Games> Games { get; set; } = new HashSet<Games>();
	}
}
