using IndieGameZone.Domain.RequestsAndResponses.Requests.Discounts;

namespace IndieGameZone.Application.DiscountServices
{
	public interface IDiscountService
	{
		Task CreateDiscount(Guid gameId, DiscountForCreationDto discountForCreationDto, CancellationToken ct = default);
	}
}
