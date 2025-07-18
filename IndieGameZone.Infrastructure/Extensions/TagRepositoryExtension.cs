using IndieGameZone.Domain.Constants;
using IndieGameZone.Domain.Entities;

namespace IndieGameZone.Infrastructure.Extensions
{
	public static class TagRepositoryExtension
	{
		public static IQueryable<Tags> Sort(this IQueryable<Tags> source)
		{
			return source.OrderBy(x => x.Name);
		}

		public static IQueryable<Tags> FilterByType(this IQueryable<Tags> source, TagTypeEnum tagTypeEnum)
		{
			return source.Where(x => x.Type == tagTypeEnum);
		}
	}
}
