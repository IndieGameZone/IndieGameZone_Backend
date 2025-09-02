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
			.Include(x => x.Game).ThenInclude(x => x.Category)
			.Include(x => x.CommercialPackage)
			.Include(x => x.Transaction)
			.Include(x => x.ActivationKey)
			.Include(x => x.Discount)
			.Include(x => x.User).ThenInclude(x => x.UserProfile)
			.FirstOrDefaultAsync(ct);

		public async Task<PagedList<Orders>> GetOrders(OrderParameters orderParameters, bool trackChange, CancellationToken ct = default)
		{
			var orders = FindAll(trackChange)
				.Include(x => x.Game)
				.Include(x => x.CommercialPackage)
				.Include(x => x.Transaction)
				.Include(x => x.User).ThenInclude(x => x.UserProfile)
				.Sort();
			return await PagedList<Orders>.ToPagedList(orders, orderParameters.PageNumber, orderParameters.PageSize, ct);
		}

		public async Task<PagedList<Orders>> GetOrdersByUserId(Guid userId, OrderParameters orderParameters, bool trackChange, CancellationToken ct = default)
		{
			var orders = FindByCondition(x => x.UserId == userId, trackChange)
				.Include(x => x.Game)
				.Include(x => x.CommercialPackage)
				.Include(x => x.Transaction)
				.Include(x => x.ActivationKey)
				.Include(x => x.User).ThenInclude(x => x.UserProfile)
				.Sort();

			return await PagedList<Orders>.ToPagedList(orders, orderParameters.PageNumber, orderParameters.PageSize, ct);
		}
	}
}
