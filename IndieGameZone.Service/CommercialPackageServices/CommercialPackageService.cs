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

        private async Task<(IEnumerable<CommercialRegistrationForReturnDto> commercialRegistrations, MetaData metaData)>
            GetCommercialRegistrationsByUser(Guid userId, CommercialRegistrationParameters commercialRegistrationParameters, CancellationToken ct = default)
        {
            var commercialRegistrationsWithMetaData = await repositoryManager.CommercialRegistrationRepository
                .GetCommercialRegistrationsByUser(userId, commercialRegistrationParameters, false, ct);

            var commercialRegistrations = mapper.Map<List<CommercialRegistrationForReturnDto>>(commercialRegistrationsWithMetaData);

            for (int i = 0; i < commercialRegistrations.Count; i++)
            {
                commercialRegistrations[i].CreatedAt = commercialRegistrationsWithMetaData[i].Transaction.CreatedAt;
                commercialRegistrations[i].Visibility = commercialRegistrationsWithMetaData[i].Game.Visibility;
            }

            return (commercialRegistrations, commercialRegistrationsWithMetaData.MetaData);
        }

        private async Task<(IEnumerable<CommercialRegistrationForReturnDto> commercialRegistrations, MetaData metaData)>
            GetCommercialRegistrationsByGame(Guid gameId, CommercialRegistrationParameters commercialRegistrationParameters, CancellationToken ct = default)
        {
            var commercialRegistrationsWithMetaData = await repositoryManager.CommercialRegistrationRepository
                .GetCommercialRegistrationsByGame(gameId, commercialRegistrationParameters, false, ct);

            var commercialRegistrations = mapper
                .Map<List<CommercialRegistrationForReturnDto>>(commercialRegistrationsWithMetaData);

            for (int i = 0; i < commercialRegistrations.Count; i++)
            {
                commercialRegistrations[i].CreatedAt = commercialRegistrationsWithMetaData[i].Transaction.CreatedAt;
                commercialRegistrations[i].Visibility = commercialRegistrationsWithMetaData[i].Game.Visibility;
            }

            return (commercialRegistrations, commercialRegistrationsWithMetaData.MetaData);
        }

        private async Task<(IEnumerable<CommercialRegistrationForReturnDto> commercialRegistrations, MetaData metaData)>
            GetCommercialRegistrationsByPackage(Guid commercialPackageId, CommercialRegistrationParameters commercialRegistrationParameters, CancellationToken ct = default)
        {
            var commercialRegistrationsWithMetaData = await repositoryManager.CommercialRegistrationRepository
                .GetCommercialRegistrationsByPackage(commercialPackageId, commercialRegistrationParameters, false, ct);

            var commercialRegistrations = mapper
                .Map<List<CommercialRegistrationForReturnDto>>(commercialRegistrationsWithMetaData);

            for (int i = 0; i < commercialRegistrations.Count; i++)
            {
                commercialRegistrations[i].CreatedAt = commercialRegistrationsWithMetaData[i].Transaction.CreatedAt;
                commercialRegistrations[i].Visibility = commercialRegistrationsWithMetaData[i].Game.Visibility;
            }

            return (commercialRegistrations, commercialRegistrationsWithMetaData.MetaData);
        }

        public async Task<(IEnumerable<CommercialRegistrationForReturnDto> commercialRegistrations, MetaData metaData)>
            GetFilteredCommercialRegistrations(Guid? userId, Guid? gameId, Guid? commercialPackageId, CommercialRegistrationParameters commercialRegistrationParameters, CancellationToken ct = default)
        {
            // Ensure only one parameter is used
            int filterCount = 0;
            if (userId.HasValue) filterCount++;
            if (gameId.HasValue) filterCount++;
            if (commercialPackageId.HasValue) filterCount++;

            if (filterCount > 1)
                throw new BadRequestException("You cannot filter by more than one of: userId, gameId, or commercialPackageId.");

            if (userId.HasValue)
                return await GetCommercialRegistrationsByUser(userId.Value, commercialRegistrationParameters, ct);

            if (gameId.HasValue)
                return await GetCommercialRegistrationsByGame(gameId.Value, commercialRegistrationParameters, ct);

            if (commercialPackageId.HasValue)
                return await GetCommercialRegistrationsByPackage(commercialPackageId.Value, commercialRegistrationParameters, ct);

            // No filter applied, return all
            var commercialRegistrationsWithMetaData = await repositoryManager.CommercialRegistrationRepository
                .GetCommercialRegistrations(commercialRegistrationParameters, false, ct);

            var commercialRegistrations = mapper.Map<List<CommercialRegistrationForReturnDto>>(commercialRegistrationsWithMetaData);

            for (int i = 0; i < commercialRegistrations.Count; i++)
            {
                commercialRegistrations[i].CreatedAt = commercialRegistrationsWithMetaData[i].Transaction.CreatedAt;
                commercialRegistrations[i].Visibility = commercialRegistrationsWithMetaData[i].Game.Visibility;
            }

            return (commercialRegistrations, commercialRegistrationsWithMetaData.MetaData);
        }

    }
}
