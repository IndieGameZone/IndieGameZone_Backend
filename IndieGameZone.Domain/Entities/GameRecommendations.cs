namespace IndieGameZone.Domain.Entities
{
	public class GameRecommendations
	{
		public Guid UserId { get; set; }
		public Guid GameId { get; set; }

		// Navigation properties
		public Users User { get; set; } = null!;
		public Games Game { get; set; } = null!;
	}
}
