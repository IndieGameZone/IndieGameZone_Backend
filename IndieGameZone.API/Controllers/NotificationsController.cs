using IndieGameZone.Application.IServices;
using IndieGameZone.Domain.RequestFeatures;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Text.Json;

namespace IndieGameZone.API.Controllers
{
	[Route("api")]
	[ApiController]
	public class NotificationsController : ControllerBase
	{
		private readonly IServiceManager serviceManager;

		public NotificationsController(IServiceManager serviceManager)
		{
			this.serviceManager = serviceManager;
		}

		[HttpGet("users/{userId:guid}/notifications")]
		[Authorize]
		public async Task<IActionResult> GetNotificationsByUserId([FromRoute] Guid userId, [FromQuery] NotificationParameters notificationParameters, CancellationToken ct)
		{
			var pagedResult = await serviceManager.NotificationService.GetNotificationsByUserId(userId, notificationParameters, ct);
			Response.Headers.Append("X-Pagination", JsonSerializer.Serialize(pagedResult.metaData));
			return Ok(pagedResult.notifications);
		}

		[HttpPut("notifications/{notificationId:guid}")]
		[Authorize]
		public async Task<IActionResult> UpdateNotificationStatus([FromRoute] Guid notificationId, CancellationToken ct)
		{
			await serviceManager.NotificationService.UpdateNotificationStatus(notificationId, ct);
			return NoContent();
		}
	}
}
