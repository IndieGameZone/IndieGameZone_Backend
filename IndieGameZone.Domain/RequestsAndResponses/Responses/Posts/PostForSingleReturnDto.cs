using IndieGameZone.Domain.RequestsAndResponses.Responses.PostImages;
using IndieGameZone.Domain.RequestsAndResponses.Responses.PostTags;

namespace IndieGameZone.Domain.RequestsAndResponses.Responses.Posts
{
	public class PostForSingleReturnDto
	{
		public Guid Id { get; init; }
		public string Title { get; init; }
		public string Content { get; init; }
		public ICollection<PostImageForReturnDto> PostImages { get; init; }
		public ICollection<PostTagForReturnDto> PostTags { get; init; }
		public int NumberOfComments { get; init; }
		public int NumberOfLikes { get; init; }
	}
}
