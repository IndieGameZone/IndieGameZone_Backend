
using IndieGameZone.Application.IServices;
using IndieGameZone.Domain.Constants;
using IndieGameZone.Domain.RequestsAndResponses.Responses.DashBoard;
using IndieGameZone.Domain.RequestsAndResponses.Responses.Games;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Intrinsics.X86;

namespace IndieGameZone.API.Controllers
{
    [Route("api/dashboard")]
    [ApiController]
    public class DashBoardController : ControllerBase
    {
        private readonly IServiceManager serviceManager;

        public DashBoardController(IServiceManager serviceManager)
        {
            this.serviceManager = serviceManager;
        }

        [HttpGet("top-downloaded-games")]
        public async Task<ActionResult<IEnumerable<GameWithDownloadsDto>>> GetTopDownloadedGames([FromQuery] int top = 10, CancellationToken ct = default)
        {
            var games = await serviceManager.DashBoardService.GetTopDownloadedGamesAsync(top, ct);
            return Ok(games);
        }
        
        [HttpGet("top-selling")]
        public async Task<ActionResult<IEnumerable<GameWithSalesDto>>> GetTopSellingGames([FromQuery] int top = 10, CancellationToken ct = default)
        {
            var result = await serviceManager.DashBoardService.GetTopSellingGamesWithCountAsync(top, ct);
            return Ok(result);
        }

        [HttpGet("top-rated")]
        public async Task<ActionResult<IEnumerable<GameWithRatingDto>>> GetTopRatedGames([FromQuery] int top = 10, CancellationToken ct = default)
        {
            var result = await serviceManager.DashBoardService.GetTopRatedGamesAsync(top, ct);
            return Ok(result);
        }

        [HttpGet("recently-published")]
        public async Task<ActionResult<IEnumerable<GameForListReturnDto>>> GetRecentlyPublishedGames([FromQuery] int top = 10, CancellationToken ct = default)
        {
            var games = await serviceManager.DashBoardService.GetRecentlyPublishedGamesAsync(top, ct);
            return Ok(games);
        }

        [HttpGet("online-count")]
        public async Task<ActionResult<int>> GetOnlineUserCount(CancellationToken ct)
        {
            var count = await serviceManager.DashBoardService.GetOnlineUserCountAsync(ct);
            return Ok(count);
        }

        [HttpGet("total-users")]
        public async Task<ActionResult<int>> GetTotalUsers(CancellationToken ct)
        {
            var count = await serviceManager.DashBoardService.GetTotalUserCountAsync(ct);
            return Ok(count);
        }

        [HttpGet("revenue/developers/total-current")]
        public async Task<ActionResult<double>> GetTotalCurrentBalanceOfAllDevelopers(CancellationToken ct = default)
        {
            var total = await serviceManager.DashBoardService.GetTotalCurrentBalanceOfAllDevelopersAsync(ct);
            return Ok(total);
        }

        [HttpGet("revenue/games/developers")]
        public async Task<ActionResult<double>> GetGamePurchaseRevenueByDeveloper([FromQuery] RevenueRange range = RevenueRange.AllTime, CancellationToken ct = default)
        {
            var total = await serviceManager.DashBoardService.GetTotalRevenueFromGamePurchaseByDeveloperAsync(range, ct);
            return Ok(total);
        }
        
        [HttpGet("revenue/games/admin")]
        public async Task<ActionResult<double>> GetGamePurchaseRevenueByAdmin([FromQuery] RevenueRange range = RevenueRange.AllTime, CancellationToken ct = default)
        {
            var total = await serviceManager.DashBoardService.GetTotalRevenueFromGamePurchaseByAdminAsync(range, ct);
            return Ok(total);
        }

        [HttpGet("revenue/commercial-packages")]
        public async Task<ActionResult<double>> GetCommercialPackageRevenue([FromQuery] RevenueRange range = RevenueRange.AllTime, CancellationToken ct = default)
        {
            var total = await serviceManager.DashBoardService.GetTotalRevenueFromCommercialPackagePurchaseAsync(range, ct);
            return Ok(total);
        }

        [HttpGet("revenue/commercial-packages/monthly-stats")]
        public async Task<ActionResult<IEnumerable<CommercialRevenueByDayForReturnDto>>> GetCommercialPackageRevenueByMonth([FromQuery][Required] int year, [FromQuery][Required] int month, CancellationToken ct = default)
        {
            var result = await serviceManager.DashBoardService
                .GetCommercialPackageRevenueByMonthAsync(year, month, ct);

            return Ok(result);
        }

        [HttpGet("summary")]
        public async Task<ActionResult<DashboardSummaryForReturnDto>> GetDashboardSummary([FromQuery] RevenueRange range = RevenueRange.AllTime, CancellationToken ct = default)
        {
            var summary = await serviceManager.DashBoardService.GetDashboardSummaryAsync(range, ct);
            return Ok(summary);
        }

        [HttpGet("developers/{developerId:guid}/summary")]
        public async Task<ActionResult<DeveloperDashboardSummaryForReturnDto>> GetDeveloperDashboard([FromRoute] Guid developerId, CancellationToken ct = default)
        {
            var dashboardData = await serviceManager.DashBoardService.GetDeveloperDashboardAsync(developerId, ct);
            return Ok(dashboardData);
        }

        [HttpGet("developers/{developerId:guid}/monthly-stats")]
        public async Task<ActionResult<IEnumerable<RevenueByDayForReturnDto>>> GetRevenueByMonth([FromRoute] Guid developerId, [FromQuery][Required] int year, [FromQuery][Required] int month, CancellationToken ct = default)
        {
            var result = await serviceManager.DashBoardService.GetRevenueByMonthAsync(developerId, year, month, ct);
            return Ok(result);
        }

        [HttpGet("games/{gameId:guid}/summary")]
        public async Task<ActionResult<GameDashboardSummaryForReturnDto>> GetGameDashboard([FromRoute] Guid gameId, CancellationToken ct = default)
        {
            var dashboard = await serviceManager.DashBoardService.GetGameDashboardAsync(gameId, ct);
            return Ok(dashboard);
        }

        [HttpGet("games/{gameId:guid}/monthly-stats")]
        public async Task<ActionResult<IEnumerable<GameMonthlyStatsByDayForReturnDto>>> GetGameMonthlyStats([FromRoute] Guid gameId, [FromQuery][Required] int year, [FromQuery][Required] int month, CancellationToken ct = default)
        {
            var result = await serviceManager.DashBoardService.GetGameMonthlyStatsAsync(gameId, year, month, ct);
            return Ok(result);
        }

        [HttpGet("admin-bank-balance")]
        public async Task<ActionResult<double>> GetAdminBankBalance(CancellationToken ct)
        {
            var result = await serviceManager.DashBoardService.GetAdminBankBalanceAsync(ct);

            return Ok(result);
        }

        [HttpGet("players/new/monthly-stats")]
        public async Task<ActionResult<IEnumerable<NewPlayersByMonthForReturnDto>>> GetNewPlayersByMonth([FromQuery][Required] int year, CancellationToken ct = default)
        {
            var result = await serviceManager.UserService.GetNewPlayersByMonthAsync(year, ct);
            return Ok(result);
        }

    }
}
