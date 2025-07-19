using IndieGameZone.Domain.RequestsAndResponses.Responses.PostImages;
using IndieGameZone.Domain.RequestsAndResponses.Responses.PostTags;
using IndieGameZone.Domain.RequestsAndResponses.Responses.Users;

namespace IndieGameZone.Domain.RequestsAndResponses.Responses.Posts
{
	public class PostForListReturnDto
	{
		public Guid Id { get; init; }
		public string Title { get; init; }
		public string Content { get; init; }
		public ICollection<PostImageForReturnDto> PostImages { get; init; }
		public ICollection<PostTagForReturnDto> PostTags { get; init; }
		public int NumberOfComments { get; init; }
		public int NumberOfLikes { get; init; }
		public UserShortForReturnDto User { get; init; }
	}
}
