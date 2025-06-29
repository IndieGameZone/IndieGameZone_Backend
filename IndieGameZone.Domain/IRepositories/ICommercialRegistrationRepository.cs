using IndieGameZone.Domain.Entities;
using IndieGameZone.Domain.RequestFeatures;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndieGameZone.Domain.IRepositories
{
    public interface ICommercialRegistrationRepository
    {
        void CreateCommercialRegistration(CommercialRegistration commercialRegistration);
        Task<CommercialRegistration?> GetCommercialRegistrationById(Guid id, bool trackChange, CancellationToken ct = default);
        Task<PagedList<CommercialRegistration>> GetCommercialRegistrations(CommercialRegistrationParameters commercialRegistrationParameters, bool trackChange, CancellationToken ct = default);
        Task<PagedList<CommercialRegistration>> GetCommercialRegistrationsByPackage(Guid commercialPackageId, CommercialRegistrationParameters commercialRegistrationParameters, bool trackChange, CancellationToken ct = default);
        Task<PagedList<CommercialRegistration>> GetCommercialRegistrationsByGame(Guid gameId, CommercialRegistrationParameters commercialRegistrationParameters, bool trackChange, CancellationToken ct = default);
        //Task<bool> IsCommercialRegistrationExists(Guid userId, Guid commercialPackageId, CancellationToken ct = default);
        //Task<bool> IsCommercialRegistrationExistsById(Guid id, CancellationToken ct = default);
        //Task CreateCommercialRegistrationAsync(Guid userId, Guid commercialPackageId, CancellationToken ct = default);
        //Task CancelCommercialRegistrationAsync(Guid id, CancellationToken ct = default);
        //Task<List<Guid>> GetUserIdsByCommercialPackageIdAsync(Guid commercialPackageId, CancellationToken ct = default);
    }
}
