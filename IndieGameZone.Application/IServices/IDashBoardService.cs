using IndieGameZone.Domain.Constants;
using IndieGameZone.Domain.RequestsAndResponses.Responses.DashBoard;
using IndieGameZone.Domain.RequestsAndResponses.Responses.Games;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndieGameZone.Application.IServices
{
    public interface IDashBoardService
    {
        Task<IEnumerable<GameWithDownloadsDto>> GetTopDownloadedGamesAsync(int top = 10, CancellationToken ct = default);
        Task<IEnumerable<GameWithSalesDto>> GetTopSellingGamesWithCountAsync(int top = 10, CancellationToken ct = default);
        Task<IEnumerable<GameWithRatingDto>> GetTopRatedGamesAsync(int top = 10, CancellationToken ct = default);
        Task<IEnumerable<GameForListReturnDto>> GetRecentlyPublishedGamesAsync(int top = 10, CancellationToken ct = default);
        Task<int> GetOnlineUserCountAsync(CancellationToken ct = default);
        Task<int> GetTotalUserCountAsync(CancellationToken ct = default);
        Task<double> GetTotalRevenueFromGamePurchaseAsync(RevenueRange range, CancellationToken ct = default);
        Task<double> GetTotalRevenueFromCommercialPackagePurchaseAsync(RevenueRange range, CancellationToken ct = default);
        Task<DashboardSummaryForReturnDto> GetDashboardSummaryAsync(RevenueRange range, CancellationToken ct = default);

    }
}
