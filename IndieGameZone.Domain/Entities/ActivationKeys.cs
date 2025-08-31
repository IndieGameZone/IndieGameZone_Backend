namespace IndieGameZone.Domain.Entities
{
	public class ActivationKeys
	{
		public Guid Id { get; set; }
		public string Key { get; set; } = string.Empty;
		public bool IsUsed { get; set; }
		public bool IsActive { get; set; }
		public bool IsCreatedByModerator { get; set; }
		public bool IsCreatedByDev { get; set; }
		public DateTime CreatedAt { get; set; }
		public Guid GameId { get; set; }

		// Navigation properties
		public Games Game { get; set; }
		public Orders? Order { get; set; }
	}
}
