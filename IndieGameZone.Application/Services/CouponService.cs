using IndieGameZone.Application.IServices;
using IndieGameZone.Domain.IRepositories;
using IndieGameZone.Domain.RequestsAndResponses.Responses.Coupons;
using MapsterMapper;

namespace IndieGameZone.Application.Services
{
	internal sealed class CouponService : ICouponService
	{
		private readonly IRepositoryManager repositoryManager;
		private readonly IMapper mapper;

		public CouponService(IRepositoryManager repositoryManager, IMapper mapper)
		{
			this.repositoryManager = repositoryManager;
			this.mapper = mapper;
			// Initialize any dependencies here if needed
		}
		public async Task<IEnumerable<CouponForReturnDto>> GetCouponsByUserId(Guid userId, CancellationToken ct = default)
		{
			var coupons = await repositoryManager.CouponRepository.GetCouponsByUserId(userId, false, ct);
			return mapper.Map<IEnumerable<CouponForReturnDto>>(coupons);
		}
	}
}
