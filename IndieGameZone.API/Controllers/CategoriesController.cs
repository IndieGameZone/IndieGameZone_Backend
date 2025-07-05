using IndieGameZone.Application;
using IndieGameZone.Domain.Constants;
using IndieGameZone.Domain.RequestsAndResponses.Requests.Categories;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace IndieGameZone.API.Controllers
{
	[Route("api/categories")]
	[ApiController]
	public class CategoriesController : ControllerBase
	{
		private readonly IServiceManager serviceManager;

		public CategoriesController(IServiceManager serviceManager)
		{
			this.serviceManager = serviceManager;
		}

		[HttpGet]
		public async Task<IActionResult> GetCategories(CancellationToken ct)
		{
			var categories = await serviceManager.CategoryService.GetCategories(ct);
			return Ok(categories);
		}

		[HttpGet("{id:guid}")]
		public async Task<IActionResult> GetCategory([FromRoute] Guid id, CancellationToken ct)
		{
			var category = await serviceManager.CategoryService.GetCategoryById(id, ct);
			return Ok(category);
		}

		[HttpPost]
		[Authorize(Roles = $"{nameof(RoleEnum.Admin)}")]
		public async Task<IActionResult> CreateCategory([FromBody] CategoryForCreationDto categoryDto, CancellationToken ct)
		{
			await serviceManager.CategoryService.CreateCategory(categoryDto, ct);
			return StatusCode(201);
		}

		[HttpPut("{id:guid}")]
		[Authorize(Roles = $"{nameof(RoleEnum.Admin)}")]
		public async Task<IActionResult> UpdateCategory([FromRoute] Guid id, [FromBody] CategoryForUpdateDto categoryDto, CancellationToken ct)
		{
			await serviceManager.CategoryService.UpdateCategory(id, categoryDto, ct);
			return NoContent();
		}

		[HttpDelete("{id:guid}")]
		[Authorize(Roles = $"{nameof(RoleEnum.Admin)}")]
		public async Task<IActionResult> DeleteCategory([FromRoute] Guid id, CancellationToken ct)
		{
			await serviceManager.CategoryService.DeleteCategory(id, ct);
			return NoContent();
		}
	}
}
