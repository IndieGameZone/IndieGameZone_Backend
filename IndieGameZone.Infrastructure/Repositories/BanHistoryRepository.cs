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
                .Sort();

            return await PagedList<BanHistories>.ToPagedList(banHistoryEntities, banHistoryParameters.PageNumber, banHistoryParameters.PageSize, ct);
        }

        public async Task<BanHistories?> GetBanHistoryById(Guid id, bool trackChange, CancellationToken ct = default) => await FindByCondition(b => b.Id.Equals(id), trackChange)
            .SingleOrDefaultAsync(ct);

        public async Task<PagedList<BanHistories>> GetBanHistoriesByBannedUserId(Guid bannedUserId, BanHistoryParameters banHistoryParameters, bool trackChange, CancellationToken ct = default)
        {
            var banHistoryEntities = FindByCondition(b => b.BannedUserId == bannedUserId, trackChange)
                .Sort();

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
        .OrderByDescending(b => b.UnbanDate)
        .FirstOrDefaultAsync(ct);

    }
}
