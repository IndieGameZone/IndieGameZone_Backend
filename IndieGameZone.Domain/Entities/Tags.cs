namespace IndieGameZone.Domain.Entities
{
	public class Tags
	{
		public Guid Id { get; set; }
		public string Name { get; set; } = string.Empty;

		// Navigation property
		public ICollection<GameTags> GameTags { get; set; } = new List<GameTags>();
		public ICollection<Posts> Posts { get; set; } = new List<Posts>();
	}
}
