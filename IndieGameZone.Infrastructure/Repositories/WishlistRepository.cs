using IndieGameZone.Domain.Entities;
using IndieGameZone.Domain.IRepositories;
using IndieGameZone.Domain.RequestFeatures;
using IndieGameZone.Infrastructure.Extensions;
using IndieGameZone.Infrastructure.Persistence;
using Microsoft.EntityFrameworkCore;

namespace IndieGameZone.Infrastructure.Repositories
{
	internal sealed class WishlistRepository : RepositoryBase<Wishlists>, IWishlistRepository
	{
		public WishlistRepository(AppDbContext appDbContext) : base(appDbContext)
		{
		}

		public void AddToWishlist(Wishlists wishlists) => Create(wishlists);

		public async Task<PagedList<Wishlists>> GetWishlistByUserId(WishlistParameters wishlistParameters, Guid userId, bool trackChange, CancellationToken ct = default)
		{
			var wishlistEntities = FindByCondition(w => w.UserId == userId, trackChange)
				.Sort();
			return await PagedList<Wishlists>.ToPagedList(wishlistEntities, wishlistParameters.PageNumber, wishlistParameters.PageSize, ct);
		}

		public async Task<Wishlists?> GetWishlistByUserIdAndGameId(Guid userId, Guid gameId, bool trackChange, CancellationToken ct = default) => await FindByCondition(w => w.UserId == userId && w.GameId == gameId, trackChange)
			.FirstOrDefaultAsync(ct);

		public void RemoveFromWishlist(Wishlists wishlists) => Delete(wishlists);
	}
}
