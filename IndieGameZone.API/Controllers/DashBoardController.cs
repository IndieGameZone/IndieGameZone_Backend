using IndieGameZone.Application;
using IndieGameZone.Domain.RequestsAndResponses.Responses.Games;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
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

    }
}
