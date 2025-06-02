using IndieGameZone.Domain.Entities;

namespace IndieGameZone.Infrastructure.Extensions
{
	public static class PostCommentRepositoryExtension
	{
		public static IQueryable<PostComments> Sort(this IQueryable<PostComments> source)
		{
			return source.OrderByDescending(c => c.UpdatedAt).ThenByDescending(c => c.CreatedAt);
		}
	}
}
