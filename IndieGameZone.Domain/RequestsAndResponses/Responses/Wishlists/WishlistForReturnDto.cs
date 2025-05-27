namespace IndieGameZone.Domain.RequestsAndResponses.Responses.Wishlists
{
	public class WishlistForReturnDto
	{
		public Guid UserId { get; init; }
		public Guid GameId { get; init; }
		public DateTime AddedAt { get; init; }
	}
}
