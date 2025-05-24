using IndieGameZone.Application;
using IndieGameZone.Domain.RequestFeatures;
using IndieGameZone.Domain.RequestsAndResponses.Requests.Achievements;
using Microsoft.AspNetCore.Mvc;
using System.Text.Json;

namespace IndieGameZone.API.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class AchievementsController : ControllerBase
	{
		private readonly IServiceManager serviceManager;

		public AchievementsController(IServiceManager serviceManager)
		{
			this.serviceManager = serviceManager;
		}

		[HttpGet]
		public async Task<IActionResult> GetAchievements([FromQuery] AchievementParameters achievementParameters, CancellationToken ct)
		{
			var pagedResult = await serviceManager.AchievementService.GetAchievements(achievementParameters, ct);
			Response.Headers.Append("X-Pagination", JsonSerializer.Serialize(pagedResult.metaData));
			return Ok(pagedResult.achievements);
		}

		[HttpGet("{id:guid}")]
		public async Task<IActionResult> GetAchievementById([FromRoute] Guid id, CancellationToken ct)
		{
			var achievement = await serviceManager.AchievementService.GetAchievementById(id, ct);
			return Ok(achievement);
		}

		[HttpPost]
		public async Task<IActionResult> CreateAchievement([FromBody] AchievementForCreationDto achievementForCreationDto, CancellationToken ct)
		{
			await serviceManager.AchievementService.CreateAchievement(achievementForCreationDto, ct);
			return StatusCode(201);
		}

		[HttpPut("{id:guid}")]
		public async Task<IActionResult> UpdateAchievement([FromRoute] Guid id, [FromBody] AchievementForUpdateDto achievementForUpdateDto, CancellationToken ct)
		{
			await serviceManager.AchievementService.UpdateAchievement(id, achievementForUpdateDto, ct);
			return NoContent();
		}

		[HttpDelete("{id:guid}")]
		public async Task<IActionResult> DeleteAchievement([FromRoute] Guid id, CancellationToken ct)
		{
			await serviceManager.AchievementService.DeleteAchievement(id, ct);
			return NoContent();
		}
	}
}
