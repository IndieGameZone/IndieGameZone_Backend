using System.ComponentModel.DataAnnotations;

namespace IndieGameZone.Domain.RequestsAndResponses.Requests.PostComments
{
	public class PostCommentForUpdateDto
	{
		[Required]
		public string Content { get; init; }
	}
}
