using IndieGameZone.Domain.Entities;
using IndieGameZone.Domain.IRepositories;
using IndieGameZone.Infrastructure.Extensions;
using IndieGameZone.Infrastructure.Persistence;
using Microsoft.EntityFrameworkCore;

namespace IndieGameZone.Infrastructure.Repositories
{
	internal sealed class AgeRestrictionRepository : RepositoryBase<AgeRestrictions>, IAgeRestrictionRepository
	{
		public AgeRestrictionRepository(AppDbContext appDbContext) : base(appDbContext)
		{
		}

		public void CreateAgeRestriction(AgeRestrictions ageRestriction) => Create(ageRestriction);

		public void DeleteAgeRestriction(AgeRestrictions ageRestriction) => Delete(ageRestriction);

		public async Task<AgeRestrictions?> GetAgeRestrictionById(Guid id, bool trackChange, CancellationToken ct = default) => await FindByCondition(c => c.Id.Equals(id), trackChange)
			.SingleOrDefaultAsync(ct);

		public async Task<IEnumerable<AgeRestrictions>> GetAgeRestrictions(bool trackChange, CancellationToken ct = default)
		{
			return await FindAll(trackChange)
				.Sort()
				.ToListAsync(ct);
		}
	}
}
