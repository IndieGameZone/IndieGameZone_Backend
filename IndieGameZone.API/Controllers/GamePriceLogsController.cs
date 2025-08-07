using IndieGameZone.Application.IServices;
using IndieGameZone.Domain.RequestFeatures;
using Microsoft.AspNetCore.Mvc;
using System.Text.Json;

namespace IndieGameZone.API.Controllers
{
	[Route("api")]
	[ApiController]
	public class GamePriceLogsController : ControllerBase
	{
		private readonly IServiceManager serviceManager;

		public GamePriceLogsController(IServiceManager serviceManager)
		{
			this.serviceManager = serviceManager;
		}

		[HttpGet("games/{gameId:guid}/game-price-logs")]
		public async Task<IActionResult> GetGamePriceLogs([FromRoute] Guid gameId, [FromQuery] GamePriceLogParameters gamePriceLogParameters, CancellationToken ct)
		{
			var pagedResult = await serviceManager.GamePriceLogService.GetGamePriceLogsByGameId(gameId, gamePriceLogParameters, ct);
			Response.Headers.Append("X-Pagination", JsonSerializer.Serialize(pagedResult.metaData));
			return Ok(pagedResult.gamePriceLogs);
		}
	}
}
