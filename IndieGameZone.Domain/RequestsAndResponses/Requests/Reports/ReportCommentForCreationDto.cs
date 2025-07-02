namespace IndieGameZone.Domain.RequestsAndResponses.Requests.Reports
{
	public class ReportCommentForCreationDto
	{
		public string Message { get; init; }
		public Guid ReportReasonId { get; init; }
		public Guid CommentId { get; init; }
	}
}
