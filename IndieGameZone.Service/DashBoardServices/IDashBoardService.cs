using IndieGameZone.Domain.RequestsAndResponses.Responses.Games;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndieGameZone.Application.DashBoardServices
{
    public interface IDashBoardService
    {
        Task<IEnumerable<GameWithDownloadsDto>> GetTopDownloadedGamesAsync(int top = 10, CancellationToken ct = default);
        Task<IEnumerable<GameWithSalesDto>> GetTopSellingGamesWithCountAsync(int top = 10, CancellationToken ct = default);
        Task<IEnumerable<GameWithRatingDto>> GetTopRatedGamesAsync(int top = 10, CancellationToken ct = default);
        Task<IEnumerable<GameForListReturnDto>> GetRecentlyPublishedGamesAsync(int top = 10, CancellationToken ct = default);
        Task<int> GetOnlineUserCountAsync(CancellationToken ct = default);
        Task<int> GetTotalUserCountAsync(CancellationToken ct = default);

    }
}
