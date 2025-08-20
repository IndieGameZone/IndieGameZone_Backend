using IndieGameZone.Domain.Entities;
using IndieGameZone.Domain.IRepositories;
using IndieGameZone.Domain.RequestFeatures;
using IndieGameZone.Infrastructure.Extensions;
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

		public Task<Orders?> GetOrderByGameAndUser(Guid gameId, Guid userId, bool trackChange, CancellationToken ct = default) => FindByCondition(x => x.GameId == gameId && x.UserId == userId, trackChange).Include(x => x.ActivationKey).FirstOrDefaultAsync(ct);

		public async Task<Orders?> GetOrderById(Guid id, bool trackChange, CancellationToken ct = default) => await FindByCondition(x => x.Id == id, trackChange)
			.Include(x => x.Game)
			.Include(x => x.CommercialPackage)
			.Include(x => x.Transaction)
			.Include(x => x.ActivationKey)
			.FirstOrDefaultAsync(ct);

		public async Task<PagedList<Orders>> GetOrdersByUserId(Guid userId, OrderParameters orderParameters, bool trackChange, CancellationToken ct = default)
		{
			var orders = FindByCondition(x => x.UserId == userId, trackChange)
				.Include(x => x.Game)
				.Include(x => x.CommercialPackage)
				.Include(x => x.Transaction)
				.Include(x => x.ActivationKey)
				.Sort();

			return await PagedList<Orders>.ToPagedList(orders, orderParameters.PageNumber, orderParameters.PageSize, ct);
		}
	}
}
