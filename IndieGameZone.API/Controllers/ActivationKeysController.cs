using IndieGameZone.Application.IServices;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace IndieGameZone.API.Controllers
{
	[Route("api")]
	[ApiController]
	public class ActivationKeysController : ControllerBase
	{
		private readonly IServiceManager serviceManager;

		public ActivationKeysController(IServiceManager serviceManager)
		{
			this.serviceManager = serviceManager;
		}

		[HttpPut("activation-keys/{activationKey}/activation")]
		public async Task<IActionResult> ActivateKey([FromRoute] string activationKey, CancellationToken ct = default)
		{
			await serviceManager.ActivationKeyService.ValidateActivationKey(activationKey, ct);
			return NoContent();
		}

		[HttpGet("users/{userId}/game-platforms/{gamePlatformId}/activation-keys")]
		[Authorize]
		public async Task<IActionResult> GetActivationKeys([FromRoute] Guid userId, [FromRoute] Guid gamePlatformId, CancellationToken ct = default)
		{
			var activationKeys = await serviceManager.ActivationKeyService.GetKeyByGamePlatformId(userId, gamePlatformId, ct);
			return Ok(activationKeys);
		}
	}
}
