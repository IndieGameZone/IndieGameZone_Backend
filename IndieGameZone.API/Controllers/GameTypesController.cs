using IndieGameZone.Application;
using IndieGameZone.Domain.RequestsAndResponses.Requests.GameTypes;
using Microsoft.AspNetCore.Mvc;

namespace IndieGameZone.API.Controllers
{
	[Route("api/game-types")]
	[ApiController]
	public class GameTypesController : ControllerBase
	{
		private readonly IServiceManager serviceManager;

		public GameTypesController(IServiceManager serviceManager)
		{
			this.serviceManager = serviceManager;
		}

		[HttpGet]
		public async Task<IActionResult> GetGameStatuses(CancellationToken ct)
		{
			var gameStatuses = await serviceManager.GameTypeService.GetGameTypes(ct);
			return Ok(gameStatuses);
		}

		[HttpGet("{id:guid}")]
		public async Task<IActionResult> GetGameStatus([FromRoute] Guid id, CancellationToken ct)
		{
			var gameStatus = await serviceManager.GameTypeService.GetGameTypeById(id, ct);
			return Ok(gameStatus);
		}

		[HttpPost]
		public async Task<IActionResult> CreateGameStatus([FromBody] GameTypeForCreationDto gameTypeForCreationDto, CancellationToken ct)
		{
			await serviceManager.GameTypeService.CreateGameType(gameTypeForCreationDto, ct);
			return StatusCode(201);
		}

		[HttpPut("{id:guid}")]
		public async Task<IActionResult> UpdateGameStatus([FromRoute] Guid id, [FromBody] GameTypeForUpdateDto gameTypeForUpdateDto, CancellationToken ct)
		{
			await serviceManager.GameTypeService.UpdateGameType(id, gameTypeForUpdateDto, ct);
			return NoContent();
		}

		[HttpDelete("{id:guid}")]
		public async Task<IActionResult> DeleteGameStatus([FromRoute] Guid id, CancellationToken ct)
		{
			await serviceManager.GameTypeService.DeleteGameType(id, ct);
			return NoContent();
		}
	}
}
