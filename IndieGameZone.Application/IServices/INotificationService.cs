using IndieGameZone.Domain.RequestFeatures;
using IndieGameZone.Domain.RequestsAndResponses.Responses.Notifications;

namespace IndieGameZone.Application.IServices
{
	public interface INotificationService
	{
		Task UpdateNotificationStatus(Guid id, CancellationToken ct = default);
		Task<(IEnumerable<NotificationForReturnDto> notifications, MetaData metaData)> GetNotificationsByUserId(Guid userId, NotificationParameters notificationParameters, CancellationToken ct = default);
	}
}
