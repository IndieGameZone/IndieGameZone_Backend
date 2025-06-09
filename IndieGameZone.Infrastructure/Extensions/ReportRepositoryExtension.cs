using IndieGameZone.Domain.Entities;

namespace IndieGameZone.Infrastructure.Extensions
{
	public static class ReportRepositoryExtension
	{
		public static IQueryable<Reports> Sort(this IQueryable<Reports> source)
		{
			return source.OrderByDescending(r => r.CreatedAt);
		}
	}
}
