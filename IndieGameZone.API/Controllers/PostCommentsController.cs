using IndieGameZone.Application;
using IndieGameZone.Domain.RequestFeatures;
using IndieGameZone.Domain.RequestsAndResponses.Requests.PostComments;
using Microsoft.AspNetCore.Mvc;
using System.Text.Json;

namespace IndieGameZone.API.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class PostCommentsController : ControllerBase
	{
		private readonly IServiceManager serviceManager;

		public PostCommentsController(IServiceManager serviceManager)
		{
			this.serviceManager = serviceManager;
		}

		[HttpGet("posts/{postId:guid}/post-comments")]
		public async Task<IActionResult> GetPostComments([FromRoute] Guid postId, [FromQuery] PostCommentParameters postCommentParameters, CancellationToken ct)
		{
			var pagedResult = await serviceManager.PostCommentService.GetCommentsByPostId(postId, postCommentParameters, ct);
			Response.Headers.Append("X-Pagination", JsonSerializer.Serialize(pagedResult.metaData));
			return Ok(pagedResult.comments);
		}

		[HttpPost("posts/{postId:guid}/users/{userId:guid}/post-comments")]
		public async Task<IActionResult> CreatePostComment([FromRoute] Guid userId, [FromRoute] Guid postId, [FromBody] PostCommentForCreationDto postCommentForCreationDto, CancellationToken ct)
		{
			await serviceManager.PostCommentService.CreateComment(userId, postId, postCommentForCreationDto, ct);
			return StatusCode(201);
		}

		[HttpPut("users/{userId:guid}/post-comments/{commentId:guid}")]
		public async Task<IActionResult> UpdatePostComment([FromRoute] Guid userId, [FromRoute] Guid commentId, [FromBody] PostCommentForUpdateDto postCommentForUpdateDto, CancellationToken ct)
		{
			await serviceManager.PostCommentService.UpdateComment(userId, commentId, postCommentForUpdateDto, ct);
			return NoContent();
		}

		[HttpDelete("users/{userId:guid}/post-comments/{commentId:guid}")]
		public async Task<IActionResult> DeletePostComment([FromRoute] Guid userId, [FromRoute] Guid commentId, CancellationToken ct)
		{
			await serviceManager.PostCommentService.DeleteComment(userId, commentId, ct);
			return NoContent();
		}
	}
}
