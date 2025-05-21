namespace IndieGameZone.Domain.Entities
{
	public class Reviews
	{
		public Guid Id { get; set; }
		public double Rating { get; set; }
		public string Comment { get; set; } = string.Empty;
		public DateTime CreatedAt { get; set; }
		public Guid UserId { get; set; }
		public Guid GameId { get; set; }

		//Navigation properties
		public Users User { get; set; } = null!;
		public Games Game { get; set; } = null!;
	}
}
