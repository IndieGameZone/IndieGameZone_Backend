using IndieGameZone.Application.IServices;
using IndieGameZone.Domain.RequestFeatures;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Text.Json;

namespace IndieGameZone.API.Controllers
{
	[Route("api")]
	[ApiController]
	public class OrdersController : ControllerBase
	{
		private readonly IServiceManager serviceManager;

		public OrdersController(IServiceManager serviceManager)
		{
			this.serviceManager = serviceManager;
		}

		[HttpGet("users/{userId:guid}/orders")]
		[Authorize]
		public async Task<IActionResult> GetOrdersByUserId([FromRoute] Guid userId, [FromQuery] OrderParameters orderParameters, CancellationToken ct = default)
		{
			var pagedResult = await serviceManager.OrderService.GetOrdersByUserId(userId, orderParameters, ct);
			Response.Headers.Append("X-Pagination", JsonSerializer.Serialize(pagedResult.metaData));
			return Ok(pagedResult.orders);
		}
	}
}
