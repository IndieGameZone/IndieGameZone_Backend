using IndieGameZone.Application.IServices;
using IndieGameZone.Domain.Exceptions;
using IndieGameZone.Domain.IRepositories;
using IndieGameZone.Domain.RequestFeatures;
using IndieGameZone.Domain.RequestsAndResponses.Responses.Orders;
using MapsterMapper;

namespace IndieGameZone.Application.Services
{
	internal sealed class OrderService : IOrderService
	{
		private readonly IRepositoryManager repositoryManager;
		private readonly IMapper mapper;

		public OrderService(IRepositoryManager repositoryManager, IMapper mapper)
		{
			this.repositoryManager = repositoryManager;
			this.mapper = mapper;
		}

		public async Task<OrderForReturnDto?> GetOrderById(Guid orderId, CancellationToken ct = default)
		{
			var orders = await repositoryManager.OrderRepository.GetOrderById(orderId, false, ct);
			if (orders is null)
				throw new NotFoundException("Order not found");
			var orderForReturnDto = mapper.Map<OrderForReturnDto>(orders);
			orderForReturnDto.Discount = (orderForReturnDto.Game.Price - orderForReturnDto.Amount) / orderForReturnDto.Game.Price * 100;
			return orderForReturnDto;
		}

		public async Task<(IEnumerable<OrderForReturnDto> orders, MetaData metaData)> GetOrdersByUserId(Guid userId, OrderParameters orderParameters, CancellationToken ct = default)
		{
			var ordersWithMetaData = await repositoryManager.OrderRepository.GetOrdersByUserId(userId, orderParameters, false, ct);
			var orders = mapper.Map<IEnumerable<OrderForReturnDto>>(ordersWithMetaData);
			return (orders, ordersWithMetaData.MetaData);
		}
	}
}
