namespace IndieGameZone.Domain.Entities
{
	public class Languages
	{
		public Guid Id { get; set; }
		public string Name { get; set; } = string.Empty;

		// Navigation properties
		public virtual ICollection<GameLanguages> GameLanguages { get; set; } = new List<GameLanguages>();
	}
}
