using IndieGameZone.Domain.Entities;

namespace IndieGameZone.Infrastructure.Extensions
{
	public static class LibraryRepositoryExtension
	{
		public static IQueryable<Libraries> Sort(this IQueryable<Libraries> source)
		{
			return source.OrderByDescending(l => l.PurchasedAt);
		}
	}
}
