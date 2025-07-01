using IndieGameZone.Application;
using IndieGameZone.Domain.Constants;
using IndieGameZone.Domain.RequestsAndResponses.Requests.AgeRestrictions;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace IndieGameZone.API.Controllers
{
	[Route("api/age-restrictions")]
	[ApiController]
	public class AgeRestrictionsController : ControllerBase
	{
		private readonly IServiceManager serviceManager;

		public AgeRestrictionsController(IServiceManager serviceManager)
		{
			this.serviceManager = serviceManager;
		}

		[HttpGet]
		[Authorize]
		public async Task<IActionResult> GetAgeRestrictions(CancellationToken ct)
		{
			var ageRestrictions = await serviceManager.AgeRestrictionService.GetAgeRestrictions(ct);
			return Ok(ageRestrictions);
		}

		[HttpGet("{id:guid}")]
		[Authorize]
		public async Task<IActionResult> GetAgeRestriction([FromRoute] Guid id, CancellationToken ct)
		{
			var ageRestriction = await serviceManager.AgeRestrictionService.GetAgeRestrictionById(id, ct);
			return Ok(ageRestriction);
		}

		[HttpPost]
		[Authorize(Roles = $"{nameof(RoleEnum.Admin)}")]
		public async Task<IActionResult> CreateAgeRestriction([FromBody] AgeRestrictionForCreationDto ageRestrictionDto, CancellationToken ct)
		{
			await serviceManager.AgeRestrictionService.CreateAgeRestriction(ageRestrictionDto, ct);
			return StatusCode(201);
		}

		[HttpPut("{id:guid}")]
		[Authorize(Roles = $"{nameof(RoleEnum.Admin)}")]
		public async Task<IActionResult> UpdateAgeRestriction([FromRoute] Guid id, [FromBody] AgeRestrictionForUpdateDto ageRestrictionDto, CancellationToken ct)
		{
			await serviceManager.AgeRestrictionService.UpdateAgeRestriction(id, ageRestrictionDto, ct);
			return NoContent();
		}

		[HttpDelete("{id:guid}")]
		[Authorize(Roles = $"{nameof(RoleEnum.Admin)}")]
		public async Task<IActionResult> DeleteAgeRestriction([FromRoute] Guid id, CancellationToken ct)
		{
			await serviceManager.AgeRestrictionService.DeleteAgeRestriction(id, ct);
			return NoContent();
		}
	}
}
