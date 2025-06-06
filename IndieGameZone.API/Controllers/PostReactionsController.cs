using IndieGameZone.Application;
using Microsoft.AspNetCore.Mvc;

namespace IndieGameZone.API.Controllers
{
	[Route("api")]
	[ApiController]
	public class PostReactionsController : ControllerBase
	{
		private readonly IServiceManager serviceManager;

		public PostReactionsController(IServiceManager serviceManager)
		{
			this.serviceManager = serviceManager;
		}

		[HttpPost("users/{userId:guid}/posts/{postId:guid}/post-reactions")]
		public async Task<IActionResult> AddPostReactionAsync([FromRoute] Guid userId, [FromRoute] Guid postId, CancellationToken ct)
		{
			await serviceManager.PostReactionService.CreateOrDeleteReactions(userId, postId, ct);
			return StatusCode(201);
		}

		[HttpGet("posts/{postId:guid}/number-of-reactions")]
		public async Task<IActionResult> GetNumberOfReactionsAsync([FromRoute] Guid postId, CancellationToken ct)
		{
			var numberOfReactions = await serviceManager.PostReactionService.GetNumberOfLikesByPostId(postId, ct);
			return Ok(numberOfReactions);
		}

		[HttpGet("users/{userId:guid}/posts/{postId:guid}/post-reactions")]
		public async Task<IActionResult> IsPostLikedByUser([FromRoute] Guid userId, [FromRoute] Guid postId, CancellationToken ct)
		{
			var reaction = await serviceManager.PostReactionService.IsPostLikedByUser(userId, postId, ct);
			return Ok(reaction);
		}
	}
}
