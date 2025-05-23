using IndieGameZone.Domain.Entities;
using IndieGameZone.Domain.IRepositories;
using IndieGameZone.Infrastructure.Extensions;
using IndieGameZone.Infrastructure.Persistence;
using Microsoft.EntityFrameworkCore;

namespace IndieGameZone.Infrastructure.Repositories
{
	internal sealed class CategoryRepository : RepositoryBase<Categories>, ICategoryRepository
	{
		public CategoryRepository(AppDbContext appDbContext) : base(appDbContext)
		{
		}

		public void CreateCategory(Categories category) => Create(category);

		public void DeleteCategory(Categories category) => Delete(category);

		public async Task<IEnumerable<Categories>> GetCategories(bool trackChange, CancellationToken ct = default)
		{
			return await FindAll(trackChange)
				.Sort()
				.ToListAsync(ct);
		}

		public Task<Categories?> GetCategoryById(Guid id, bool trackChange, CancellationToken ct = default) => FindByCondition(c => c.Id.Equals(id), trackChange)
			.SingleOrDefaultAsync(ct);
	}
}
