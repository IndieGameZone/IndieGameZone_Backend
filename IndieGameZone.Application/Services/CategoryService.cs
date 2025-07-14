using IndieGameZone.Application.IServices;
using IndieGameZone.Domain.Exceptions;
using IndieGameZone.Domain.IRepositories;
using IndieGameZone.Domain.RequestsAndResponses.Requests.Categories;
using IndieGameZone.Domain.RequestsAndResponses.Responses.Categories;
using MapsterMapper;

namespace IndieGameZone.Application.Services
{
	internal sealed class CategoryService : ICategoryService
	{
		private readonly IRepositoryManager repositoryManager;
		private readonly IMapper mapper;

		public CategoryService(IRepositoryManager repositoryManager, IMapper mapper)
		{
			this.repositoryManager = repositoryManager;
			this.mapper = mapper;
		}
		public async Task CreateCategory(CategoryForCreationDto categoryForCreationDto, CancellationToken ct = default)
		{
			var categoryEntity = mapper.Map<Domain.Entities.Categories>(categoryForCreationDto);
			categoryEntity.Id = Guid.NewGuid();
			repositoryManager.CategoryRepository.CreateCategory(categoryEntity);
			await repositoryManager.SaveAsync(ct);
		}

		public async Task DeleteCategory(Guid id, CancellationToken ct = default)
		{
			var categoryEntity = await repositoryManager.CategoryRepository.GetCategoryById(id, false, ct);
			if (categoryEntity is null)
			{
				throw new NotFoundException($"Category not found.");
			}
			repositoryManager.CategoryRepository.DeleteCategory(categoryEntity);
			await repositoryManager.SaveAsync(ct);
		}

		public async Task<IEnumerable<CategoryForReturnDto>> GetCategories(CancellationToken ct = default)
		{
			var categoryEntities = await repositoryManager.CategoryRepository.GetCategories(false, ct);
			return mapper.Map<IEnumerable<CategoryForReturnDto>>(categoryEntities);
		}

		public async Task<CategoryForReturnDto> GetCategoryById(Guid id, CancellationToken ct = default)
		{
			var categoryEntity = await repositoryManager.CategoryRepository.GetCategoryById(id, false, ct);
			if (categoryEntity is null)
			{
				throw new NotFoundException($"Category not found.");
			}
			return mapper.Map<CategoryForReturnDto>(categoryEntity);
		}

		public async Task UpdateCategory(Guid id, CategoryForUpdateDto categoryForUpdateDto, CancellationToken ct = default)
		{
			var categoryEntity = await repositoryManager.CategoryRepository.GetCategoryById(id, true, ct);
			if (categoryEntity is null)
			{
				throw new NotFoundException($"Category not found.");
			}
			mapper.Map(categoryForUpdateDto, categoryEntity);
			await repositoryManager.SaveAsync(ct);
		}
	}
}
