namespace IndieGameZone.Domain.Entities
{
	public class GamePriceLogs
	{
		public Guid Id { get; set; }
		public Guid GameId { get; set; }
		public double Price { get; set; }
		public DateTime CreatedAt { get; set; }

		// Navigation properties
		public Games Game { get; set; }
	}
}
