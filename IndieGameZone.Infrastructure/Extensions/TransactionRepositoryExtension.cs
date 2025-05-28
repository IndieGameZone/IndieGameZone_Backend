using IndieGameZone.Domain.Entities;

namespace IndieGameZone.Infrastructure.Extensions
{
	public static class TransactionRepositoryExtension
	{
		public static IQueryable<Transactions> Sort(this IQueryable<Transactions> source)
		{
			return source.OrderByDescending(x => x.CreatedAt);
		}
	}
}
