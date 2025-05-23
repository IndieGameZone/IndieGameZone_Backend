using IndieGameZone.Domain.Entities;

namespace IndieGameZone.Infrastructure.Extensions
{
	public static class AgeRestrictionRepositoryExtension
	{
		public static IQueryable<AgeRestrictions> Sort(this IQueryable<AgeRestrictions> source)
		{
			return source.OrderBy(c => c.Code);
		}
	}
}
