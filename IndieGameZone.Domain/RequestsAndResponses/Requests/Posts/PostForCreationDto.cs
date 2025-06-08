namespace IndieGameZone.Domain.RequestsAndResponses.Requests.Posts
{
	public class PostForCreationDto
	{
		public string Title { get; init; }
		public string Content { get; init; }
		public string? Image { get; init; }
		public ICollection<Guid> Tags { get; init; }
	}
}
