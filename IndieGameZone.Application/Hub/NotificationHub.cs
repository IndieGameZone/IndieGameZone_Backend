using IndieGameZone.Application.IHub;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.SignalR;

namespace IndieGameZone.Application.Hub
{
	[Authorize]
	public sealed class NotificationHub : Hub<INotificationHub>
	{

	}
}
