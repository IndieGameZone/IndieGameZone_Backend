using IndieGameZone.Application;
using IndieGameZone.Domain.RequestsAndResponses.Requests.Languages;
using Microsoft.AspNetCore.Mvc;

namespace IndieGameZone.API.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class LanguagesController : ControllerBase
	{
		private readonly IServiceManager serviceManager;

		public LanguagesController(IServiceManager serviceManager)
		{
			this.serviceManager = serviceManager;
		}

		[HttpGet]
		public async Task<IActionResult> GetLanguages(CancellationToken ct)
		{
			var languages = await serviceManager.LanguageService.GetLanguages(ct);
			return Ok(languages);
		}

		[HttpGet("{id:guid}")]
		public async Task<IActionResult> GetLanguage(Guid id, CancellationToken ct)
		{
			var language = await serviceManager.LanguageService.GetLanguageById(id, ct);
			return Ok(language);
		}

		[HttpPost]
		public async Task<IActionResult> CreateLanguage([FromBody] LanguageForCreationDto languageDto, CancellationToken ct)
		{
			await serviceManager.LanguageService.CreateLanguage(languageDto, ct);
			return StatusCode(201);
		}

		[HttpPut("{id:guid}")]
		public async Task<IActionResult> UpdateLanguage(Guid id, [FromBody] LanguageForUpdateDto languageDto, CancellationToken ct)
		{
			await serviceManager.LanguageService.UpdateLanguage(id, languageDto, ct);
			return NoContent();
		}

		[HttpDelete("{id:guid}")]
		public async Task<IActionResult> DeleteLanguage(Guid id, CancellationToken ct)
		{
			await serviceManager.LanguageService.DeleteLanguage(id, ct);
			return NoContent();
		}
	}
}
