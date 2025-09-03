using IndieGameZone.Application.IServices;
using IndieGameZone.Domain.Constants;
using IndieGameZone.Domain.RequestsAndResponses.Requests.Discounts;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace IndieGameZone.API.Controllers
{
	[Route("api")]
	[ApiController]
	public class DiscountsController : ControllerBase
	{
		private readonly IServiceManager serviceManager;

		public DiscountsController(IServiceManager serviceManager)
		{
			this.serviceManager = serviceManager;
		}

		[Authorize(Roles = $"{nameof(RoleEnum.Developer)}")]
		[HttpPost("games/{gameId:guid}/discounts")]
		public async Task<IActionResult> CreateDiscount(Guid gameId, [FromBody] DiscountForCreationDto createDiscountDto, CancellationToken ct)
		{
			await serviceManager.DiscountService.CreateDiscount(gameId, createDiscountDto, ct);
			return StatusCode(201);
		}
	}
}
