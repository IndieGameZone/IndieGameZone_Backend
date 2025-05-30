using IndieGameZone.Domain.Entities;

namespace IndieGameZone.Infrastructure.Extensions
{
	public static class GameStatusRepositoryExtension
	{
		public static IQueryable<GameTypes> Sort(this IQueryable<GameTypes> source)
		{
			return source.OrderBy(c => c.Name);
		}
	}
}
