using IndieGameZone.Domain.Entities;

namespace IndieGameZone.Infrastructure.Extensions
{
	public static class GamePriceLogRepositoryExtension
	{
		public static IQueryable<GamePriceLogs> Sort(this IQueryable<GamePriceLogs> gamePriceLogs)
		{
			return gamePriceLogs.OrderByDescending(x => x.CreatedAt);
		}
	}
}
