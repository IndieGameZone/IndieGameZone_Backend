using Microsoft.AspNetCore.Http;

namespace IndieGameZone.Domain.RequestsAndResponses.Requests.Posts
{
	public class PostForUpdateDto
	{
		public string Title { get; init; }
		public string Content { get; init; }
		public IFormFile? Image { get; init; }
	}
}
