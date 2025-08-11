using IndieGameZone.Application.Hub;
using IndieGameZone.Application.IHub;
using IndieGameZone.Application.IServices;
using IndieGameZone.Domain.RequestsAndResponses.Responses.Notifications;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.SignalR;

namespace IndieGameZone.API.Controllers
{
	[ApiController]
	[Route("api/test")]
	public class TestController : ControllerBase
	{
		private readonly IServiceManager serviceManager;
		private readonly IHubContext<NotificationHub, INotificationHub> notificationHub;

		public TestController(IServiceManager serviceManager, IHubContext<NotificationHub, INotificationHub> notificationHub)
		{
			this.serviceManager = serviceManager;
			this.notificationHub = notificationHub;
		}

		[HttpGet("public")]
		public IActionResult Public() => Ok("Public endpoint");

		[Authorize]
		[HttpGet("protected")]
		public IActionResult Protected() => Ok("Protected endpoint");

		[HttpPost("run-status-update")]
		public async Task<IActionResult> RunStatusUpdate(CancellationToken ct)
		{
			var updatedCount = await serviceManager.CommercialPackageService.RunStatusUpdateAsync(ct);
			return Ok($"✅ Updated {updatedCount} commercial registration statuses.");
		}

		[HttpGet("users/{userId:guid}/test-signalR")]
		[Authorize]
		public async Task<IActionResult> TestSignalR([FromRoute] Guid userId)
		{
			await notificationHub.Clients.User(userId.ToString()).SendNotification(new NotificationForReturnDto
			{
				Id = Guid.NewGuid(),
				Message = "This is a test notification from SignalR.",
				IsRead = false
			});
			return Ok("SignalR sent.");
		}
	}

}
