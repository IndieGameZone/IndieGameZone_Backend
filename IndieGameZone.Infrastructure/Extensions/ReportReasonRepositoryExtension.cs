using IndieGameZone.Domain.Entities;

namespace IndieGameZone.Infrastructure.Extensions
{
	public static class ReportReasonRepositoryExtension
	{
		public static IQueryable<ReportReasons> Sort(this IQueryable<ReportReasons> source)
		{
			return source.OrderBy(x => x.Name);
		}
	}
}
