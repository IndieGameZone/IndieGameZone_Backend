using IndieGameZone.Application;
using IndieGameZone.Domain.Constants;
using IndieGameZone.Domain.RequestsAndResponses.Requests.Tags;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace IndieGameZone.API.Controllers
{
	[Route("api/tags")]
	[ApiController]
	public class TagsController : ControllerBase
	{
		private readonly IServiceManager serviceManager;

		public TagsController(IServiceManager serviceManager)
		{
			this.serviceManager = serviceManager;
		}

		[HttpGet]
		public async Task<IActionResult> GetTags(CancellationToken ct)
		{
			var tags = await serviceManager.TagService.GetTags();
			return Ok(tags);
		}

		[HttpGet("{id:guid}")]
		public async Task<IActionResult> GetTag([FromRoute] Guid id, CancellationToken ct)
		{
			var tag = await serviceManager.TagService.GetTagById(id, ct);
			return Ok(tag);
		}

		[HttpPost]
		[Authorize(Roles = $"{nameof(RoleEnum.Admin)}")]
		public async Task<IActionResult> CreateTag([FromBody] TagForCreationDto tagDto, CancellationToken ct)
		{
			await serviceManager.TagService.CreateTag(tagDto, ct);
			return StatusCode(201);
		}

		[HttpPut("{id:guid}")]
		[Authorize(Roles = $"{nameof(RoleEnum.Admin)}")]
		public async Task<IActionResult> UpdateTag([FromRoute] Guid id, [FromBody] TagForUpdateDto tagDto, CancellationToken ct)
		{
			await serviceManager.TagService.UpdateTag(id, tagDto, ct);
			return NoContent();
		}

		[HttpDelete("{id:guid}")]
		[Authorize(Roles = $"{nameof(RoleEnum.Admin)}")]
		public async Task<IActionResult> DeleteTag([FromRoute] Guid id, CancellationToken ct)
		{
			await serviceManager.TagService.DeleteTag(id, ct);
			return NoContent();
		}
	}
}
