using IndieGameZone.Domain.Entities;

namespace IndieGameZone.Infrastructure.Extensions
{
	public static class CategoryRepositoryExtension
	{
		public static IQueryable<Categories> Sort(this IQueryable<Categories> source)
		{
			return source.OrderBy(c => c.Name);
		}
	}
}
