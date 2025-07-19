using IndieGameZone.Domain.Constants;
using System.ComponentModel.DataAnnotations;

namespace IndieGameZone.Domain.RequestsAndResponses.Requests.ReportReasons
{
	public class ReportReasonForCreationDto
	{
		[Required]
		public string Name { get; init; }
		[Required]
		public ReportReasonTypeEnum Type { get; init; }
	}
}
