using IndieGameZone.Domain.RequestsAndResponses.Responses.Users;

namespace IndieGameZone.Domain.RequestsAndResponses.Responses.PostComments
{
	public class PostCommentForReturnDto
	{
		public Guid Id { get; init; }
		public string Content { get; init; }
		public virtual UserShortForReturnDto User { get; set; } = null!;
		public DateTime CreatedAt { get; set; }
		public DateTime? UpdatedAt { get; set; }
	}
}
