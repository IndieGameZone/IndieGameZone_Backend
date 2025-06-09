namespace IndieGameZone.Domain.RequestsAndResponses.Requests.Reports
{
	public class ReportForCreationDto
	{
		public string Message { get; init; }
		public Guid? ReportedUserId { get; init; }
		public Guid? PostId { get; init; }
		public Guid ReportReasonId { get; init; }
		public Guid? GameId { get; init; }
		public Guid? CommentId { get; init; }
	}
}
