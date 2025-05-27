using IndieGameZone.Domain.Entities;

namespace IndieGameZone.Infrastructure.Extensions
{
	public static class WishlistRepositoryExtension
	{
		public static IQueryable<Wishlists> Sort(this IQueryable<Wishlists> source)
		{
			return source.OrderByDescending(w => w.AddedAt);
		}
	}
}
