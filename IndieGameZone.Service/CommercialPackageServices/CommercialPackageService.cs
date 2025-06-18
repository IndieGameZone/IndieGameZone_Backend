using IndieGameZone.Domain.Entities;
using IndieGameZone.Domain.Exceptions;
using IndieGameZone.Domain.IRepositories;
using IndieGameZone.Domain.RequestFeatures;
using IndieGameZone.Domain.RequestsAndResponses.Requests.Achievements;
using IndieGameZone.Domain.RequestsAndResponses.Requests.CommercialPackages;
using IndieGameZone.Domain.RequestsAndResponses.Responses.Achievements;
using IndieGameZone.Domain.RequestsAndResponses.Responses.CommercialPackages;
using MapsterMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndieGameZone.Application.CommercialPackageServices
{
    internal sealed class CommercialPackageService : ICommercialPackageService
    {
        private readonly IRepositoryManager repositoryManager;
        private readonly IMapper mapper;

        public CommercialPackageService(IRepositoryManager repositoryManager, IMapper mapper)
        {
            this.repositoryManager = repositoryManager;
            this.mapper = mapper;
        }
        public async Task CreateCommercialPackage(CommercialPackageForCreationDto commercialPackageForCreationDto, CancellationToken ct = default)
        {
            var commercialPackageEntity = mapper.Map<CommercialPackages>(commercialPackageForCreationDto);
            commercialPackageEntity.Id = Guid.NewGuid();
            repositoryManager.CommercialPackageRepository.CreateCommercialPackage(commercialPackageEntity);
            await repositoryManager.SaveAsync(ct);
        }

        public async Task DeleteCommercialPackage(Guid id, CancellationToken ct = default)
        {
            var commercialPackageEntity = await repositoryManager.CommercialPackageRepository.GetCommercialPackageById(id, false, ct);
            if (commercialPackageEntity is null)
            {
                throw new NotFoundException($"Commercial Package not found.");
            }
            repositoryManager.CommercialPackageRepository.DeleteCommercialPackage(commercialPackageEntity);
            await repositoryManager.SaveAsync(ct);
        }

        public async Task<CommercialPackageForReturnDto> GetCommercialPackageById(Guid id, CancellationToken ct = default)
        {
            var commercialPackageEntity = await repositoryManager.CommercialPackageRepository.GetCommercialPackageById(id, false, ct);
            if (commercialPackageEntity is null)
            {
                throw new NotFoundException($"Commercial Package not found.");
            }
            return mapper.Map<CommercialPackageForReturnDto>(commercialPackageEntity);
        }

        public async Task<(IEnumerable<CommercialPackageForReturnDto> commercialPackages, MetaData metaData)> GetCommercialPackages(CommercialPackageParameters commercialPackageParameters, CancellationToken ct = default)
        {
            var commercialPackagesWithMetaData = await repositoryManager.CommercialPackageRepository.GetCommercialPackages(commercialPackageParameters, false, ct);
            var commercialPackages = mapper.Map<IEnumerable<CommercialPackageForReturnDto>>(commercialPackagesWithMetaData);
            return (commercialPackages, commercialPackagesWithMetaData.MetaData);
        }

        public async Task UpdateCommercialPackage(Guid id, CommercialPackageForUpdateDto commercialPackageForUpdateDto, CancellationToken ct = default)
        {
            var commercialPackageEntity = await repositoryManager.CommercialPackageRepository.GetCommercialPackageById(id, true, ct);
            if (commercialPackageEntity is null)
            {
                throw new NotFoundException($"Commercial Package not found.");
            }
            mapper.Map(commercialPackageForUpdateDto, commercialPackageEntity);
            await repositoryManager.SaveAsync(ct);
        }

        public async Task<(IEnumerable<CommercialRegistrationForReturnDto> commercialRegistrations, MetaData metaData)> GetCommercialRegistrationsByPackage(Guid commercialPackageId, CommercialRegistrationParameters commercialRegistrationParameters, CancellationToken ct = default)
        {
            var commercialRegistrationsWithMetaData = await repositoryManager.CommercialRegistrationRepository.GetCommercialRegistrationsByPackage(commercialPackageId, commercialRegistrationParameters, false, ct);
            var commercialRegistrations = mapper.Map<IEnumerable<CommercialRegistrationForReturnDto>>(commercialRegistrationsWithMetaData);
            return (commercialRegistrations, commercialRegistrationsWithMetaData.MetaData);
        }
    }
}
