using IndieGameZone.Domain.Entities;
using IndieGameZone.Domain.IRepositories;
using IndieGameZone.Infrastructure.Persistence;
using Microsoft.EntityFrameworkCore;

namespace IndieGameZone.Infrastructure.Repositories
{
	internal sealed class OrderRepository : RepositoryBase<Orders>, IOrderRepository
	{
		public OrderRepository(AppDbContext appDbContext) : base(appDbContext)
		{
		}

		public void CreateOrder(Orders orders) => Create(orders);

		public async Task<Orders?> GetOrderByCode(long orderCode, bool trackChange, CancellationToken ct = default) => await FindByCondition(x => x.OrderCode == orderCode, trackChange).FirstOrDefaultAsync(ct);
	}
}
