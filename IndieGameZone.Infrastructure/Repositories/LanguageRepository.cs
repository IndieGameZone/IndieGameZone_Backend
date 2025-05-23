using IndieGameZone.Domain.Entities;
using IndieGameZone.Domain.IRepositories;
using IndieGameZone.Infrastructure.Extensions;
using IndieGameZone.Infrastructure.Persistence;
using Microsoft.EntityFrameworkCore;

namespace IndieGameZone.Infrastructure.Repositories
{
	internal sealed class LanguageRepository : RepositoryBase<Languages>, ILanguageRepository
	{
		public LanguageRepository(AppDbContext appDbContext) : base(appDbContext)
		{
		}

		public void CreateLanguage(Languages language) => Create(language);

		public void DeleteLanguage(Languages language) => Delete(language);

		public async Task<Languages?> GetLanguageById(Guid id, bool trackChange, CancellationToken ct = default) => await FindByCondition(x => x.Id == id, trackChange)
			.FirstOrDefaultAsync(ct);

		public async Task<IEnumerable<Languages>> GetLanguages(bool trackChange, CancellationToken ct = default)
		{
			return await FindAll(trackChange)
				.Sort()
				.ToListAsync();
		}
	}
}
