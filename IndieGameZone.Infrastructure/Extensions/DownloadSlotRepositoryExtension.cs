using IndieGameZone.Domain.Entities;

namespace IndieGameZone.Infrastructure.Extensions
{
	public static class DownloadSlotRepositoryExtension
	{
		public static IQueryable<DownloadSlots> FilterByMonthAndYear(this IQueryable<DownloadSlots> query, int year, int month)
		{
			return query.Where(ds => ds.DownloadAt.Year == year && ds.DownloadAt.Month == month);
		}
	}
}
