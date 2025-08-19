namespace IndieGameZone.Domain.Entities
{
	public class ActivationKeys
	{
		public Guid Id { get; set; }
		public string Key { get; set; } = string.Empty;
		public bool IsUsed { get; set; }
		public DateTime CreatedAt { get; set; }
		public Guid GamePlatformId { get; set; }

		// Navigation properties
		public GamePlatforms GamePlatform { get; set; }
	}
}
