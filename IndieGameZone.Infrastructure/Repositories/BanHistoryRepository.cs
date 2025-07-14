using IndieGameZone.Domain.Entities;
using IndieGameZone.Domain.IRepositories;
using IndieGameZone.Domain.RequestFeatures;
using IndieGameZone.Infrastructure.Extensions;
using IndieGameZone.Infrastructure.Persistence;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndieGameZone.Infrastructure.Repositories
{
    internal sealed class BanHistoryRepository : RepositoryBase<BanHistories>, IBanHistoryRepository
    {
        public BanHistoryRepository(AppDbContext appDbContext) : base(appDbContext)
        {
        }

        public async Task<PagedList<BanHistories>> GetBanHistories(BanHistoryParameters banHistoryParameters, bool trackChange, CancellationToken ct = default)
        {
            var banHistoryEntities = FindAll(trackChange)
                .Include(b => b.BannedUser).ThenInclude(u => u.UserProfile)
                .Include(b => b.BannedByUser).ThenInclude(u => u.UserProfile)
                .Sort();

            return await PagedList<BanHistories>.ToPagedList(banHistoryEntities, banHistoryParameters.PageNumber, banHistoryParameters.PageSize, ct);
        }

        public async Task<BanHistories?> GetBanHistoryById(Guid id, bool trackChange, CancellationToken ct = default) => await FindByCondition(b => b.Id.Equals(id), trackChange)
            .Include(b => b.BannedUser).ThenInclude(u => u.UserProfile)
            .Include(b => b.BannedByUser).ThenInclude(u => u.UserProfile)
            .SingleOrDefaultAsync(ct);

        public async Task<PagedList<BanHistories>> GetBanHistoriesByBannedUserId(Guid bannedUserId, BanHistoryParameters banHistoryParameters, bool trackChange, CancellationToken ct = default)
        {
            var banHistoryEntities = FindByCondition(b => b.BannedUserId == bannedUserId, trackChange)
            .Include(b => b.BannedUser).ThenInclude(u => u.UserProfile)
            .Include(b => b.BannedByUser).ThenInclude(u => u.UserProfile)
            .SortForLogging();

            return await PagedList<BanHistories>.ToPagedList(
                banHistoryEntities,
                banHistoryParameters.PageNumber,
                banHistoryParameters.PageSize,
                ct
            );
        }

        public async Task<PagedList<BanHistories>> GetBanHistoriesByBannedByUserId(Guid bannedByUserId, BanHistoryParameters banHistoryParameters, bool trackChanges, CancellationToken ct = default)
        {
            var banHistoryEntities = FindByCondition(b => b.BannedByUserId == bannedByUserId, trackChanges)
            .Include(b => b.BannedUser).ThenInclude(u => u.UserProfile)
            .Include(b => b.BannedByUser).ThenInclude(u => u.UserProfile)
            .Sort();

            return await PagedList<BanHistories>.ToPagedList(
                banHistoryEntities,
                banHistoryParameters.PageNumber,
                banHistoryParameters.PageSize,
                ct
            );
        }

        public void CreateBanHistory(BanHistories banHistory) => Create(banHistory);

        public async Task<bool> HasFutureBanAsync(Guid userId, Guid excludeBanId, DateTime currentBanDate, CancellationToken ct = default)
        {
            return await FindByCondition(b =>
                b.BannedUserId == userId &&
                b.Id != excludeBanId &&
                b.BanDate > currentBanDate, false)
                .AnyAsync(ct);
        }
        
        public async Task<bool> HasActiveBanAsync(Guid userId, DateTime now, CancellationToken ct = default)
        {
            return await FindByCondition(b =>
                b.BannedUserId == userId &&
                b.BanDate <= now &&
                b.UnbanDate >= now, false)
                .AnyAsync(ct);
        }

        public async Task<BanHistories?> GetLatestBanHistoryByUserId(Guid userId, bool trackChange, CancellationToken ct = default) => await FindByCondition(b => b.BannedUserId.Equals(userId), trackChange)
        .Include(b => b.BannedUser).ThenInclude(u => u.UserProfile)
        .Include(b => b.BannedByUser).ThenInclude(u => u.UserProfile)
        .OrderByDescending(b => b.UnbanDate)
        .FirstOrDefaultAsync(ct);

    }
}
