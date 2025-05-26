using IndieGameZone.Application;
using IndieGameZone.Domain.RequestsAndResponses.Requests.GameInfos;
using Microsoft.AspNetCore.Mvc;

namespace IndieGameZone.API.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class GameInfosController : ControllerBase
	{
		private readonly IServiceManager serviceManager;

		public GameInfosController(IServiceManager serviceManager)
		{
			this.serviceManager = serviceManager;
		}

		[HttpPost("Games/{gameId:guid}/GameInfos")]
		public async Task<IActionResult> CreateGameInfo([FromRoute] Guid gameId, [FromForm] List<GameInfoForCreationDto> gameInfo, CancellationToken ct)
		{
			await serviceManager.GameInfoService.CreateGameInfo(gameId, gameInfo, ct);
			return StatusCode(201);
		}

		[HttpPut("Games/{gameId:guid}/GameInfos")]
		public async Task<IActionResult> UpdateGameInfo([FromRoute] Guid gameId, [FromForm] List<GameInfoForUpdateDto> gameInfo, CancellationToken ct)
		{
			await serviceManager.GameInfoService.UpdateGameInfosByGameId(gameId, gameInfo, ct);
			return NoContent();
		}

		[HttpGet("Games/{gameId:guid}/GameInfos")]
		public async Task<IActionResult> GetGameInfosByGameId([FromRoute] Guid gameId, CancellationToken ct)
		{
			var gameInfos = await serviceManager.GameInfoService.GetGameInfosByGameId(gameId, ct);
			return Ok(gameInfos);
		}
	}
}
