using IndieGameZone.Domain.Entities;

namespace IndieGameZone.Infrastructure.Extensions
{
	public static class WithdrawRequestRepositoryExtension
	{
		public static IQueryable<WithdrawRequests> Sort(this IQueryable<WithdrawRequests> source)
		{
			return source.OrderByDescending(w => w.CreatedAt);
		}
	}
}
