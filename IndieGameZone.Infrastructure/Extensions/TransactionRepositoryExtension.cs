using IndieGameZone.Domain.Constants;
using IndieGameZone.Domain.Entities;

namespace IndieGameZone.Infrastructure.Extensions
{
	public static class TransactionRepositoryExtension
	{
		public static IQueryable<Transactions> Sort(this IQueryable<Transactions> source)
		{
			return source.OrderByDescending(x => x.CreatedAt);
		}

		public static IQueryable<Transactions> FilterByTransactionTypes(this IQueryable<Transactions> source, ICollection<TransactionType> transactionTypes)
		{
			if (transactionTypes == null || !transactionTypes.Any())
			{
				return source;
			}
			return source.Where(x => transactionTypes.Contains(x.Type));
		}
	}
}
