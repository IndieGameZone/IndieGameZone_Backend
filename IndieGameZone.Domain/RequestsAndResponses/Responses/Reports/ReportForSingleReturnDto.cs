namespace IndieGameZone.Domain.RequestsAndResponses.Responses.Reports
{
	public class ReportForSingleReturnDto
	{
		public Guid Id { get; init; }
		public string Message { get; init; }
		public DateTime CreatedAt { get; init; }
		public Guid ReportingUserId { get; init; }
		public Guid? ReportedUserId { get; init; }
		public Guid? PostId { get; init; }
		public Guid ReportReasonId { get; init; }
		public Guid? GameId { get; init; }
		public Guid? CommentId { get; init; }
	}
}
