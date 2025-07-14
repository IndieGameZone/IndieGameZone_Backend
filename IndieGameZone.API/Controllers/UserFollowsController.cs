using IndieGameZone.Application.IServices;
using IndieGameZone.Domain.Constants;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace IndieGameZone.API.Controllers
{
	[Route("api")]
	[ApiController]
	public class UserFollowsController : ControllerBase
	{
		private readonly IServiceManager serviceManager;

		public UserFollowsController(IServiceManager serviceManager)
		{
			this.serviceManager = serviceManager;
		}

		[HttpPost("followers/{followerId:guid}/followees/{followeeId:guid}/user-follows")]
		[Authorize(Roles = $"{nameof(RoleEnum.Player)},{nameof(RoleEnum.Developer)}")]
		public async Task<IActionResult> FollowDeveloperAsync([FromRoute] Guid followerId, [FromRoute] Guid followeeId, CancellationToken ct)
		{
			await serviceManager.UserFollowService.FollowOrUnfollowUser(followerId, followeeId, ct);
			return StatusCode(201);
		}

		[HttpGet("followers/{followerId:guid}/followees/{followeeId:guid}/user-follows")]
		[Authorize(Roles = $"{nameof(RoleEnum.Player)},{nameof(RoleEnum.Developer)}")]
		public async Task<IActionResult> IsDeveloperFollowedByPlayerAsync([FromRoute] Guid followerId, [FromRoute] Guid followeeId, CancellationToken ct)
		{
			var isFollowed = await serviceManager.UserFollowService.IsFollowing(followerId, followeeId, ct);
			return Ok(isFollowed);
		}

		[HttpGet("followees/{followeeId:guid}/number-of-followers")]
		[Authorize(Roles = $"{nameof(RoleEnum.Player)}")]
		public async Task<IActionResult> GetNumberOfFollowers([FromRoute] Guid followeeId, CancellationToken ct)
		{
			var numberOfFollowers = await serviceManager.UserFollowService.GetNumberOfFollower(followeeId, ct);
			return Ok(numberOfFollowers);
		}

		[HttpGet("followers/{followerId:guid}/number-of-followees")]
		[Authorize(Roles = $"{nameof(RoleEnum.Developer)}")]
		public async Task<IActionResult> GetNumberOfFollowees([FromRoute] Guid followerId, CancellationToken ct)
		{
			var numberOfFollowers = await serviceManager.UserFollowService.GetNumberOfFollowee(followerId, ct);
			return Ok(numberOfFollowers);
		}
	}
}
