namespace IndieGameZone.Domain.Entities
{
	public class Languages
	{
		public Guid Id { get; set; }
		public string Name { get; set; } = string.Empty;
		public bool IsDeleted { get; set; }

		// Navigation properties
		public virtual ICollection<GameLanguages> GameLanguages { get; set; } = new List<GameLanguages>();
	}
}
