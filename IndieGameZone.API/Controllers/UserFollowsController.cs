using IndieGameZone.Application;
using Microsoft.AspNetCore.Mvc;

namespace IndieGameZone.API.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class UserFollowsController : ControllerBase
	{
		private readonly IServiceManager serviceManager;

		public UserFollowsController(IServiceManager serviceManager)
		{
			this.serviceManager = serviceManager;
		}

		[HttpPost("players/{playerId:guid}/developers/{developerId:guid}/user-follows")]
		public async Task<IActionResult> FollowDeveloperAsync([FromRoute] Guid playerId, [FromRoute] Guid developerId, CancellationToken ct)
		{
			await serviceManager.UserFollowService.FollowOrUnfollowUser(playerId, developerId, ct);
			return StatusCode(201);
		}

		[HttpGet("players/{playerId:guid}/developers/{developerId:guid}/user-follows")]
		public async Task<IActionResult> IsDeveloperFollowedByPlayerAsync([FromRoute] Guid playerId, [FromRoute] Guid developerId, CancellationToken ct)
		{
			var isFollowed = await serviceManager.UserFollowService.IsFollowing(playerId, developerId, ct);
			return Ok(isFollowed);
		}

		[HttpGet("players/{playerId:guid}/number-of-following-users")]
		public async Task<IActionResult> GetNumberOfFollowingUsers([FromRoute] Guid playerId, CancellationToken ct)
		{
			var numberOfFollowers = await serviceManager.UserFollowService.GetFollowingUserNumber(playerId, ct);
			return Ok(numberOfFollowers);
		}

		[HttpGet("developers/{developerId:guid}/number-of-followed-users")]
		public async Task<IActionResult> GetNumberOfFollowedUsers([FromRoute] Guid developerId, CancellationToken ct)
		{
			var numberOfFollowers = await serviceManager.UserFollowService.GetFollowedUserNumber(developerId, ct);
			return Ok(numberOfFollowers);
		}
	}
}
