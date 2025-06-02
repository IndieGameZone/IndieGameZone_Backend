using IndieGameZone.Domain.Entities;

namespace IndieGameZone.Infrastructure.Extensions
{
	public static class PostRepositoryExtension
	{
		public static IQueryable<Posts> Sort(this IQueryable<Posts> source)
		{
			return source.OrderByDescending(p => p.UpdatedAt).ThenByDescending(p => p.CreatedAt);
		}
	}
}
