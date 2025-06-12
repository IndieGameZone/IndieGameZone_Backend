using IndieGameZone.Domain.Entities;
using IndieGameZone.Domain.Exceptions;
using IndieGameZone.Domain.IRepositories;
using IndieGameZone.Domain.RequestFeatures;
using IndieGameZone.Domain.RequestsAndResponses.Requests.Achievements;
using IndieGameZone.Domain.RequestsAndResponses.Requests.BanHistories;
using IndieGameZone.Domain.RequestsAndResponses.Responses.Achievements;
using IndieGameZone.Domain.RequestsAndResponses.Responses.BanHistories;
using MapsterMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndieGameZone.Application.BanHistoryServices
{
    internal sealed class BanHistoryService : IBanHistoryService
    {
        private readonly IRepositoryManager repositoryManager;
        private readonly IMapper mapper;
        
        public BanHistoryService(IRepositoryManager repositoryManager, IMapper mapper)
        {
            this.repositoryManager = repositoryManager;
            this.mapper = mapper;
        }

        public async Task CreateBanHistory(BanHistoryForCreationDto banHistoryForCreationDto, CancellationToken ct = default)
        {
            var banHistoryEntity = mapper.Map<BanHistories>(banHistoryForCreationDto);
            banHistoryEntity.Id = Guid.NewGuid();
            repositoryManager.BanHistoryRepository.CreateBanHistory(banHistoryEntity);
            await repositoryManager.SaveAsync(ct);
        }

        public async Task DeleteBanHistory(Guid id, CancellationToken ct = default)
        {
            var banHistoryEntity = await repositoryManager.BanHistoryRepository.GetBanHistoryById(id, false, ct);
            if (banHistoryEntity is null)
            {
                throw new NotFoundException($"Ban History not found.");
            }
            repositoryManager.BanHistoryRepository.DeleteBanHistory(banHistoryEntity);
            await repositoryManager.SaveAsync(ct);
        }

        public async Task<(IEnumerable<BanHistoryForReturnDto> banHistories, MetaData metaData)> GetBanHistories(BanHistoryParameters banHistoryParameters, CancellationToken ct = default)
        {
            var banHistoriesWithMetaData = await repositoryManager.BanHistoryRepository.GetBanHistories(banHistoryParameters, false, ct);
            var banHistories = mapper.Map<IEnumerable<BanHistoryForReturnDto>>(banHistoriesWithMetaData);
            return (banHistories, banHistoriesWithMetaData.MetaData);
        }

        public async Task<BanHistoryForReturnDto> GetBanHistoryById(Guid id, CancellationToken ct = default)
        {
            var banHistoryEntity = await repositoryManager.BanHistoryRepository.GetBanHistoryById(id, false, ct);
            if (banHistoryEntity is null)
            {
                throw new NotFoundException($"Ban History not found.");
            }
            return mapper.Map<BanHistoryForReturnDto>(banHistoryEntity);
        }

        public Task UnbanUser(Guid id, CancellationToken ct = default)
        {
            throw new NotImplementedException();
        }

        public async Task UpdateBanHistory(Guid id, BanHistoryForUpdateDto banHistoryForUpdateDto, CancellationToken ct = default)
        {
            var banHistoryEntity = await repositoryManager.BanHistoryRepository.GetBanHistoryById(id, true, ct);
            if (banHistoryEntity is null)
            {
                throw new NotFoundException($"Ban History not found.");
            }
            mapper.Map(banHistoryForUpdateDto, banHistoryEntity);
            await repositoryManager.SaveAsync(ct);
        }
    }
}
