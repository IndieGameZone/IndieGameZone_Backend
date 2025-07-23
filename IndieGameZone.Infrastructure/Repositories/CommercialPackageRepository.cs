using IndieGameZone.Domain.Entities;
using IndieGameZone.Domain.IRepositories;
using IndieGameZone.Domain.RequestFeatures;
using IndieGameZone.Infrastructure.Extensions;
using IndieGameZone.Infrastructure.Persistence;
using Microsoft.EntityFrameworkCore;

namespace IndieGameZone.Infrastructure.Repositories
{
	internal sealed class CommercialPackageRepository : RepositoryBase<CommercialPackages>, ICommercialPackageRepository
	{
		public CommercialPackageRepository(AppDbContext appDbContext) : base(appDbContext)
		{
		}

		public void CreateCommercialPackage(CommercialPackages commercialPackage) => Create(commercialPackage);

		public void DeleteCommercialPackage(CommercialPackages commercialPackage) => Delete(commercialPackage);

		public async Task<CommercialPackages?> GetCommercialPackageById(Guid id, bool trackChange, CancellationToken ct = default) => await FindByCondition(c => c.Id.Equals(id) && !c.IsDeleted, trackChange)
				.SingleOrDefaultAsync(ct);

		public async Task<PagedList<CommercialPackages>> GetCommercialPackages(CommercialPackageParameters commercialPackageParameters, bool trackChange, CancellationToken ct = default)
		{
			var commercialPackageEntities = FindByCondition(c => !c.IsDeleted, trackChange)
				.Sort();

			return await PagedList<CommercialPackages>.ToPagedList(commercialPackageEntities, commercialPackageParameters.PageNumber, commercialPackageParameters.PageSize, ct);
		}
	}
}
