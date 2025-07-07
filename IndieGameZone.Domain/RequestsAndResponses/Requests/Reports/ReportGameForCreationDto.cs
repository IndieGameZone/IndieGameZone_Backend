using System.ComponentModel.DataAnnotations;

namespace IndieGameZone.Domain.RequestsAndResponses.Requests.Reports
{
	public class ReportGameForCreationDto
	{
		[Required]
		public string Message { get; init; }
		[Required]
		public Guid ReportReasonId { get; init; }
		[Required]
		public Guid GameId { get; init; }
	}
}
