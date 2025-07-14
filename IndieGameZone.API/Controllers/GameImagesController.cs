using IndieGameZone.Application.IServices;
using Microsoft.AspNetCore.Mvc;

namespace IndieGameZone.API.Controllers
{
	[Route("api")]
	[ApiController]
	public class GameImagesController : ControllerBase
	{
		private readonly IServiceManager serviceManager;

		public GameImagesController(IServiceManager serviceManager)
		{
			this.serviceManager = serviceManager;
		}

		[HttpPut("games/{gameId:guid}/game-images")]
		public async Task<IActionResult> UpdateGameImages(Guid gameId, [FromForm] ICollection<string> images, CancellationToken ct = default)
		{
			await serviceManager.GameImageService.UpdateGameImages(gameId, images, ct);
			return NoContent();
		}
	}
}
