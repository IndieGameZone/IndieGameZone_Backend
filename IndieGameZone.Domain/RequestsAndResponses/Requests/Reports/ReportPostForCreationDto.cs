namespace IndieGameZone.Domain.RequestsAndResponses.Requests.Reports
{
	public class ReportPostForCreationDto
	{
		public string Message { get; init; }
		public Guid PostId { get; init; }
		public Guid ReportReasonId { get; init; }
	}
}
