using IndieGameZone.Domain.Entities;

namespace IndieGameZone.Infrastructure.Extensions
{
	public static class GameStatusRepositoryExtension
	{
		public static IQueryable<GameStatuses> Sort(this IQueryable<GameStatuses> source)
		{
			return source.OrderBy(c => c.Name);
		}
	}
}
