using IndieGameZone.Domain.Entities;
using IndieGameZone.Domain.RequestFeatures;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndieGameZone.Domain.IRepositories
{
    public interface ICommercialPackageRepository
    {
        Task<PagedList<CommercialPackages>> GetCommercialPackages(CommercialPackageParameters commercialPackageParameters, bool trackChange, CancellationToken ct = default);
        Task<CommercialPackages?> GetCommercialPackageById(Guid id, bool trackChange, CancellationToken ct = default);
        void CreateCommercialPackage(CommercialPackages commercialPackage);
        void DeleteCommercialPackage(CommercialPackages commercialPackage);
    }
}
