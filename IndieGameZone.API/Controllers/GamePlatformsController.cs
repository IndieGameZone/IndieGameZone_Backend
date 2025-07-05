using IndieGameZone.Application;
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
		public async Task<IActionResult> UpdateGamePlatform([FromRoute] Guid gameId, [FromBody] ICollection<GamePlatformForUpdateDto> gamePlatformForUpdateDtos, CancellationToken ct)
		{
			await serviceManager.GamePlatformService.UpdateGamePlatform(gameId, gamePlatformForUpdateDtos, ct);
			return NoContent();
		}

		[HttpPut("developers/{developerId}/game-platforms/{gamePlatformId:guid}/activation")]
		[Authorize(Roles = $"{nameof(RoleEnum.Admin)},{nameof(RoleEnum.Moderator)},{nameof(RoleEnum.Developer)}")]
		public async Task<IActionResult> UpdateGamePlatformActivationStatus([FromRoute] Guid developerId, [FromRoute] Guid gamePlatformId, [FromForm] bool isActive, CancellationToken ct)
		{
			await serviceManager.GamePlatformService.UpdateGamePlatformActivationStatus(developerId, gamePlatformId, isActive, ct);
			return NoContent();
		}
	}
}
