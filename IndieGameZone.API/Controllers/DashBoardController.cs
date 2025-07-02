using IndieGameZone.Application;
using IndieGameZone.Domain.RequestsAndResponses.Responses.Games;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

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
        public async Task<ActionResult<IEnumerable<GameForListReturnDto>>> GetTopDownloadedGames(CancellationToken ct)
        {
            var games = await serviceManager.DashBoardService.GetTop10MostDownloadedGamesAsync(ct);
            return Ok(games);
        }



    }
}
