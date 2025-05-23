using IndieGameZone.Domain.Entities;
using IndieGameZone.Domain.IRepositories;
using IndieGameZone.Infrastructure.Extensions;
using IndieGameZone.Infrastructure.Persistence;
using Microsoft.EntityFrameworkCore;

namespace IndieGameZone.Infrastructure.Repositories
{
	internal sealed class TagRepository : RepositoryBase<Tags>, ITagRepository
	{
		public TagRepository(AppDbContext appDbContext) : base(appDbContext)
		{
		}

		public void CreateTag(Tags tag) => Create(tag);

		public void DeleteTag(Tags tag) => Delete(tag);

		public async Task<Tags?> GetTagById(Guid id, bool trackChange, CancellationToken ct = default) => await
			FindByCondition(x => x.Id == id, trackChange).FirstOrDefaultAsync(ct);

		public async Task<IEnumerable<Tags>> GetTags(bool trackChange, CancellationToken ct = default)
		{
			return await FindAll(trackChange)
				.Sort()
				.ToListAsync(ct);
		}
	}
}
