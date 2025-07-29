using IndieGameZone.Domain.Entities;

namespace IndieGameZone.Infrastructure.Extensions
{
	public static class OrderRepositoryExtension
	{
		public static IQueryable<Orders> Sort(this IQueryable<Orders> source)
		{
			return source.OrderByDescending(x => x.CreatedAt);
		}
	}
}
