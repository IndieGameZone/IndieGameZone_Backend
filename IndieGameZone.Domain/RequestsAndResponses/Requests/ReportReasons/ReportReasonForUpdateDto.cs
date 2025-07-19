using IndieGameZone.Domain.Constants;
using System.ComponentModel.DataAnnotations;

namespace IndieGameZone.Domain.RequestsAndResponses.Requests.ReportReasons
{
	public class ReportReasonForUpdateDto
	{
		[Required]
		public string Name { get; init; }
		[Required]
		public ReportReasonTypeEnum Type { get; init; }
	}
}
