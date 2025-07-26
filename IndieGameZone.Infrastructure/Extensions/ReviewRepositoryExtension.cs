using IndieGameZone.Domain.Entities;

namespace IndieGameZone.Infrastructure.Extensions
{
	public static class ReviewRepositoryExtension
	{
		public static IQueryable<Domain.Entities.Reviews> Sort(this IQueryable<Domain.Entities.Reviews> source)
		{
			return source.OrderByDescending(r => r.CreatedAt);
		}

		public static IQueryable<Reviews> FIlterByRating(this IQueryable<Domain.Entities.Reviews> source, string? rating)
		{
			if (string.IsNullOrEmpty(rating))
			{
				return source;
			}
			if (int.TryParse(rating, out int stars))
			{
				return source.Where(r => r.Rating == stars);
			}
			return source;
		}
	}
}
