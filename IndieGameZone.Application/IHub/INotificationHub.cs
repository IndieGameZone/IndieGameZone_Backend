using IndieGameZone.Domain.RequestsAndResponses.Responses.Notifications;

namespace IndieGameZone.Application.IHub
{
	public interface INotificationHub
	{
		Task SendNotification(NotificationForReturnDto notifications);
	}
}
