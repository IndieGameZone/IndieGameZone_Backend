using IndieGameZone.Domain.Entities;

namespace IndieGameZone.Infrastructure.Extensions
{
	public static class PostRepositoryExtension
	{
		public static IQueryable<Posts> Sort(this IQueryable<Posts> source)
		{
			return source.OrderByDescending(p => p.UpdatedAt).ThenByDescending(p => p.CreatedAt);
		}

		public static IQueryable<Posts> FilterByTags(this IQueryable<Posts> source, ICollection<Guid> tags)
		{
			if (tags == null || !tags.Any())
			{
				return source;
			}
			return source.Where(x => x.PostTags.Any(gt => tags.Contains(gt.TagId)));
		}
	}
}
