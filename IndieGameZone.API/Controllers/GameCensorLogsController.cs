using IndieGameZone.Application.IServices;
using IndieGameZone.Domain.Constants;
using IndieGameZone.Domain.RequestFeatures;
using Microsoft.AspNetCore.Authorization;
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
		[Authorize(Roles = $"{nameof(RoleEnum.Admin)},{nameof(RoleEnum.Moderator)},{nameof(RoleEnum.Developer)}")]
		public async Task<IActionResult> GetGameCensorLogs([FromRoute] Guid gameId, [FromQuery] GameCensorLogParameters gameCensorLogParameters, CancellationToken ct)
		{
			var pagedResult = await serviceManager.GameCensorLogService.GetGameCensorLogsByGameId(gameId, gameCensorLogParameters, ct);
			Response.Headers.Append("X-Pagination", JsonSerializer.Serialize(pagedResult.metaData));
			return Ok(pagedResult.gameCensorLogs);
		}
	}
}
