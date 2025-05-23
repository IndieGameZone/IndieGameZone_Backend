using IndieGameZone.Domain.RequestsAndResponses.Requests.Categories;
using IndieGameZone.Domain.RequestsAndResponses.Responses.Categories;

namespace IndieGameZone.Application.CategoryServices
{
	public interface ICategoryService
	{
		Task CreateCategory(CategoryForCreationDto categoryForCreationDto, CancellationToken ct = default);
		Task UpdateCategory(Guid id, CategoryForUpdateDto categoryForUpdateDto, CancellationToken ct = default);
		Task DeleteCategory(Guid id, CancellationToken ct = default);
		Task<CategoryForReturnDto> GetCategoryById(Guid id, CancellationToken ct = default);
		Task<IEnumerable<CategoryForReturnDto>> GetCategories(CancellationToken ct = default);
	}
}
