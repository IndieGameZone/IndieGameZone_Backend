namespace IndieGameZone.Domain.RequestsAndResponses.Requests.Reports
{
	public class ReportGameForCreationDto
	{
		public string Message { get; init; }
		public Guid ReportReasonId { get; init; }
		public Guid GameId { get; init; }
	}
}
