using IndieGameZone.Application;
using Microsoft.AspNetCore.Mvc;

namespace IndieGameZone.API.Controllers
{
	[Route("api")]
	[ApiController]
	public class GameInfosController : ControllerBase
	{
		private readonly IServiceManager serviceManager;

		public GameInfosController(IServiceManager serviceManager)
		{
			this.serviceManager = serviceManager;
		}

		//[HttpPost("games/{gameId:guid}/game-infos")]
		//public async Task<IActionResult> CreateGameInfo([FromRoute] Guid gameId, [FromForm] List<GameInfoForCreationDto> gameInfo, CancellationToken ct)
		//{
		//	await serviceManager.GameInfoService.CreateGameInfo(gameId, gameInfo, ct);
		//	return StatusCode(201);
		//}

		//[HttpPut("games/{gameId:guid}/game-infos")]
		//public async Task<IActionResult> UpdateGameInfo([FromRoute] Guid gameId, [FromForm] List<GameInfoForUpdateDto> gameInfo, CancellationToken ct)
		//{
		//	await serviceManager.GameInfoService.UpdateGameInfosByGameId(gameId, gameInfo, ct);
		//	return NoContent();
		//}

		[HttpGet("games/{gameId:guid}/game-infos")]
		public async Task<IActionResult> GetGameImagesByGameId([FromRoute] Guid gameId, CancellationToken ct)
		{
			var gameInfos = await serviceManager.GameInfoService.GetGameInfosByGameId(gameId, ct);
			return Ok(gameInfos);
		}
	}
}
