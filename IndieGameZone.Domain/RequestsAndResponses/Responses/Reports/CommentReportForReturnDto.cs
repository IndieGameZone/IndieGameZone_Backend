using IndieGameZone.Domain.Constants;
using IndieGameZone.Domain.RequestsAndResponses.Responses.Games;
using IndieGameZone.Domain.RequestsAndResponses.Responses.PostComments;
using IndieGameZone.Domain.RequestsAndResponses.Responses.Posts;
using IndieGameZone.Domain.RequestsAndResponses.Responses.ReportReasons;
using IndieGameZone.Domain.RequestsAndResponses.Responses.Users;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndieGameZone.Domain.RequestsAndResponses.Responses.Reports
{
    public class CommentReportForReturnDto
    {
        public Guid Id { get; init; }
        public string Message { get; init; }
        public DateTime CreatedAt { get; init; }
        public ReportStatus Status { get; init; }
        public string? ReviewMessage { get; init; }
        public ReportReasonForReturnDto ReportReason { get; init; }
        public UserReportForReturnDto ReportingUser { get; init; }
        public UserReportForReturnDto? CommentOwner { get; init; }
        public PostCommentForReturnDto? PostComment { get; init; }
        public Guid? GameId { get; init; }
        public string? GameName { get; init; }
        public Guid? PostId { get; init; }
        public string? PostTitle { get; init; }

    }
}
