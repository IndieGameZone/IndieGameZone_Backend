using IndieGameZone.Domain.Constants;
using IndieGameZone.Domain.RequestsAndResponses.Responses.Games;
using IndieGameZone.Domain.RequestsAndResponses.Responses.PostComments;
using IndieGameZone.Domain.RequestsAndResponses.Responses.Posts;
using IndieGameZone.Domain.RequestsAndResponses.Responses.ReportReasons;
using IndieGameZone.Domain.RequestsAndResponses.Responses.Users;

namespace IndieGameZone.Domain.RequestsAndResponses.Responses.Reports
{
	public class ReportForReturnDto
	{
		public Guid Id { get; init; }
		public string Message { get; init; }
		public DateTime CreatedAt { get; init; }
        public ReportStatus Status { get; init; }
        public string? ReviewMessage { get; init; }
        public ReportReasonForReturnDto ReportReason { get; init; }
		public UserShortForReturnDto ReportingUser { get; init; }
		public PostForReturnDto? Post { get; init; }
		public GameForListReturnDto? Game { get; init; }
		public PostCommentForReturnDto? PostComment { get; init; }
	}
}
