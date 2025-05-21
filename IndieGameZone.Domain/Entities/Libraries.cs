namespace IndieGameZone.Domain.Entities
{
	public class Libraries
	{
		public Guid UserId { get; set; }
		public Guid GameId { get; set; }
		public DateTime PurchasedAt { get; set; }

		//Navigation properties
		public virtual Users User { get; set; } = null!;
		public virtual Games Game { get; set; } = null!;
	}
}
