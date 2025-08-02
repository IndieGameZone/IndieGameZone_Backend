using IndieGameZone.Domain.Entities;
using IndieGameZone.Domain.IRepositories;
using IndieGameZone.Domain.RequestFeatures;
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
			FindByCondition(x => x.Id == id && !x.IsDeleted, trackChange).FirstOrDefaultAsync(ct);

		public async Task<IEnumerable<Tags>> GetTags(TagParameters tagParameters, bool trackChange, CancellationToken ct = default)
		{
			return await FindByCondition(x => !x.IsDeleted, trackChange)
				.FilterByType(tagParameters.TagType)
				.Sort()
				.ToListAsync(ct);
		}
	}
}
