using System.ComponentModel.DataAnnotations;

namespace IndieGameZone.Domain.RequestsAndResponses.Requests.Reports
{
	public class ReportCommentForCreationDto
	{
		[Required]
		public string Message { get; init; }
		[Required]
		public Guid ReportReasonId { get; init; }
		[Required]
		public Guid CommentId { get; init; }
	}
}
