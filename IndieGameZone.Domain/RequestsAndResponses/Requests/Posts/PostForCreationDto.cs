using System.ComponentModel.DataAnnotations;

namespace IndieGameZone.Domain.RequestsAndResponses.Requests.Posts
{
	public class PostForCreationDto
	{
		[Required]
		public string Title { get; init; }
		[Required]
		public string Content { get; init; }
		public string? Image { get; init; }
		public ICollection<Guid>? Tags { get; init; }
	}
}
