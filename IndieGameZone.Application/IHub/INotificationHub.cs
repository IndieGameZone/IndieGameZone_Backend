using IndieGameZone.Domain.Entities;

namespace IndieGameZone.Application.IHub
{
	public interface INotificationHub
	{
		Task SendNotification(Notifications notifications);
	}
}
