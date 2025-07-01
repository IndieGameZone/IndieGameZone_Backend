using IndieGameZone.Application;
using IndieGameZone.Domain.Constants;
using IndieGameZone.Domain.RequestsAndResponses.Requests.Platforms;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace IndieGameZone.API.Controllers
{
	[Route("api/platforms")]
	[ApiController]
	public class PlatformsController : ControllerBase
	{
		private readonly IServiceManager serviceManager;

		public PlatformsController(IServiceManager serviceManager)
		{
			this.serviceManager = serviceManager;
		}

		[HttpGet]
		[Authorize]
		public async Task<IActionResult> GetPlatforms(CancellationToken ct)
		{
			var platforms = await serviceManager.PlatformService.GetPlatforms(ct);
			return Ok(platforms);
		}

		[HttpGet("{id:guid}")]
		[Authorize]
		public async Task<IActionResult> GetPlatform([FromRoute] Guid id, CancellationToken ct)
		{
			var platform = await serviceManager.PlatformService.GetPlatformById(id, ct);
			return Ok(platform);
		}

		[HttpPost]
		[Authorize(Roles = $"{nameof(RoleEnum.Admin)}")]
		public async Task<IActionResult> CreatePlatform([FromBody] PlatformForCreationDto platformDto, CancellationToken ct)
		{
			await serviceManager.PlatformService.CreatePlatform(platformDto, ct);
			return StatusCode(201);
		}

		[HttpPut("{id:guid}")]
		[Authorize(Roles = $"{nameof(RoleEnum.Admin)}")]
		public async Task<IActionResult> UpdatePlatform([FromRoute] Guid id, [FromBody] PlatformForUpdateDto platformDto, CancellationToken ct)
		{
			await serviceManager.PlatformService.UpdatePlatform(id, platformDto, ct);
			return NoContent();
		}

		[HttpDelete("{id:guid}")]
		[Authorize(Roles = $"{nameof(RoleEnum.Admin)}")]
		public async Task<IActionResult> DeletePlatform([FromRoute] Guid id, CancellationToken ct)
		{
			await serviceManager.PlatformService.DeletePlatform(id, ct);
			return NoContent();
		}
	}
}
