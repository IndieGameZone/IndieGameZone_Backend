using IndieGameZone.Domain.Entities;
using IndieGameZone.Domain.RequestFeatures;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndieGameZone.Domain.IRepositories
{
    public interface IBanHistoryRepository
    {
        Task<PagedList<BanHistories>> GetBanHistories(BanHistoryParameters banHistoryParameters, bool trackChange, CancellationToken ct = default);
        Task<BanHistories?> GetBanHistoryById(Guid id, bool trackChange, CancellationToken ct = default);
        Task<PagedList<BanHistories>> GetBanHistoriesByBannedUserId(Guid bannedUserId, BanHistoryParameters banHistoryParameters, bool trackChanges = false, CancellationToken ct = default);
        Task<PagedList<BanHistories>> GetBanHistoriesByBannedByUserId(Guid bannedByUserId, BanHistoryParameters banHistoryParameters, bool trackChanges = false, CancellationToken ct = default);
        void CreateBanHistory(BanHistories banHistory);
        Task<bool> HasFutureBanAsync(Guid userId, Guid excludeBanId, DateTime currentBanDate, CancellationToken ct = default);
        Task<bool> HasActiveBanAsync(Guid userId, DateTime now, CancellationToken ct = default);
        Task<BanHistories?> GetLatestBanHistoryByUserId(Guid userId, bool trackChange, CancellationToken ct = default);
    }
}
