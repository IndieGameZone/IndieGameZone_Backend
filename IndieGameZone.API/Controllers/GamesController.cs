using IndieGameZone.Application;
using IndieGameZone.Application.RecombeeServices;
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
		private readonly IRecombeeService recombeeService;

		public GamesController(IServiceManager serviceManager, IRecombeeService recombeeService)
		{
			this.serviceManager = serviceManager;
			this.recombeeService = recombeeService;
		}

		/// <summary>
		/// Gets all the games for moderators and admins.
		/// </summary>
		[HttpGet("games")]
		public async Task<IActionResult> GetGames([FromQuery] GameParameters gameParameters, CancellationToken ct)
		{
			var pagedResult = await serviceManager.GameService.GetGames(gameParameters, ct);
			Response.Headers.Append("X-Pagination", JsonSerializer.Serialize(pagedResult.metaData));
			return Ok(pagedResult.games);
		}

		//[HttpPut("games/recombee-games")]
		//public async Task<IActionResult> UploadGameToAlgolia(CancellationToken ct)
		//{
		//	await recombeeService.PushGamesToRecombee();
		//	return NoContent();
		//}

		//[HttpGet("users/{playerId:guid}/recommended-games")]
		//public async Task<IActionResult> GetRecommendedGames([FromRoute] Guid playerId, CancellationToken ct)
		//{
		//	return Ok(await algoliaService.GetPersonalizedRecommendations(playerId.ToString()));
		//}

		[HttpGet("games/{gameId:guid}")]
		public async Task<IActionResult> GetGame([FromRoute] Guid gameId, CancellationToken ct)
		{
			var game = await serviceManager.GameService.GetGameById(gameId, ct);
			return Ok(game);
		}

		/// <summary>
		/// Gets all the games belong to developer.
		/// </summary>
		[HttpGet("users/{developerId:guid}/games")]
		public async Task<IActionResult> GetGamesByDeveloperId([FromRoute] Guid developerId, [FromQuery] GameParameters gameParameters, CancellationToken ct)
		{
			var pagedResult = await serviceManager.GameService.GetGamesByDeveloperId(developerId, gameParameters, ct);
			Response.Headers.Append("X-Pagination", JsonSerializer.Serialize(pagedResult.metaData));
			return Ok(pagedResult.games);
		}

		[HttpGet("users/{developerId:guid}/active-games")]
		public async Task<IActionResult> GetActiveGamesByDeveloperId([FromRoute] Guid developerId, [FromQuery] ActiveGameParameters activeGameParameters, CancellationToken ct)
		{
			var pagedResult = await serviceManager.GameService.GetActiveGamesByDeveloperId(developerId, activeGameParameters, ct);
			Response.Headers.Append("X-Pagination", JsonSerializer.Serialize(pagedResult.metaData));
			return Ok(pagedResult.games);
		}

		[HttpDelete("users/{developerId:guid}/games/{gameId:guid}")]
		public async Task<IActionResult> DeleteGame([FromRoute] Guid developerId, [FromRoute] Guid gameId, CancellationToken ct)
		{
			await serviceManager.GameService.DeleteGame(developerId, gameId, ct);
			return NoContent();
		}

		[HttpPost("users/{developerId:guid}/games")]
		public async Task<IActionResult> CreateGame([FromRoute] Guid developerId, [FromForm] GameForCreationDto game, CancellationToken ct)
		{
			var gameid = await serviceManager.GameService.CreateGame(developerId, game, ct);
			return StatusCode(201, gameid);
		}

		[HttpPut("users/{developerId:guid}/games/{gameId:guid}")]
		public async Task<IActionResult> UpdateGame([FromRoute] Guid developerId, [FromRoute] Guid gameId, [FromForm] GameForUpdateDto game, CancellationToken ct)
		{
			await serviceManager.GameService.UpdateGame(developerId, gameId, game, ct);
			return NoContent();
		}

		/// <summary>
		/// Gets all the games pass all the censor and visibility is public.
		/// </summary>
		[HttpGet("active-games")]
		public async Task<IActionResult> GetActiveGames([FromQuery] ActiveGameParameters activeGameParameters, CancellationToken ct)
		{
			var pagedResult = await serviceManager.GameService.GetActiveGames(activeGameParameters, ct);
			Response.Headers.Append("X-Pagination", JsonSerializer.Serialize(pagedResult.metaData));
			return Ok(pagedResult.games);
		}

		[HttpPut("users/{moderatorId:guid}/games/{gameId:guid}/activation")]
		public async Task<IActionResult> ActivateGame([FromRoute] Guid gameId, [FromRoute] Guid moderatorId, [FromForm] GameActivationDto gameActivationDto, CancellationToken ct)
		{
			await serviceManager.GameService.UpdateActiveStatus(moderatorId, gameId, gameActivationDto, ct);
			return NoContent();
		}

		[HttpGet("games/{gameId:guid}/platform-file")]
		public async Task<IActionResult> GetGamePlatformFile([FromRoute] Guid gameId, CancellationToken ct)
		{
			var platformFile = await serviceManager.GameService.GetGamePlatformFile(gameId, ct);
			return Ok(platformFile);
		}

		[HttpPut("games/{gamePlatformId:guid}/number-of-download")]
		public async Task<IActionResult> IncreaseNumberOfDownload([FromRoute] Guid gamePlatformId, CancellationToken ct)
		{
			var downloadUrl = await serviceManager.GameService.IncreaseNumberOfDownload(gamePlatformId, ct);
			return Redirect(downloadUrl);
		}
	}
}
