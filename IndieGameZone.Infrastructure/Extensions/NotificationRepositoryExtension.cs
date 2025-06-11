using IndieGameZone.Domain.Entities;

namespace IndieGameZone.Infrastructure.Extensions
{
	public static class NotificationRepositoryExtension
	{
		public static IQueryable<Notifications> Sort(this IQueryable<Notifications> source)
		{
			return source.OrderByDescending(n => n.CreatedAt);
		}
	}
}
