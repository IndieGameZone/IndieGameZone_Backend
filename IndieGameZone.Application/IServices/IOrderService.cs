using IndieGameZone.Domain.RequestFeatures;
using IndieGameZone.Domain.RequestsAndResponses.Responses.Orders;

namespace IndieGameZone.Application.IServices
{
	public interface IOrderService
	{
		Task<(IEnumerable<OrderForReturnDto> orders, MetaData metaData)> GetOrdersByUserId(Guid userId, OrderParameters orderParameters, CancellationToken ct = default);
		Task<(IEnumerable<OrderForReturnDto> orders, MetaData metaData)> GetOrders(OrderParameters orderParameters, CancellationToken ct = default);
		Task<OrderForReturnDto?> GetOrderById(Guid orderId, CancellationToken ct = default);
	}
}
