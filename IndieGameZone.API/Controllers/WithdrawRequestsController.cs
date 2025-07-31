using IndieGameZone.Application.IServices;
using IndieGameZone.Domain.Constants;
using IndieGameZone.Domain.RequestFeatures;
using IndieGameZone.Domain.RequestsAndResponses.Requests.WithdrawRequests;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Text.Json;

namespace IndieGameZone.API.Controllers
{
	[Route("api")]
	[ApiController]
	public class WithdrawRequestsController : ControllerBase
	{
		private readonly IServiceManager serviceManager;

		public WithdrawRequestsController(IServiceManager serviceManager)
		{
			this.serviceManager = serviceManager;
		}

		[HttpGet("withdraw-requests")]
		[Authorize(Roles = $"{nameof(RoleEnum.Admin)},{nameof(RoleEnum.Moderator)}")]
		public async Task<IActionResult> GetWithdrawRequests([FromQuery] WithdrawRequestParameter withdrawRequestParameter, CancellationToken ct)
		{
			var pagedResult = await serviceManager.WithdrawRequestService.GetWithdrawRequests(withdrawRequestParameter, ct);
			Response.Headers.Append("X-Pagination", JsonSerializer.Serialize(pagedResult.metaData));
			return Ok(pagedResult.withdrawRequests);
		}

		[HttpGet("users/{userId:guid}/withdraw-requests")]
		[Authorize(Roles = $"{nameof(RoleEnum.Admin)},{nameof(RoleEnum.Moderator)},{nameof(RoleEnum.Developer)}")]
		public async Task<IActionResult> GetWithdrawRequestsByUserId([FromRoute] Guid userId, [FromQuery] WithdrawRequestParameter withdrawRequestParameter, CancellationToken ct)
		{
			var pagedResult = await serviceManager.WithdrawRequestService.GetWithdrawRequestsByUserId(userId, withdrawRequestParameter, ct);
			Response.Headers.Append("X-Pagination", JsonSerializer.Serialize(pagedResult.metaData));
			return Ok(pagedResult.withdrawRequests);
		}

		[HttpPost("users/{userId:guid}/withdraw-requests")]
		[Authorize(Roles = $"{nameof(RoleEnum.Developer)}")]
		public async Task<IActionResult> CreateWithdrawRequest([FromRoute] Guid userId, [FromForm] WithdrawRequestForCreationDto withdrawRequestForCreationDto, CancellationToken ct)
		{
			await serviceManager.WithdrawRequestService.CreateWithdrawRequest(userId, withdrawRequestForCreationDto, ct);
			return StatusCode(201);
		}

		[HttpPut("withdraw-requests/{id:guid}")]
		[Authorize(Roles = $"{nameof(RoleEnum.Admin)},{nameof(RoleEnum.Moderator)}")]
		public async Task<IActionResult> UpdateWithdrawRequestImageProof([FromRoute] Guid id, [FromForm] WithdrawRequestForUpdateDto withdrawRequestForUpdateDto, CancellationToken ct)
		{
			await serviceManager.WithdrawRequestService.UpdateWithdrawRequest(id, withdrawRequestForUpdateDto, ct);
			return NoContent();
		}
	}
}
