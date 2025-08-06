using IndieGameZone.Application.IServices;
using IndieGameZone.Domain.Constants;
using IndieGameZone.Domain.RequestFeatures;
using IndieGameZone.Domain.RequestsAndResponses.Requests.Posts;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Text.Json;

namespace IndieGameZone.API.Controllers
{
	[Route("api")]
	[ApiController]
	public class PostsController : ControllerBase
	{
		private readonly IServiceManager serviceManager;

		public PostsController(IServiceManager serviceManager)
		{
			this.serviceManager = serviceManager;
		}

		[HttpPost("users/{userId:guid}/games/{gameId:guid}/posts")]
		[Authorize]
		public async Task<IActionResult> CreatePost(Guid userId, Guid gameId, [FromForm] PostForCreationDto postForCreationDto, CancellationToken ct)
		{
			await serviceManager.PostService.CreatePost(userId, gameId, postForCreationDto, ct);
			return StatusCode(201);
		}

		[HttpDelete("users/{userId:guid}/posts/{postId:guid}")]
		[Authorize]
		public async Task<IActionResult> DeletePost(Guid userId, Guid postId, CancellationToken ct)
		{
			await serviceManager.PostService.DeletePost(userId, postId, ct);
			return NoContent();
		}

		[HttpGet("posts/{postId:guid}")]
		public async Task<IActionResult> GetPostById(Guid postId, CancellationToken ct)
		{
			var post = await serviceManager.PostService.GetPostById(postId, ct);
			return Ok(post);
		}

		[HttpGet("games/{gameId:guid}/posts")]
		public async Task<IActionResult> GetPostsByGameId(Guid gameId, [FromQuery] PostParameters postParameters, CancellationToken ct)
		{
			var pagedResult = await serviceManager.PostService.GetPostsByGameId(gameId, postParameters, ct);
			Response.Headers.Append("X-Pagination", JsonSerializer.Serialize(pagedResult.metaData));
			return Ok(pagedResult.posts);
		}

		[HttpGet("users/{userId:guid}/posts")]
		[Authorize]
		public async Task<IActionResult> GetPostsByUserId(Guid userId, [FromQuery] PostParameters postParameters, CancellationToken ct)
		{
			var pagedResult = await serviceManager.PostService.GetPostsByUserId(userId, postParameters, ct);
			Response.Headers.Append("X-Pagination", JsonSerializer.Serialize(pagedResult.metaData));
			return Ok(pagedResult.posts);
		}

		[HttpPut("users/{userId:guid}/posts/{postId:guid}")]
		[Authorize]
		public async Task<IActionResult> UpdatePost(Guid userId, Guid postId, [FromForm] PostForUpdateDto postForUpdateDto, CancellationToken ct)
		{
			await serviceManager.PostService.UpdatePost(userId, postId, postForUpdateDto, ct);
			return NoContent();
		}

		[HttpPut("posts/{postId:guid}/post-status")]
		[Authorize(Roles = $"{nameof(RoleEnum.Admin)},{nameof(RoleEnum.Moderator)}")]
		public async Task<IActionResult> UpdatePostStatus([FromRoute] Guid postId, [FromForm] PostActivationDto postActivationDto, CancellationToken ct)
		{
			await serviceManager.PostService.UpdatePostStatus(postId, postActivationDto, ct);
			return NoContent();
		}

		[HttpGet("users/{userId:guid}/active-posts")]
		public async Task<IActionResult> GetActivePostsByUserId(Guid userId, [FromQuery] PostParameters postParameters, CancellationToken ct)
		{
			var pagedResult = await serviceManager.PostService.GetActivePostsByUserId(userId, postParameters, ct);
			Response.Headers.Append("X-Pagination", JsonSerializer.Serialize(pagedResult.metaData));
			return Ok(pagedResult.posts);
		}
	}
}
