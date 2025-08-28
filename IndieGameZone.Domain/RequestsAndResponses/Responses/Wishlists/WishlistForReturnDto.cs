using IndieGameZone.Domain.RequestsAndResponses.Responses.Games;

namespace IndieGameZone.Domain.RequestsAndResponses.Responses.Wishlists
{
	public class WishlistForReturnDto
	{
		public virtual GameForListReturnDto Game { get; init; }
		public DateTime AddedAt { get; init; }
	}
}
