namespace IndieGameZone.Domain.Entities
{
	public class DownloadSlots
	{
		public Guid Id { get; set; }
		public Guid GameId { get; set; }
		public Guid UserId { get; set; }

		// Navigation properties
		public virtual Games Game { get; set; }
		public virtual Users User { get; set; }
	}
}
