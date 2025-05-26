using IndieGameZone.Application;
using IndieGameZone.Domain.RequestFeatures;
using IndieGameZone.Domain.RequestsAndResponses.Requests.Games;
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

		[HttpGet("Users/{developerId:guid}/Games")]
		public async Task<IActionResult> GetGamesByDeveloperId([FromRoute] Guid developerId, [FromQuery] GameParameters gameParameters, CancellationToken ct)
		{
			var pagedResult = await serviceManager.GameService.GetGamesByDeveloperId(developerId, gameParameters, ct);
			Response.Headers.Append("X-Pagination", JsonSerializer.Serialize(pagedResult.metaData));
			return Ok(pagedResult.games);
		}

		[HttpDelete("Users/{developerId:guid}/Games/{gameId:guid}")]
		public async Task<IActionResult> DeleteGame([FromRoute] Guid developerId, [FromRoute] Guid gameId, CancellationToken ct)
		{
			await serviceManager.GameService.DeleteGame(developerId, gameId, ct);
			return NoContent();
		}

		[HttpPost("Users/{developerId:guid}/Games")]
		[RequestSizeLimit(104857600)]
		public async Task<IActionResult> CreateGame([FromRoute] Guid developerId, [FromForm] GameForCreationDto game, CancellationToken ct)
		{
			var gameid = await serviceManager.GameService.CreateGame(developerId, game, ct);
			return StatusCode(201, gameid);
		}

		[HttpPut("Users/{developerId:guid}/Games/{gameId:guid}")]
		public async Task<IActionResult> UpdateGame([FromRoute] Guid developerId, [FromRoute] Guid gameId, [FromForm] GameForUpdateDto game, CancellationToken ct)
		{
			await serviceManager.GameService.UpdateGame(developerId, gameId, game, ct);
			return NoContent();
		}

		[HttpGet("ActiveGames")]
		public async Task<IActionResult> GetActiveGames([FromQuery] ActiveGameParameters activeGameParameters, CancellationToken ct)
		{
			var pagedResult = await serviceManager.GameService.GetActiveGames(activeGameParameters, ct);
			Response.Headers.Append("X-Pagination", JsonSerializer.Serialize(pagedResult.metaData));
			return Ok(pagedResult.games);
		}

		[HttpPut("Games/{gameId:guid}/Activation")]
		public async Task<IActionResult> ActivateGame([FromRoute] Guid gameId, CancellationToken ct)
		{
			await serviceManager.GameService.UpdateActiveStatus(gameId, ct);
			return NoContent();
		}
	}
}
