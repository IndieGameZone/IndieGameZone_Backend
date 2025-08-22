using IndieGameZone.Domain.Constants;
using IndieGameZone.Domain.RequestsAndResponses.Responses.Games;
using IndieGameZone.Domain.RequestsAndResponses.Responses.ReportReasons;
using IndieGameZone.Domain.RequestsAndResponses.Responses.Reviews;
using IndieGameZone.Domain.RequestsAndResponses.Responses.Users;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndieGameZone.Domain.RequestsAndResponses.Responses.Reports
{
    public class ReviewReportForReturnDto
    {
        public Guid Id { get; init; }
        public string Message { get; init; } = string.Empty;
        public DateTime CreatedAt { get; init; }
        public DateTime? UpdatedAt { get; init; }
        public ReportStatus Status { get; init; }
        public string? ReviewMessage { get; init; }

        // Report info
        public ReportReasonForReturnDto ReportReason { get; init; } = null!;
        public UserReportForReturnDto ReportingUser { get; init; } = null!;

        // Related entities
        public GameForListReturnDto? Game { get; init; }

        // Actual review info
        public ReviewForReturnDto? Review { get; init; } = null!;

    }
}
