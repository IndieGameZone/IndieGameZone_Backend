using System.ComponentModel.DataAnnotations;

namespace IndieGameZone.Domain.RequestsAndResponses.Requests.PostComments
{
	public class PostCommentForCreationDto
	{
		[Required]
		public string Content { get; init; }
	}
}
