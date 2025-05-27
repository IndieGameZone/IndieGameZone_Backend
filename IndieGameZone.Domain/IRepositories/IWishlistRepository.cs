using IndieGameZone.Domain.Entities;
using IndieGameZone.Domain.RequestFeatures;

namespace IndieGameZone.Domain.IRepositories
{
	public interface IWishlistRepository
	{
		void AddToWishlist(Wishlists wishlists);
		void RemoveFromWishlist(Wishlists wishlists);
		Task<PagedList<Wishlists>> GetWishlistByUserId(WishlistParameters wishlistParameters, Guid userId, bool trackChange, CancellationToken ct = default);
		Task<Wishlists?> GetWishlistByUserIdAndGameId(Guid userId, Guid gameId, bool trackChange, CancellationToken ct = default);
	}
}
