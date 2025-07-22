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
		public bool IsResolved { get; set; }
		public ReportReasonForReturnDto ReportReason { get; init; }
		public UserShortForReturnDto ReportingUser { get; init; }
		public PostForReturnDto? PostId { get; init; }
		public GameForListReturnDto? GameId { get; init; }
		public PostCommentForReturnDto? CommentId { get; init; }
	}
}
