using IndieGameZone.Domain.Entities;
using IndieGameZone.Domain.IRepositories;
using IndieGameZone.Domain.RequestFeatures;
using IndieGameZone.Infrastructure.Extensions;
using IndieGameZone.Infrastructure.Persistence;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndieGameZone.Infrastructure.Repositories
{
    internal sealed class CommercialRegistrationRepository : RepositoryBase<CommercialRegistration>, ICommercialRegistrationRepository
    {
        public CommercialRegistrationRepository(AppDbContext appDbContext) : base(appDbContext)
        {
        }

        public async Task<PagedList<CommercialRegistration>> GetCommercialRegistrationsByPackage(Guid commercialPackageId, CommercialRegistrationParameters commercialRegistrationParameters, bool trackChange, CancellationToken ct = default)
        {
            var commercialRegistrationEntities = FindByCondition(cr => cr.CommercialPackageId.Equals(commercialPackageId), trackChange)
                .Sort();

            return await PagedList<CommercialRegistration>.ToPagedList(commercialRegistrationEntities, commercialRegistrationParameters.PageNumber, commercialRegistrationParameters.PageSize, ct);
        }

    }
}
