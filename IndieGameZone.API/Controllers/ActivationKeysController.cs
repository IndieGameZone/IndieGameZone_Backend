using IndieGameZone.Application.IServices;
using IndieGameZone.Domain.Constants;
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

		[HttpPut("games/{gameId:guid}/activation-keys/{activationKey}/activation")]
		public async Task<IActionResult> ActivateKey([FromRoute] Guid gameId, [FromRoute] string activationKey, CancellationToken ct = default)
		{
			await serviceManager.ActivationKeyService.ValidateActivationKey(gameId, activationKey, ct);
			return NoContent();
		}

		[HttpGet("games/{gameId:guid}/activation-keys/{activationKey}/status")]
		public async Task<IActionResult> ActivateUsedKey([FromRoute] Guid gameId, [FromRoute] string activationKey, CancellationToken ct = default)
		{
			var result = await serviceManager.ActivationKeyService.ValidateUsedActivationKey(gameId, activationKey, ct);
			return Ok(result);
		}

		//[HttpGet("users/{userId:guid}/games/{gameId:guid}/activation-keys")]
		//[Authorize]
		//public async Task<IActionResult> GetActivationKeys([FromRoute] Guid userId, [FromRoute] Guid gameId, CancellationToken ct = default)
		//{
		//	var activationKeys = await serviceManager.ActivationKeyService.GetKeyByGameId(userId, gameId, ct);
		//	return Ok(activationKeys);
		//}

		[HttpPost("games/{gameId:guid}/activation-keys")]
		[Authorize(Roles = $"{nameof(RoleEnum.Admin)},{nameof(RoleEnum.Moderator)},{nameof(RoleEnum.Developer)}")]
		public async Task<IActionResult> CreateActivationKeys([FromRoute] Guid gameId, CancellationToken ct = default)
		{
			var key = await serviceManager.ActivationKeyService.CreateActivationKey(gameId, ct);
			return StatusCode(201, key);
		}

		[HttpPut("users/{userId:guid}/games/{gameId:guid}/activation-keys/reset")]
		[Authorize]
		public async Task<IActionResult> ResetActivationKey([FromRoute] Guid userId, [FromRoute] Guid gameId, CancellationToken ct = default)
		{
			await serviceManager.ActivationKeyService.ResetActivationKey(userId, gameId, ct);
			return NoContent();
		}

		[HttpPut("games/{gameId:guid}/activation-keys/{activationKey}/moderator-reset")]
		[Authorize(Roles = $"{nameof(RoleEnum.Moderator)}")]
		public async Task<IActionResult> ResetActivationKeyForModerator([FromRoute] Guid gameId, [FromRoute] string activationKey, CancellationToken ct = default)
		{
			var newActivationkey = await serviceManager.ActivationKeyService.ResetActivationKeyForModerator(gameId, activationKey, ct);
			return Ok(newActivationkey);
		}
	}
}
