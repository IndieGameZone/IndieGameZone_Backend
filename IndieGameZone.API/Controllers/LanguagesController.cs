using IndieGameZone.Application;
using IndieGameZone.Domain.Constants;
using IndieGameZone.Domain.RequestsAndResponses.Requests.Languages;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace IndieGameZone.API.Controllers
{
	[Route("api/languages")]
	[ApiController]
	public class LanguagesController : ControllerBase
	{
		private readonly IServiceManager serviceManager;

		public LanguagesController(IServiceManager serviceManager)
		{
			this.serviceManager = serviceManager;
		}

		[HttpGet]
		[Authorize]
		public async Task<IActionResult> GetLanguages(CancellationToken ct)
		{
			var languages = await serviceManager.LanguageService.GetLanguages(ct);
			return Ok(languages);
		}

		[HttpGet("{id:guid}")]
		[Authorize]
		public async Task<IActionResult> GetLanguage([FromRoute] Guid id, CancellationToken ct)
		{
			var language = await serviceManager.LanguageService.GetLanguageById(id, ct);
			return Ok(language);
		}

		[HttpPost]
		[Authorize(Roles = $"{nameof(RoleEnum.Admin)}")]
		public async Task<IActionResult> CreateLanguage([FromBody] LanguageForCreationDto languageDto, CancellationToken ct)
		{
			await serviceManager.LanguageService.CreateLanguage(languageDto, ct);
			return StatusCode(201);
		}

		[HttpPut("{id:guid}")]
		[Authorize(Roles = $"{nameof(RoleEnum.Admin)}")]
		public async Task<IActionResult> UpdateLanguage([FromRoute] Guid id, [FromBody] LanguageForUpdateDto languageDto, CancellationToken ct)
		{
			await serviceManager.LanguageService.UpdateLanguage(id, languageDto, ct);
			return NoContent();
		}

		[HttpDelete("{id:guid}")]
		[Authorize(Roles = $"{nameof(RoleEnum.Admin)}")]
		public async Task<IActionResult> DeleteLanguage([FromRoute] Guid id, CancellationToken ct)
		{
			await serviceManager.LanguageService.DeleteLanguage(id, ct);
			return NoContent();
		}
	}
}
