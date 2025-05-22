namespace IndieGameZone.Domain.Entities
{
	public class GameInfos
	{
		public Guid Id { get; set; }
		public string? Image { get; set; } = string.Empty;
		public string? Title { get; set; } = string.Empty;
		public string? Description { get; set; } = string.Empty;
		public Guid GameId { get; set; }

		//Navigation properties
		public virtual Games Games { get; set; } = null!;
	}
}
