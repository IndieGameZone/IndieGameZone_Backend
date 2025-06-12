using IndieGameZone.Domain.RequestFeatures;
using IndieGameZone.Domain.RequestsAndResponses.Requests.BanHistories;
using IndieGameZone.Domain.RequestsAndResponses.Responses.BanHistories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndieGameZone.Application.BanHistoryServices
{
    public interface IBanHistoryService
    {
        Task CreateBanHistory(BanHistoryForCreationDto banHistoryForCreationDto, CancellationToken ct = default);
        Task UpdateBanHistory(Guid id, BanHistoryForUpdateDto banHistoryForUpdateDto, CancellationToken ct = default);
        Task UnbanUser(Guid id, CancellationToken ct = default);
        Task DeleteBanHistory(Guid id, CancellationToken ct = default);
        Task<BanHistoryForReturnDto> GetBanHistoryById(Guid id, CancellationToken ct = default);
        Task<(IEnumerable<BanHistoryForReturnDto> banHistories, MetaData metaData)> GetBanHistories(BanHistoryParameters banHistoryParameters, CancellationToken ct = default);
    }
}
