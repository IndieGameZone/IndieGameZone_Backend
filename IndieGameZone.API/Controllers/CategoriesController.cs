using IndieGameZone.Application;
using IndieGameZone.Domain.RequestsAndResponses.Requests.Categories;
using Microsoft.AspNetCore.Mvc;

namespace IndieGameZone.API.Controllers
{
	[Route("api/[controller]")]
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

		[HttpGet("{id}")]
		public async Task<IActionResult> GetCategory(Guid id, CancellationToken ct)
		{
			var category = await serviceManager.CategoryService.GetCategoryById(id, ct);
			return Ok(category);
		}

		[HttpPost]
		public async Task<IActionResult> CreateCategory([FromBody] CategoryForCreationDto categoryDto, CancellationToken ct)
		{
			await serviceManager.CategoryService.CreateCategory(categoryDto, ct);
			return StatusCode(201);
		}

		[HttpPut("{id}")]
		public async Task<IActionResult> UpdateCategory(Guid id, [FromBody] CategoryForUpdateDto categoryDto, CancellationToken ct)
		{
			await serviceManager.CategoryService.UpdateCategory(id, categoryDto, ct);
			return NoContent();
		}

		[HttpDelete("{id}")]
		public async Task<IActionResult> DeleteCategory(Guid id, CancellationToken ct)
		{
			await serviceManager.CategoryService.DeleteCategory(id, ct);
			return NoContent();
		}
	}
}
