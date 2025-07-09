using IndieGameZone.Domain.Entities;
using IndieGameZone.Domain.Exceptions;
using IndieGameZone.Domain.IRepositories;
using IndieGameZone.Domain.RequestFeatures;
using IndieGameZone.Domain.RequestsAndResponses.Requests.Achievements;
using IndieGameZone.Domain.RequestsAndResponses.Requests.BanHistories;
using IndieGameZone.Domain.RequestsAndResponses.Responses.Achievements;
using IndieGameZone.Domain.RequestsAndResponses.Responses.BanHistories;
using MapsterMapper;
using Microsoft.AspNetCore.Identity;
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
        private readonly UserManager<Users> userManager;

        public BanHistoryService(IRepositoryManager repositoryManager, IMapper mapper, UserManager<Users> userManager)
        {
            this.repositoryManager = repositoryManager;
            this.mapper = mapper;
            this.userManager = userManager;
        }

        public async Task CreateBanHistory(BanHistoryForCreationDto banHistoryForCreationDto, CancellationToken ct = default)
        {
            // Validate BanDate < UnbanDate
            if (DateTime.Now >= banHistoryForCreationDto.UnbanDate)
                throw new InvalidOperationException("Unban date must be after today.");

            var user = await userManager.FindByIdAsync(banHistoryForCreationDto.UserId.ToString());
            if (user == null)
                throw new UserNotFoundException();

            if (await repositoryManager.BanHistoryRepository.HasActiveBanAsync(banHistoryForCreationDto.UserId, DateTime.Now, ct))
                throw new InvalidOperationException("User already has an active ban.");

            user.IsActive = false;
            await userManager.UpdateAsync(user);

            var banHistoryEntity = mapper.Map<BanHistories>(banHistoryForCreationDto);
            banHistoryEntity.Id = Guid.NewGuid();
            banHistoryEntity.BanDate = DateTime.Now;

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
            var user = await userManager.FindByIdAsync(banHistoryEntity.BannedUserId.ToString());
            if (user == null) throw new UserNotFoundException();
            user.IsActive = true;
            await userManager.UpdateAsync(user);
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

        public async Task<(IEnumerable<BanHistoryForReturnDto> banHistories, MetaData metaData)> GetBanHistoriesByUserId(Guid userId, BanHistoryParameters banHistoryParameters, bool trackChanges = false, CancellationToken ct = default)
        {
            var banHistoriesWithMetaData = await repositoryManager.BanHistoryRepository.GetBanHistoriesByUserId(userId, banHistoryParameters, trackChanges, ct);
            var banHistories = mapper.Map<IEnumerable<BanHistoryForReturnDto>>(banHistoriesWithMetaData);
            return (banHistories, banHistoriesWithMetaData.MetaData);
        }

        public async Task UnbanUser(Guid userId, CancellationToken ct = default)
        {

            if (!await repositoryManager.BanHistoryRepository.HasActiveBanAsync(userId, DateTime.Now, ct))
                throw new InvalidOperationException("User don't has an active ban.");

            var banHistoryEntity = await repositoryManager.BanHistoryRepository.GetLatestBanHistoryByUserId(userId, true, ct);
            if (banHistoryEntity is null)
            {
                throw new NotFoundException($"Ban History not found.");
            }
            banHistoryEntity.UnbanDate = DateTime.Now;
            var user = await userManager.FindByIdAsync(userId.ToString());
            if (user == null) throw new UserNotFoundException();
            user.IsActive = true;
            await userManager.UpdateAsync(user);
            await repositoryManager.SaveAsync(ct);
        }

        public async Task UpdateBanHistory(Guid id, BanHistoryForUpdateDto banHistoryForUpdateDto, CancellationToken ct = default)
        {
            var banHistoryEntity = await repositoryManager.BanHistoryRepository.GetBanHistoryById(id, true, ct);
            if (banHistoryEntity is null)
                throw new NotFoundException($"Ban History not found.");
            if (banHistoryEntity.BanDate >= banHistoryForUpdateDto.UnbanDate)
                throw new InvalidOperationException("Updated unban date must be later than ban date.");

            // ✅ Check if there's a newer ban for the same user
            var hasFutureBan = await repositoryManager.BanHistoryRepository
                .HasFutureBanAsync(banHistoryEntity.BannedUserId, banHistoryEntity.Id, banHistoryEntity.BanDate, ct);

            if (hasFutureBan && banHistoryForUpdateDto.UnbanDate != banHistoryEntity.UnbanDate)
                throw new InvalidOperationException("Cannot update unban date because a newer ban already exists for this user.");


            mapper.Map(banHistoryForUpdateDto, banHistoryEntity);

            var user = await userManager.FindByIdAsync(banHistoryEntity.BannedUserId.ToString());
            if (user == null) throw new UserNotFoundException();
            // Only deactivate the user if they are currently within the ban period
            if (DateTime.Now >= banHistoryEntity.BanDate && DateTime.Now <= banHistoryForUpdateDto.UnbanDate)
            {
                user.IsActive = false;
                await userManager.UpdateAsync(user);
            }
            else
            {
                user.IsActive = true;
                await userManager.UpdateAsync(user);
            }
            await repositoryManager.SaveAsync(ct);
        }
    }
}
