using IndieGameZone.Domain.Entities;

namespace IndieGameZone.Infrastructure.Extensions
{
	public static class GameCensorLogRepositoryExtension
	{
		public static IQueryable<GameCensorLogs> Sort(this IQueryable<GameCensorLogs> source)
		{
			return source.OrderByDescending(x => x.CreatedAt);
		}
	}
}
