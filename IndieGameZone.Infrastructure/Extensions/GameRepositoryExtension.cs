using IndieGameZone.Domain.Entities;

namespace IndieGameZone.Infrastructure.Extensions
{
	public static class GameRepositoryExtension
	{
		public static IQueryable<Games> Sort(this IQueryable<Games> source)
		{
			return source.OrderByDescending(x => x.CreatedAt);
		}
	}
}
