using IndieGameZone.Domain.RequestFeatures;
using IndieGameZone.Domain.RequestsAndResponses.Requests.CommercialPackages;
using IndieGameZone.Domain.RequestsAndResponses.Responses.CommercialPackages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndieGameZone.Application.CommercialPackageServices
{
    public interface ICommercialPackageService
    {
        Task CreateCommercialPackage(CommercialPackageForCreationDto commercialPackageForCreationDto, CancellationToken ct = default);
        Task UpdateCommercialPackage(Guid id, CommercialPackageForUpdateDto commercialPackageForUpdateDto, CancellationToken ct = default);
        Task DeleteCommercialPackage(Guid id, CancellationToken ct = default);
        Task<CommercialPackageForReturnDto> GetCommercialPackageById(Guid id, CancellationToken ct = default);
        Task<(IEnumerable<CommercialPackageForReturnDto> commercialPackages, MetaData metaData)> GetCommercialPackages(CommercialPackageParameters commercialPackagesParameters, CancellationToken ct = default);
        Task<(IEnumerable<CommercialRegistrationForReturnDto> commercialRegistrations, MetaData metaData)> GetCommercialRegistrationsByPackage(Guid commercialPackageId, CommercialRegistrationParameters commercialRegistrationParameters, CancellationToken ct = default);

    }
}
