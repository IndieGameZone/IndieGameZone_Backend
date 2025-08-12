using IndieGameZone.Domain.Entities;
using IndieGameZone.Domain.RequestFeatures;

namespace IndieGameZone.Domain.IRepositories
{
	public interface INotificationRepository
	{
		Task<PagedList<Notifications>> GetNotificationByUserId(Guid userId, bool trackChange, NotificationParameters notificationParameters, CancellationToken ct = default);
		Task<IEnumerable<Notifications>> GetUnReadNotificationsByUserId(Guid userId, bool trackChange, CancellationToken ct = default);
		Task<Notifications?> GetNotificationById(Guid id, bool trackChange, CancellationToken ct = default);
		void CreateNotification(Notifications notification);
	}
}
