namespace IndieGameZone.Domain.Entities
{
	public class Notifications
	{
		public Guid Id { get; set; }
		public string Message { get; set; } = string.Empty;
		public DateTime CreatedAt { get; set; }
		public DateTime? ReadAt { get; set; }
		public bool IsRead { get; set; }
		public Guid UserId { get; set; }


		//Navigation properties
		public Users User { get; set; } = null!;
	}
}
