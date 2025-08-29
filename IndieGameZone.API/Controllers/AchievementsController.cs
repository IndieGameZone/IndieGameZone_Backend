using IndieGameZone.Application.IServices;
using IndieGameZone.Domain.Constants;
using IndieGameZone.Domain.RequestFeatures;
using IndieGameZone.Domain.RequestsAndResponses.Requests.Achievements;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Text.Json;

namespace IndieGameZone.API.Controllers
{
	[Route("api")]
	[ApiController]
	public class AchievementsController : ControllerBase
	{
		private readonly IServiceManager serviceManager;

		public AchievementsController(IServiceManager serviceManager)
		{
			this.serviceManager = serviceManager;
		}

		[HttpGet("achievements")]
		[Authorize]
		public async Task<IActionResult> GetAchievements([FromQuery] AchievementParameters achievementParameters, CancellationToken ct)
		{
			var pagedResult = await serviceManager.AchievementService.GetAchievements(achievementParameters, ct);
			Response.Headers.Append("X-Pagination", JsonSerializer.Serialize(pagedResult.metaData));
			return Ok(pagedResult.achievements);
		}

		[HttpGet("achievements/{id:guid}")]
		[Authorize]
		public async Task<IActionResult> GetAchievementById([FromRoute] Guid id, CancellationToken ct)
		{
			var achievement = await serviceManager.AchievementService.GetAchievementById(id, ct);
			return Ok(achievement);
		}

		[HttpGet("users/{userId:guid}/obtained-achievements")]
		[Authorize]
		public async Task<IActionResult> GetObtainedAchievements([FromRoute] Guid userId, [FromQuery] AchievementParameters achievementParameters, CancellationToken ct)
		{
			var pagedResult = await serviceManager.AchievementService.GetObtainedAchievementsByUser(userId, achievementParameters, ct);
			Response.Headers.Append("X-Pagination", JsonSerializer.Serialize(pagedResult.metaData));
			return Ok(pagedResult.achievements);
		}

		[HttpGet("users/{userId:guid}/none-obtained-achievements")]
		[Authorize]
		public async Task<IActionResult> GetUnobtainedAchievements([FromRoute] Guid userId, [FromQuery] AchievementParameters achievementParameters, CancellationToken ct)
		{
			var pagedResult = await serviceManager.AchievementService.GetUnobtainedAchievementsByUser(userId, achievementParameters, ct);
			Response.Headers.Append("X-Pagination", JsonSerializer.Serialize(pagedResult.metaData));
			return Ok(pagedResult.achievements);
		}

		[HttpPost("achievements")]
		[Authorize(Roles = $"{nameof(RoleEnum.Admin)}")]
		public async Task<IActionResult> CreateAchievement([FromBody] AchievementForCreationDto achievementForCreationDto, CancellationToken ct)
		{
			await serviceManager.AchievementService.CreateAchievement(achievementForCreationDto, ct);
			return StatusCode(201);
		}

		[HttpPut("achievements/{id:guid}")]
		[Authorize(Roles = $"{nameof(RoleEnum.Admin)}")]
		public async Task<IActionResult> UpdateAchievement([FromRoute] Guid id, [FromBody] AchievementForUpdateDto achievementForUpdateDto, CancellationToken ct)
		{
			await serviceManager.AchievementService.UpdateAchievement(id, achievementForUpdateDto, ct);
			return NoContent();
		}

		[HttpDelete("achievements/{id:guid}")]
		[Authorize(Roles = $"{nameof(RoleEnum.Admin)}")]
		public async Task<IActionResult> DeleteAchievement([FromRoute] Guid id, CancellationToken ct)
		{
			await serviceManager.AchievementService.DeleteAchievement(id, ct);
			return NoContent();
		}
	}
}
