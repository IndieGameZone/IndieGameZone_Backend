using IndieGameZone.Domain.Entities;

namespace IndieGameZone.Domain.IRepositories
{
	public interface IOrderRepository
	{
		void CreateOrder(Orders orders);
		Task<Orders?> GetOrderByCode(long orderCode, bool trackChange, CancellationToken ct = default);
	}
}
