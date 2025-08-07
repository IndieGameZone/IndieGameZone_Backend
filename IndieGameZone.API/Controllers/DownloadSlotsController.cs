using IndieGameZone.Application.IServices;
using IndieGameZone.Domain.RequestFeatures;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace IndieGameZone.API.Controllers
{
	[Route("api")]
	[ApiController]
	public class DownloadSlotsController : ControllerBase
	{
		private readonly IServiceManager serviceManager;

		public DownloadSlotsController(IServiceManager serviceManager)
		{
			this.serviceManager = serviceManager;
		}

		[HttpGet("games/{gameId:guid}/number-of-download")]
		[Authorize]
		public async Task<IActionResult> GetNumberOfDownloadSlots([FromRoute] Guid gameId, [FromQuery] DownloadSlotParameters downloadSlotParameters, CancellationToken ct)
		{
			var result = await serviceManager.DownloadSlotService.GetNumberOfDownloadSlots(gameId, downloadSlotParameters, ct);
			return Ok(result);
		}
	}
}
