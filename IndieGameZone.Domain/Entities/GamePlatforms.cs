namespace IndieGameZone.Domain.Entities
{
	public class GamePlatforms
	{
		public Guid GameId { get; set; }
		public Guid PlatformId { get; set; }
		public string File { get; set; } = string.Empty;

		// Navigation properties
		public virtual Games Game { get; set; } = null!;
		public virtual Platforms Platform { get; set; } = null!;
	}
}
