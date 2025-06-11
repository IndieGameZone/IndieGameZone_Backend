using IndieGameZone.Domain.Entities;
using IndieGameZone.Domain.IRepositories;
using IndieGameZone.Domain.RequestFeatures;
using IndieGameZone.Infrastructure.Extensions;
using IndieGameZone.Infrastructure.Persistence;
using Microsoft.EntityFrameworkCore;

namespace IndieGameZone.Infrastructure.Repositories
{
	internal sealed class NotificationRepository : RepositoryBase<Notifications>, INotificationRepository
	{
		public NotificationRepository(AppDbContext appDbContext) : base(appDbContext)
		{
		}

		public async Task<Notifications?> GetNotificationById(Guid id, bool trackChange, CancellationToken ct = default) => await
			FindByCondition(n => n.Id.Equals(id), trackChange).FirstOrDefaultAsync(ct);

		public async Task<PagedList<Notifications>> GetNotificationByUserId(Guid userId, bool trackChange, NotificationParameters notificationParameters, CancellationToken ct = default)
		{
			var notifications = FindByCondition(n => n.UserId.Equals(userId), trackChange)
				.Sort();

			return await PagedList<Notifications>.ToPagedList(notifications, notificationParameters.PageNumber, notificationParameters.PageSize, ct);

		}
	}
}
