using IndieGameZone.Application;
using IndieGameZone.Domain.RequestsAndResponses.Requests.GameStatuses;
using Microsoft.AspNetCore.Mvc;

namespace IndieGameZone.API.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class GameStatusesController : ControllerBase
	{
		private readonly IServiceManager serviceManager;

		public GameStatusesController(IServiceManager serviceManager)
		{
			this.serviceManager = serviceManager;
		}

		[HttpGet]
		public async Task<IActionResult> GetGameStatuses(CancellationToken ct)
		{
			var gameStatuses = await serviceManager.GameStatusService.GetGameStatuses(ct);
			return Ok(gameStatuses);
		}

		[HttpGet("{id:guid}")]
		public async Task<IActionResult> GetGameStatus(Guid id, CancellationToken ct)
		{
			var gameStatus = await serviceManager.GameStatusService.GetGameStatusById(id, ct);
			return Ok(gameStatus);
		}

		[HttpPost]
		public async Task<IActionResult> CreateGameStatus([FromBody] GameStatusForCreationDto gameStatusDto, CancellationToken ct)
		{
			await serviceManager.GameStatusService.CreateGameStatus(gameStatusDto, ct);
			return StatusCode(201);
		}

		[HttpPut("{id:guid}")]
		public async Task<IActionResult> UpdateGameStatus(Guid id, [FromBody] GameStatusForUpdateDto gameStatusDto, CancellationToken ct)
		{
			await serviceManager.GameStatusService.UpdateGameStatus(id, gameStatusDto, ct);
			return NoContent();
		}

		[HttpDelete("{id:guid}")]
		public async Task<IActionResult> DeleteGameStatus(Guid id, CancellationToken ct)
		{
			await serviceManager.GameStatusService.DeleteGameStatus(id, ct);
			return NoContent();
		}
	}
}
