namespace IndieGameZone.Infrastructure.Extensions
{
	public static class ReviewRepositoryExtension
	{
		public static IQueryable<Domain.Entities.Reviews> Sort(this IQueryable<Domain.Entities.Reviews> source)
		{
			return source.OrderByDescending(r => r.CreatedAt);
		}
	}
}
