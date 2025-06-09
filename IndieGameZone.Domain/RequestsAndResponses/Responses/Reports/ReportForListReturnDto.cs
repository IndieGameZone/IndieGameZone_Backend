namespace IndieGameZone.Domain.RequestsAndResponses.Responses.Reports
{
	public class ReportForListReturnDto
	{
		public Guid Id { get; init; }
		public DateTime CreatedAt { get; init; }
		public Guid ReportReasonId { get; init; }
	}
}
