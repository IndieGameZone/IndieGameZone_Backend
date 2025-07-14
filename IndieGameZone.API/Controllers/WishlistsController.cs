using IndieGameZone.Application.IServices;
using IndieGameZone.Domain.RequestFeatures;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Text.Json;

namespace IndieGameZone.API.Controllers
{
	[Route("api")]
	[ApiController]
	public class WishlistsController : ControllerBase
	{
		private readonly IServiceManager serviceManager;

		public WishlistsController(IServiceManager serviceManager)
		{
			this.serviceManager = serviceManager;
		}

		[HttpPost("users/{userId:guid}/games/{gameId:guid}/wishlists")]
		[Authorize]
		public async Task<IActionResult> AddGameToWishlist([FromRoute] Guid userId, [FromRoute] Guid gameId, CancellationToken ct)
		{
			await serviceManager.WishlistService.AddToWishlist(userId, gameId, ct);
			return StatusCode(201);
		}

		[HttpDelete("users/{userId:guid}/games/{gameId:guid}/wishlists")]
		[Authorize]
		public async Task<IActionResult> RemoveGameFromWishlist([FromRoute] Guid userId, [FromRoute] Guid gameId, CancellationToken ct)
		{
			await serviceManager.WishlistService.RemoveFromWishlist(userId, gameId, ct);
			return NoContent();
		}

		[HttpGet("users/{userId:guid}/wishlists")]
		[Authorize]
		public async Task<IActionResult> GetUserWishlist([FromQuery] WishlistParameters wishlistParameters, [FromRoute] Guid userId, CancellationToken ct)
		{
			var pagedResult = await serviceManager.WishlistService.GetWishlistsFromUserId(wishlistParameters, userId, ct);
			Response.Headers.Append("X-Pagination", JsonSerializer.Serialize(pagedResult.metaData));
			return Ok(pagedResult.wishlists);
		}
	}
}
