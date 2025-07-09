using IndieGameZone.Domain.Entities;

namespace IndieGameZone.Domain.IRepositories
{
	public interface ICouponRepository
	{
		void CreateCoupon(Coupons coupon);
		Task<IEnumerable<Coupons>> GetCouponsByUserId(Guid userId, bool trackChange, CancellationToken ct = default);
		Task<Coupons?> GetCouponById(Guid id, bool trackChange, CancellationToken ct = default);
	}
}
