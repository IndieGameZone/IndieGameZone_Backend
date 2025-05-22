namespace IndieGameZone.Domain.Entities
{
	public class GameTags
	{
		public Guid GameId { get; set; }
		public Guid TagId { get; set; }

		// Navigation properties
		public virtual Games Game { get; set; } = null!;
		public virtual Tags Tag { get; set; } = null!;
	}
}
