using IndieGameZone.Application.IServices;
using IndieGameZone.Domain.Entities;
using IndieGameZone.Domain.Exceptions;
using IndieGameZone.Domain.IRepositories;
using IndieGameZone.Domain.RequestFeatures;
using IndieGameZone.Domain.RequestsAndResponses.Responses.Wishlists;
using MapsterMapper;
using Microsoft.AspNetCore.Identity;

namespace IndieGameZone.Application.Services
{
	internal sealed class WishlistService : IWishlistService
	{
		private readonly IRepositoryManager repositoryManager;
		private readonly IMapper mapper;
		private readonly IRecombeeService recombeeService;
		private readonly UserManager<Users> userManager;

		public WishlistService(IRepositoryManager repositoryManager, IMapper mapper, IRecombeeService recombeeService, UserManager<Users> userManager)
		{
			this.repositoryManager = repositoryManager;
			this.mapper = mapper;
			this.recombeeService = recombeeService;
			this.userManager = userManager;
		}
		public async Task AddToWishlist(Guid userId, Guid gameId, CancellationToken ct = default)
		{
			var user = await userManager.FindByIdAsync(userId.ToString());
			if (user is null)
			{
				throw new NotFoundException("User not found.");
			}
			var game = await repositoryManager.GameRepository.GetGameById(gameId, false, ct);
			if (game is null)
			{
				throw new NotFoundException("Game not found.");
			}
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
			var user = await userManager.FindByIdAsync(userId.ToString());
			if (user is null)
			{
				throw new NotFoundException("User not found.");
			}
			var wishlistsWithMetaData = await repositoryManager.WishlistRepository.GetWishlistByUserId(wishlistParameters, userId, false, ct);
			var wishlists = mapper.Map<IEnumerable<WishlistForReturnDto>>(wishlistsWithMetaData);
			return (wishlists, wishlistsWithMetaData.MetaData);
		}

		public async Task RemoveFromWishlist(Guid userId, Guid gameId, CancellationToken ct = default)
		{
			var user = await userManager.FindByIdAsync(userId.ToString());
			if (user is null)
			{
				throw new NotFoundException("User not found.");
			}
			var game = await repositoryManager.GameRepository.GetGameById(gameId, false, ct);
			if (game is null)
			{
				throw new NotFoundException("Game not found.");
			}
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
