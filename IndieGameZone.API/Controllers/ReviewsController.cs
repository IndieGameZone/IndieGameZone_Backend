using IndieGameZone.Application;
using IndieGameZone.Domain.RequestFeatures;
using IndieGameZone.Domain.RequestsAndResponses.Requests.Reviews;
using Microsoft.AspNetCore.Mvc;
using System.Text.Json;

namespace IndieGameZone.API.Controllers
{
	[Route("api")]
	[ApiController]
	public class ReviewsController : ControllerBase
	{
		private readonly IServiceManager serviceManager;

		public ReviewsController(IServiceManager serviceManager)
		{
			this.serviceManager = serviceManager;
		}

		[HttpGet("games/{gameId:guid}/reviews")]
		public async Task<IActionResult> GetReviewsForGame([FromRoute] Guid gameId, [FromQuery] ReviewParameters reviewParameters, CancellationToken ct)
		{
			var pagedResult = await serviceManager.ReviewService.GetReviewsByGameId(gameId, reviewParameters, ct);
			Response.Headers.Append("X-Pagination", JsonSerializer.Serialize(pagedResult.metaData));
			return Ok(pagedResult.reviews);
		}

		[HttpGet("games/{gameId:guid}/reviews-summary")]
		public async Task<IActionResult> GetReviewsSummary([FromRoute] Guid gameId, CancellationToken ct)
		{
			var summary = await serviceManager.ReviewService.GetSummaryReviewByGameId(gameId, ct);
			return Ok(summary);
		}

		[HttpPost("users/{userId:guid}/games/{gameId:guid}/reviews")]
		public async Task<IActionResult> CreateReview([FromRoute] Guid userId, [FromRoute] Guid gameId, [FromBody] ReviewForCreationDto reviewForCreationDto, CancellationToken ct)
		{
			await serviceManager.ReviewService.CreateReview(userId, gameId, reviewForCreationDto, ct);
			return StatusCode(201);
		}
	}
}
