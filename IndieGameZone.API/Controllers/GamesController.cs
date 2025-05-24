using IndieGameZone.Application;
using IndieGameZone.Domain.RequestFeatures;
using Microsoft.AspNetCore.Mvc;
using System.Text.Json;

namespace IndieGameZone.API.Controllers
{
	[Route("api")]
	[ApiController]
	public class GamesController : ControllerBase
	{
		private readonly IServiceManager serviceManager;

		public GamesController(IServiceManager serviceManager)
		{
			this.serviceManager = serviceManager;
		}

		[HttpGet("Games")]
		public async Task<IActionResult> GetGames([FromQuery] GameParameters gameParameters, CancellationToken ct)
		{
			var pagedResult = await serviceManager.GameService.GetGames(gameParameters, ct);
			Response.Headers.Append("X-Pagination", JsonSerializer.Serialize(pagedResult.metaData));
			return Ok(pagedResult.games);
		}

		[HttpGet("Games/{gameId:guid}")]
		public async Task<IActionResult> GetGame([FromRoute] Guid gameId, CancellationToken ct)
		{
			var game = await serviceManager.GameService.GetGameById(gameId, ct);
			return Ok(game);
		}

		[HttpDelete("Users/{developerId:guid}/Games/{gameId:guid}")]
		public async Task<IActionResult> DeleteGame([FromRoute] Guid developerId, [FromRoute] Guid gameId, CancellationToken ct)
		{
			await serviceManager.GameService.DeleteGame(developerId, gameId, ct);
			return NoContent();
		}

	}
}
