using System.ComponentModel.DataAnnotations;

namespace IndieGameZone.Domain.RequestsAndResponses.Requests.Posts
{
	public class PostForUpdateDto
	{
		[Required]
		public string Title { get; init; }
		[Required]
		public string Content { get; init; }
		[Required]
		public ICollection<string> Images { get; init; }
		public ICollection<Guid>? Tags { get; init; }
	}
}
