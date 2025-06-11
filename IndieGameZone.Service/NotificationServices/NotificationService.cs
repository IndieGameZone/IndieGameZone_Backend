using IndieGameZone.Domain.Exceptions;
using IndieGameZone.Domain.IRepositories;
using IndieGameZone.Domain.RequestFeatures;
using IndieGameZone.Domain.RequestsAndResponses.Responses.Notifications;
using MapsterMapper;

namespace IndieGameZone.Application.NotificationServices
{
	internal sealed class NotificationService : INotificationService
	{
		private readonly IRepositoryManager repositoryManager;
		private readonly IMapper mapper;

		public NotificationService(IRepositoryManager repositoryManager, IMapper mapper)
		{
			this.repositoryManager = repositoryManager;
			this.mapper = mapper;
		}
		public async Task<(IEnumerable<NotificationForReturnDto> notifications, MetaData metaData)> GetNotificationsByUserId(Guid userId, NotificationParameters notificationParameters, CancellationToken ct = default)
		{
			var notificationsWithMetaData = await repositoryManager.NotificationRepository.GetNotificationByUserId(userId, false, notificationParameters, ct);
			var notifications = mapper.Map<IEnumerable<NotificationForReturnDto>>(notificationsWithMetaData);
			return (notifications, notificationsWithMetaData.MetaData);
		}

		public async Task UpdateNotificationStatus(Guid id, CancellationToken ct = default)
		{
			var notification = await repositoryManager.NotificationRepository.GetNotificationById(id, true, ct);
			if (notification is null)
			{
				throw new NotFoundException($"Notification not found.");
			}
			notification.IsRead = true;
			notification.ReadAt = DateTime.Now;
			await repositoryManager.SaveAsync(ct);
		}
	}
}
