using System.ComponentModel.DataAnnotations;

namespace IndieGameZone.Domain.RequestsAndResponses.Requests.Wishlists
{
	public class WishlistForCreationDto
	{
		[Required]
		public Guid UserId { get; init; }
		[Required]
		public Guid GameId { get; init; }
	}
}
