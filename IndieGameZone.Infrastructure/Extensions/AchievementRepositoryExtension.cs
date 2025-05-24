using IndieGameZone.Domain.Entities;

namespace IndieGameZone.Infrastructure.Extensions
{
	public static class AchievementRepositoryExtension
	{
		public static IQueryable<Achievements> Sort(this IQueryable<Achievements> source)
		{
			return source.OrderBy(a => a.Name);
		}
	}
}
