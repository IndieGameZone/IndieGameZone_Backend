using IndieGameZone.Domain.Entities;

namespace IndieGameZone.Infrastructure.Extensions
{
	public static class LanguageRepositoryExtension
	{
		public static IQueryable<Languages> Sort(this IQueryable<Languages> source)
		{
			return source.OrderBy(x => x.Name);
		}
	}
}
