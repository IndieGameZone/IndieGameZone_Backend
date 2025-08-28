using IndieGameZone.Domain.Constants;
using System.ComponentModel.DataAnnotations;

namespace IndieGameZone.Domain.RequestFeatures
{
	public class ReportParameters : RequestParameters
	{
        [Required]
        public ReportReasonTypeEnum ReportType { get; set; }
    }
}
