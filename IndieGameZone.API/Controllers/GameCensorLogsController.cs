using IndieGameZone.Application;
using IndieGameZone.Domain.RequestFeatures;
using Microsoft.AspNetCore.Mvc;
using System.Text.Json;

namespace IndieGameZone.API.Controllers
{
	[Route("api")]
	[ApiController]
	public class GameCensorLogsController : ControllerBase
	{
		private readonly IServiceManager serviceManager;

		public GameCensorLogsController(IServiceManager serviceManager)
		{
			this.serviceManager = serviceManager;
		}

		[HttpGet("games/{gameId:guid}/game-censor-logs")]
		public async Task<IActionResult> GetGameCensorLogs([FromRoute] Guid gameId, [FromQuery] GameCensorLogParameters gameCensorLogParameters, CancellationToken ct)
		{
			var pagedResult = await serviceManager.GameCensorLogService.GetGameCensorLogsByGameId(gameId, gameCensorLogParameters, ct);
			Response.Headers.Append("X-Pagination", JsonSerializer.Serialize(pagedResult.metaData));
			return Ok(pagedResult.gameCensorLogs);
		}
	}
}
