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

        public void CreateBanHistory(BanHistories banHistory) => Create(banHistory);

        public void DeleteBanHistory(BanHistories banHistory) => Delete(banHistory);

        public async Task<BanHistories?> GetBanHistoryById(Guid id, bool trackChange, CancellationToken ct = default) => await FindByCondition(b => b.Id.Equals(id), trackChange)
            .SingleOrDefaultAsync(ct);

        public async Task<BanHistories?> GetLatestBanHistoryByUserId(Guid userId, bool trackChange, CancellationToken ct = default) => await FindByCondition(b => b.UserId.Equals(userId), trackChange)
        .OrderByDescending(b => b.UnbanDate)
        .FirstOrDefaultAsync(ct);


        public async Task<PagedList<BanHistories>> GetBanHistories(BanHistoryParameters banHistoryParameters, bool trackChange, CancellationToken ct = default)
        {
            var banHistoryEntities = FindAll(trackChange)
                .Sort();

            return await PagedList<BanHistories>.ToPagedList(banHistoryEntities, banHistoryParameters.PageNumber, banHistoryParameters.PageSize, ct);
        }
    }
}
