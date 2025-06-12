namespace IndieGameZone.Domain.Entities
{
	public class GamePlatforms
	{
		public Guid Id { get; set; }
		public Guid GameId { get; set; }
		public Guid PlatformId { get; set; }
		public string DisplayName { get; set; } = string.Empty;
		public string File { get; set; } = string.Empty;
		public double Size { get; set; }

		// Navigation properties
		public virtual Games Game { get; set; } = null!;
		public virtual Platforms Platform { get; set; } = null!;
	}
}
