using IndieGameZone.Application.IServices;
using IndieGameZone.Domain.Entities;
using IndieGameZone.Domain.Exceptions;
using IndieGameZone.Domain.IRepositories;
using IndieGameZone.Domain.RequestFeatures;
using IndieGameZone.Domain.RequestsAndResponses.Responses.Wishlists;
using MapsterMapper;

namespace IndieGameZone.Application.Services
{
	internal sealed class WishlistService : IWishlistService
	{
		private readonly IRepositoryManager repositoryManager;
		private readonly IMapper mapper;
		private readonly IRecombeeService recombeeService;

		public WishlistService(IRepositoryManager repositoryManager, IMapper mapper, IRecombeeService recombeeService)
		{
			this.repositoryManager = repositoryManager;
			this.mapper = mapper;
			this.recombeeService = recombeeService;
		}
		public async Task AddToWishlist(Guid userId, Guid gameId, CancellationToken ct = default)
		{
			var wishlistEntity = new Wishlists
			{
				GameId = gameId,
				UserId = userId,
				AddedAt = DateTime.Now
			};
			repositoryManager.WishlistRepository.AddToWishlist(wishlistEntity);
			await repositoryManager.SaveAsync(ct);

			await recombeeService.SendBookmarkEvent(userId, gameId);
		}

		public async Task<(IEnumerable<WishlistForReturnDto> wishlists, MetaData metaData)> GetWishlistsFromUserId(WishlistParameters wishlistParameters, Guid userId, CancellationToken ct = default)
		{
			var wishlistsWithMetaData = await repositoryManager.WishlistRepository.GetWishlistByUserId(wishlistParameters, userId, false, ct);
			var wishlists = mapper.Map<IEnumerable<WishlistForReturnDto>>(wishlistsWithMetaData);
			return (wishlists, wishlistsWithMetaData.MetaData);
		}

		public async Task RemoveFromWishlist(Guid userId, Guid gameId, CancellationToken ct = default)
		{
			var wishlistEntity = await repositoryManager.WishlistRepository.GetWishlistByUserIdAndGameId(userId, gameId, false, ct);
			if (wishlistEntity is null)
			{
				throw new NotFoundException("Wishlist not found for the specified user and game.");
			}
			repositoryManager.WishlistRepository.RemoveFromWishlist(wishlistEntity);
			await repositoryManager.SaveAsync(ct);
		}
	}
}
