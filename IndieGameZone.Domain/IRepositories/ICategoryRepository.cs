using IndieGameZone.Domain.Entities;

namespace IndieGameZone.Domain.IRepositories
{
	public interface ICategoryRepository
	{
		Task<IEnumerable<Categories>> GetCategories(bool trackChange, CancellationToken ct = default);
		Task<Categories?> GetCategoryById(Guid id, bool trackChange, CancellationToken ct = default);
		void CreateCategory(Categories category);
		void DeleteCategory(Categories category);
	}
}
