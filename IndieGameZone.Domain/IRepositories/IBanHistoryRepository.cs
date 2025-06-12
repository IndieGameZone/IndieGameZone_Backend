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
        Task<BanHistories?> GetBanHistoryByUserId(Guid userId, bool trackChange, CancellationToken ct = default);
        void CreateBanHistory(BanHistories banHistory);
        void DeleteBanHistory(BanHistories banHistory);
    }
}
