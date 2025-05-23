using IndieGameZone.Application;
using IndieGameZone.Domain.RequestsAndResponses.Requests.AgeRestrictions;
using Microsoft.AspNetCore.Mvc;

namespace IndieGameZone.API.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class AgeRestrictionsController : ControllerBase
	{
		private readonly IServiceManager serviceManager;

		public AgeRestrictionsController(IServiceManager serviceManager)
		{
			this.serviceManager = serviceManager;
		}

		[HttpGet]
		public async Task<IActionResult> GetAgeRestrictions(CancellationToken ct)
		{
			var ageRestrictions = await serviceManager.AgeRestrictionService.GetAgeRestrictions(ct);
			return Ok(ageRestrictions);
		}

		[HttpGet("{id:guid}")]
		public async Task<IActionResult> GetAgeRestriction(Guid id, CancellationToken ct)
		{
			var ageRestriction = await serviceManager.AgeRestrictionService.GetAgeRestrictionById(id, ct);
			return Ok(ageRestriction);
		}

		[HttpPost]
		public async Task<IActionResult> CreateAgeRestriction([FromBody] AgeRestrictionForCreationDto ageRestrictionDto, CancellationToken ct)
		{
			await serviceManager.AgeRestrictionService.CreateAgeRestriction(ageRestrictionDto, ct);
			return StatusCode(201);
		}

		[HttpPut("{id:guid}")]
		public async Task<IActionResult> UpdateAgeRestriction(Guid id, [FromBody] AgeRestrictionForUpdateDto ageRestrictionDto, CancellationToken ct)
		{
			await serviceManager.AgeRestrictionService.UpdateAgeRestriction(id, ageRestrictionDto, ct);
			return NoContent();
		}

		[HttpDelete("{id:guid}")]
		public async Task<IActionResult> DeleteAgeRestriction(Guid id, CancellationToken ct)
		{
			await serviceManager.AgeRestrictionService.DeleteAgeRestriction(id, ct);
			return NoContent();
		}
	}
}
