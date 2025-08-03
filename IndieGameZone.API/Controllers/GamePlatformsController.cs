using IndieGameZone.Application.IServices;
using IndieGameZone.Domain.Constants;
using IndieGameZone.Domain.RequestsAndResponses.Requests.GamePlatforms;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace IndieGameZone.API.Controllers
{
	[Route("api")]
	[ApiController]
	public class GamePlatformsController : ControllerBase
	{
		private readonly IServiceManager serviceManager;

		public GamePlatformsController(IServiceManager serviceManager)
		{
			this.serviceManager = serviceManager;
		}

		[HttpPost("games/{gameId:guid}/game-platforms")]
		[Authorize(Roles = $"{nameof(RoleEnum.Admin)},{nameof(RoleEnum.Moderator)},{nameof(RoleEnum.Developer)}")]
		public async Task<IActionResult> CreateGamePlatform([FromRoute] Guid gameId, [FromBody] ICollection<GamePlatformForCreationDto> gamePlatformForCreationDto, CancellationToken ct)
		{
			await serviceManager.GamePlatformService.CreateGamePlatform(gameId, gamePlatformForCreationDto, ct);
			return StatusCode(201);
		}

		[HttpPut("games/{gameId:guid}/game-platforms")]
		[Authorize(Roles = $"{nameof(RoleEnum.Admin)},{nameof(RoleEnum.Moderator)},{nameof(RoleEnum.Developer)}")]
		public async Task<IActionResult> UpdateGamePlatform([FromRoute] Guid gameId, [FromRoute] Guid developerId, [FromBody] ICollection<GamePlatformForUpdateDto> gamePlatformForUpdateDtos, CancellationToken ct)
		{
			await serviceManager.GamePlatformService.UpdateGamePlatform(gameId, gamePlatformForUpdateDtos, ct);
			return NoContent();
		}

		[HttpPut("game-platforms/{gamePlatformId:guid}/activation")]
		[Authorize(Roles = $"{nameof(RoleEnum.Admin)},{nameof(RoleEnum.Moderator)},{nameof(RoleEnum.Developer)}")]
		public async Task<IActionResult> UpdateGamePlatformActivationStatus([FromRoute] Guid developerId, [FromRoute] Guid gamePlatformId, [FromForm] bool isActive, CancellationToken ct)
		{
			await serviceManager.GamePlatformService.UpdateGamePlatformActivationStatus(gamePlatformId, isActive, ct);
			return NoContent();
		}

		[HttpPut("game-platforms/{gamePlatformId:guid}")]
		[Authorize(Roles = $"{nameof(RoleEnum.Admin)},{nameof(RoleEnum.Moderator)},{nameof(RoleEnum.Developer)}")]
		public async Task<IActionResult> UpdateGamePlatform([FromRoute] Guid developerId, [FromRoute] Guid gamePlatformId, [FromBody] GamePlatformForUpdateDto gamePlatformForUpdateDto, CancellationToken ct)
		{
			await serviceManager.GamePlatformService.UpdateGamePlatformById(gamePlatformId, gamePlatformForUpdateDto, ct);
			return NoContent();
		}

		[HttpDelete("game-platforms/{gamePlatformId:guid}")]
		[Authorize(Roles = $"{nameof(RoleEnum.Admin)},{nameof(RoleEnum.Moderator)}")]
		public async Task<IActionResult> DeleteGamePlatform([FromRoute] Guid gamePlatformId, CancellationToken ct)
		{
			await serviceManager.GamePlatformService.DeleteGamePlatform(gamePlatformId, ct);
			return NoContent();
		}
	}
}
