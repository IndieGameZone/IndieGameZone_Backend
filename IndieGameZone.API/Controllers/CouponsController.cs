using IndieGameZone.Application.IServices;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace IndieGameZone.API.Controllers
{
	[Route("api")]
	[ApiController]
	public class CouponsController : ControllerBase
	{
		private readonly IServiceManager serviceManager;

		public CouponsController(IServiceManager serviceManager)
		{
			this.serviceManager = serviceManager;
		}

		[HttpGet("users/{userId:guid}/coupons")]
		[Authorize]
		public async Task<IActionResult> GetUserCoupons(Guid userId, CancellationToken ct)
		{
			var coupons = await serviceManager.CouponService.GetCouponsByUserId(userId, ct);
			return Ok(coupons);
		}
	}
}
