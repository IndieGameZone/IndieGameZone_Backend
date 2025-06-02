namespace IndieGameZone.Domain.RequestsAndResponses.Responses.Posts
{
	public class PostForSingleReturnDto
	{
		public Guid Id { get; init; }
		public string Title { get; init; }
		public string Content { get; init; }
		public string Image { get; init; }
	}
}
