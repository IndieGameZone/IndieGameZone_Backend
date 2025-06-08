using IndieGameZone.Domain.RequestsAndResponses.Responses.PostTags;

namespace IndieGameZone.Domain.RequestsAndResponses.Responses.Posts
{
	public class PostForListReturnDto
	{
		public Guid Id { get; init; }
		public string Title { get; init; }
		public ICollection<PostTagForReturnDto> PostTags { get; init; }
	}
}
