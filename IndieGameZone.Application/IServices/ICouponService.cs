using IndieGameZone.Domain.RequestsAndResponses.Responses.Coupons;

namespace IndieGameZone.Application.IServices
{
	public interface ICouponService
	{
		Task<IEnumerable<CouponForReturnDto>> GetCouponsByUserId(Guid userId, CancellationToken ct = default);
	}
}
