using IndieGameZone.Domain.Entities;

namespace IndieGameZone.Domain.IRepositories
{
	public interface ICouponRepository
	{
		void CreateCoupon(Coupons coupon);
		Task<Coupons?> GetCouponByCode(string code, bool trackChange, CancellationToken ct = default);
		Task<IEnumerable<Coupons>> GetCouponsByUserId(Guid userId, bool trackChange, CancellationToken ct = default);
	}
}
