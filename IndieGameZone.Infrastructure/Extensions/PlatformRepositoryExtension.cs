using IndieGameZone.Domain.Entities;

namespace IndieGameZone.Infrastructure.Extensions
{
	public static class PlatformRepositoryExtension
	{
		public static IQueryable<Platforms> Sort(this IQueryable<Platforms> source)
		{
			return source.OrderBy(x => x.Name);
		}
	}
}
