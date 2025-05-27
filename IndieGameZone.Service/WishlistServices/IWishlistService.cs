using IndieGameZone.Domain.RequestFeatures;
using IndieGameZone.Domain.RequestsAndResponses.Responses.Wishlists;

namespace IndieGameZone.Application.WishlistServices
{
	public interface IWishlistService
	{
		Task AddToWishlist(Guid userId, Guid gameId, CancellationToken ct = default);
		Task RemoveFromWishlist(Guid userId, Guid gameId, CancellationToken ct = default);
		Task<(IEnumerable<WishlistForReturnDto> wishlists, MetaData metaData)> GetWishlistsFromUserId(WishlistParameters wishlistParameters, Guid userId, CancellationToken ct = default);
	}
}
