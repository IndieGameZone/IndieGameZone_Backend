namespace IndieGameZone.Domain.RequestsAndResponses.Requests.Wishlists
{
	public class WishlistForCreationDto
	{
		public Guid UserId { get; init; }
		public Guid GameId { get; init; }
	}
}
