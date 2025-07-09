using IndieGameZone.Domain.Entities;
using IndieGameZone.Domain.IRepositories;
using IndieGameZone.Infrastructure.Persistence;
using Microsoft.EntityFrameworkCore;

namespace IndieGameZone.Infrastructure.Repositories
{
	internal sealed class CouponRepository : RepositoryBase<Coupons>, ICouponRepository
	{
		public CouponRepository(AppDbContext appDbContext) : base(appDbContext)
		{
		}

		public void CreateCoupon(Coupons coupon) => Create(coupon);

		public async Task<Coupons?> GetCouponById(Guid id, bool trackChange, CancellationToken ct = default) => await
			FindByCondition(c => c.Id == id, trackChange)
			.FirstOrDefaultAsync(ct);

		public async Task<IEnumerable<Coupons>> GetCouponsByUserId(Guid userId, bool trackChange, CancellationToken ct = default) => await
			FindByCondition(c => c.UserId == userId, trackChange)
			.ToListAsync(ct);
	}
}
