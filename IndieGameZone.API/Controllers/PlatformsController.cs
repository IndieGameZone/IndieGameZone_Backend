using IndieGameZone.Application;
using IndieGameZone.Domain.RequestsAndResponses.Requests.Platforms;
using Microsoft.AspNetCore.Mvc;

namespace IndieGameZone.API.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class PlatformsController : ControllerBase
	{
		private readonly IServiceManager serviceManager;

		public PlatformsController(IServiceManager serviceManager)
		{
			this.serviceManager = serviceManager;
		}

		[HttpGet]
		public async Task<IActionResult> GetPlatforms(CancellationToken ct)
		{
			var platforms = await serviceManager.PlatformService.GetPlatforms(ct);
			return Ok(platforms);
		}

		[HttpGet("{id:guid}")]
		public async Task<IActionResult> GetPlatform([FromRoute] Guid id, CancellationToken ct)
		{
			var platform = await serviceManager.PlatformService.GetPlatformById(id, ct);
			return Ok(platform);
		}

		[HttpPost]
		public async Task<IActionResult> CreatePlatform([FromBody] PlatformForCreationDto platformDto, CancellationToken ct)
		{
			await serviceManager.PlatformService.CreatePlatform(platformDto, ct);
			return StatusCode(201);
		}

		[HttpPut("{id:guid}")]
		public async Task<IActionResult> UpdatePlatform([FromRoute] Guid id, [FromBody] PlatformForUpdateDto platformDto, CancellationToken ct)
		{
			await serviceManager.PlatformService.UpdatePlatform(id, platformDto, ct);
			return NoContent();
		}

		[HttpDelete("{id:guid}")]
		public async Task<IActionResult> DeletePlatform([FromRoute] Guid id, CancellationToken ct)
		{
			await serviceManager.PlatformService.DeletePlatform(id, ct);
			return NoContent();
		}
	}
}
