using IndieGameZone.Domain.Constants;
using IndieGameZone.Domain.Entities;

namespace IndieGameZone.Infrastructure.Extensions
{
	public static class GameRepositoryExtension
	{
		public static IQueryable<Games> Sort(this IQueryable<Games> source)
		{
			return source.OrderByDescending(x => x.CreatedAt);
		}

		public static IQueryable<Games> Search(this IQueryable<Games> source, string? searchTerm)
		{
			if (string.IsNullOrWhiteSpace(searchTerm))
			{
				return source;
			}
			return source.Where(x => x.Name.ToLower().Contains(searchTerm.ToLower()));
		}

		public static IQueryable<Games> FilterByCensorStatus(this IQueryable<Games> source, CensorStatus censorStatus)
		{
			return source.Where(x => x.CensorStatus == censorStatus);
		}
	}
}
