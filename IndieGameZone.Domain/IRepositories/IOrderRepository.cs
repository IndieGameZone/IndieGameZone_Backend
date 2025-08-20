using IndieGameZone.Domain.Entities;
using IndieGameZone.Domain.RequestFeatures;

namespace IndieGameZone.Domain.IRepositories
{
	public interface IOrderRepository
	{
		void CreateOrder(Orders orders);
		Task<Orders?> GetOrderById(Guid id, bool trackChange, CancellationToken ct = default);
		Task<Orders?> GetOrderByGameAndUser(Guid gameId, Guid userId, bool trackChange, CancellationToken ct = default);
		Task<PagedList<Orders>> GetOrdersByUserId(Guid userId, OrderParameters orderParameters, bool trackChange, CancellationToken ct = default);
	}
}
