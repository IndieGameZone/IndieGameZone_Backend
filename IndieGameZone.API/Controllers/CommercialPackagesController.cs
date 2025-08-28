using IndieGameZone.Application.IServices;
using IndieGameZone.Domain.Constants;
using IndieGameZone.Domain.RequestFeatures;
using IndieGameZone.Domain.RequestsAndResponses.Requests.CommercialPackages;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text.Json;

namespace IndieGameZone.API.Controllers
{
	[Route("api/commercial-packages")]
	[ApiController]
	public class CommercialPackagesController : ControllerBase
	{
		private readonly IServiceManager serviceManager;

		public CommercialPackagesController(IServiceManager serviceManager)
		{
			this.serviceManager = serviceManager;
		}

		[HttpGet]
		[Authorize]
		public async Task<IActionResult> GetCommercialPackages([FromQuery] CommercialPackageParameters commercialPackageParameters, CancellationToken ct)
		{
			var pagedResult = await serviceManager.CommercialPackageService.GetCommercialPackages(commercialPackageParameters, ct);
			Response.Headers.Append("X-Pagination", JsonSerializer.Serialize(pagedResult.metaData));
			return Ok(pagedResult.commercialPackages);
		}

		[HttpGet("{id:guid}")]
		[Authorize]
		public async Task<IActionResult> GetCommercialPackageById([FromRoute] Guid id, CancellationToken ct)
		{
			var commercialPackage = await serviceManager.CommercialPackageService.GetCommercialPackageById(id, ct);
			return Ok(commercialPackage);
		}

		[HttpPost]
		[Authorize(Roles = $"{nameof(RoleEnum.Admin)}")]
		public async Task<IActionResult> CreateCommercialPackage([FromBody] CommercialPackageForCreationDto commercialPackageForCreationDto, CancellationToken ct)
		{
			await serviceManager.CommercialPackageService.CreateCommercialPackage(commercialPackageForCreationDto, ct);
			return StatusCode(201);
		}

		[HttpPut("{id:guid}")]
		[Authorize(Roles = $"{nameof(RoleEnum.Admin)}")]
		public async Task<IActionResult> UpdateCommercialPackage([FromRoute] Guid id, [FromBody] CommercialPackageForUpdateDto commercialPackageForUpdateDto, CancellationToken ct)
		{
			await serviceManager.CommercialPackageService.UpdateCommercialPackage(id, commercialPackageForUpdateDto, ct);
			return NoContent();
		}

		[HttpDelete("{id:guid}")]
		[Authorize(Roles = $"{nameof(RoleEnum.Admin)}")]
		public async Task<IActionResult> DeleteCommercialPackage([FromRoute] Guid id, CancellationToken ct)
		{
			await serviceManager.CommercialPackageService.DeleteCommercialPackage(id, ct);
			return NoContent();
		}

		[HttpGet("registrations")]
		public async Task<IActionResult> GetCommercialRegistrations(
			[FromQuery] Guid? userId,
			[FromQuery] Guid? gameId,
			[FromQuery] Guid? commercialPackageId,
			[FromQuery] CommercialRegistrationParameters parameters,
			CancellationToken ct)
		{
			var pagedResult = await serviceManager
				.CommercialPackageService
				.GetFilteredCommercialRegistrations(userId, gameId, commercialPackageId, parameters, ct);

			Response.Headers.Append("X-Pagination", JsonSerializer.Serialize(pagedResult.metaData));
			return Ok(pagedResult.commercialRegistrations);
		}

		[HttpGet("{id:guid}/unavailable-dates")]
		public async Task<IActionResult> GetUnavailableDates([FromRoute] Guid id, [FromQuery, Required] Guid gameId, CancellationToken ct)
		{
			var jwt = HttpContext.Request.Headers["Authorization"].ToString().Split(" ")[1];
			var handler = new JwtSecurityTokenHandler();
			var token = handler.ReadJwtToken(jwt);
			var userIdString = token.Claims.First(claim => claim.Type == ClaimTypes.NameIdentifier).Value;

			if (!Guid.TryParse(userIdString, out var userId))
			{
				return BadRequest("Invalid user ID in token.");
			}

			var unavailableDates = await serviceManager.CommercialPackageService
				.GetUnavailableDatesAsync(id, gameId, userId, ct);

			return Ok(unavailableDates);
		}

		[HttpDelete("registrations/{registrationId:guid}")]
		[Authorize]
		public async Task<IActionResult> CancelCommercialRegistration([FromRoute] Guid registrationId, CancellationToken ct)
		{
			var token = HttpContext.Request.Headers["Authorization"].ToString().Split(" ")[1];
			var developer = await serviceManager.UserService.GetUserByToken(token, ct);
			if (developer == null)
			{
				return Unauthorized("Invalid or expired token.");
			}

			await serviceManager.CommercialPackageService
				.CancelCommercialRegistrationAsync(registrationId, developer.Id, ct);

			return NoContent();
		}

		[HttpGet("backgroundjob-settings")]
		[Authorize(Roles = $"{nameof(RoleEnum.Admin)}")]
		public async Task<IActionResult> GetBackgroundJobSettings([FromForm] double minute)
		{
			await serviceManager.CommercialPackageService.SetBackgroundJob(minute, CancellationToken.None);
			return Ok("Background job settings successfully.");
		}


        [HttpPatch("registrations/activate/{registrationId:guid}")]
        [Authorize(Roles = $"{nameof(RoleEnum.Admin)}")]
        public async Task<IActionResult> ActivateCommercialRegistration([FromRoute] Guid registrationId, CancellationToken ct)
        {

            await serviceManager.CommercialPackageService.ActivateCommercialRegistrationAsync(registrationId, ct);
            return NoContent();
        }
    }
}
