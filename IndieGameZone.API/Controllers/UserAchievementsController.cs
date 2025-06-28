using IndieGameZone.Application;
using IndieGameZone.Domain.RequestFeatures;
using Microsoft.AspNetCore.Mvc;
using System.Text.Json;

namespace IndieGameZone.API.Controllers
{
	[Route("api")]
	[ApiController]
	public class UserAchievementsController : ControllerBase
	{
		private readonly IServiceManager serviceManager;

		public UserAchievementsController(IServiceManager serviceManager)
		{
			this.serviceManager = serviceManager;
		}

		[HttpGet("users/{userId}/user-achievements")]
		public async Task<IActionResult> GetUserAchievements([FromRoute] Guid userId, [FromQuery] UserAchievementParameters userAchievementParameters, CancellationToken ct)
		{
			var pagedResult = await serviceManager.UserAchievementService.GetUserAchievementsForUser(userId, userAchievementParameters, ct);
			Response.Headers.Append("X-Pagination", JsonSerializer.Serialize(pagedResult.metaData));
			return Ok(pagedResult.userAchievements);
		}
	}
}
