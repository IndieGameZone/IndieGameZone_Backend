using System.ComponentModel.DataAnnotations;

namespace IndieGameZone.Domain.RequestsAndResponses.Requests.Reports
{
	public class ReportPostForCreationDto
	{
		[Required]
		public string Message { get; init; }
		[Required]
		public Guid ReportReasonId { get; init; }
        [Required]
        public Guid GameId { get; init; }
        [Required]
        public Guid PostId { get; init; }
    
	}
}
