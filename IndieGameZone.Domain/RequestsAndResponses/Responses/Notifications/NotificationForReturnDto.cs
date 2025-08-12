namespace IndieGameZone.Domain.RequestsAndResponses.Responses.Notifications
{
	public class NotificationForReturnDto
	{
		public Guid Id { get; init; }
		public string Message { get; init; }
		public DateTime CreatedAt { get; init; }
		public DateTime? ReadAt { get; init; }
		public bool IsRead { get; init; }
	}
}
