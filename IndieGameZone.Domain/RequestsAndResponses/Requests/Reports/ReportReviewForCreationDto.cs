using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndieGameZone.Domain.RequestsAndResponses.Requests.Reports
{
    public class ReportReviewForCreationDto
    {
        [Required]
        public string Message { get; init; }
        [Required]
        public Guid ReportReasonId { get; init; }
        [Required]
        public Guid ReviewId { get; init; }

    }
}
