using IndieGameZone.Domain.Entities;

namespace IndieGameZone.Domain.IRepositories
{
	public interface IOrderRepository
	{
		void CreateOrder(Orders orders);
		Task<Orders?> GetOrderById(Guid id, bool trackChange, CancellationToken ct = default);
	}
}
