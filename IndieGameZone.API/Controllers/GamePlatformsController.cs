using IndieGameZone.Application;
using IndieGameZone.Domain.RequestsAndResponses.Requests.GamePlatforms;
using Microsoft.AspNetCore.Mvc;

namespace IndieGameZone.API.Controllers
{
	[Route("api")]
	[ApiController]
	public class GamePlatformsController : ControllerBase
	{
		private readonly IServiceManager serviceManager;

		public GamePlatformsController(IServiceManager serviceManager)
		{
			this.serviceManager = serviceManager;
		}

		[HttpPost("games/{gameId:guid}/game-platforms")]
		[RequestSizeLimit(300 * 1024 * 1024)]
		public async Task<IActionResult> CreateGamePlatforms([FromRoute] Guid gameId, [FromForm] List<GamePlatformForCreationDto> gamePlatforms, CancellationToken ct)
		{
			await serviceManager.GamePlatformService.CreateGamePlatforms(gameId, gamePlatforms, ct);
			return StatusCode(201);
		}

		[HttpPut("games/{gameId:guid}/game-platforms")]
		[RequestSizeLimit(300 * 1024 * 1024)]
		public async Task<IActionResult> UpdateGamePlatforms([FromRoute] Guid gameId, [FromForm] List<GamePlatformForUpdateDto> gamePlatforms, CancellationToken ct)
		{
			await serviceManager.GamePlatformService.UpdateGamePlatformsByGameId(gameId, gamePlatforms, ct);
			return NoContent();
		}

		[HttpGet("games/{gameId:guid}/game-platforms")]
		public async Task<IActionResult> GetGamePlatformsByGameId([FromRoute] Guid gameId, CancellationToken ct)
		{
			var gamePlatforms = await serviceManager.GamePlatformService.GetGamePlatformsByGameId(gameId, ct);
			return Ok(gamePlatforms);
		}
	}
}
