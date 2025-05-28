namespace IndieGameZone.Domain.Entities
{
	public class GameImages
	{
		public Guid Id { get; set; }
		public string Image { get; set; } = string.Empty;
		public Guid GameId { get; set; }

		//Navigation properties
		public virtual Games Games { get; set; } = null!;
	}
}
