using IndieGameZone.Application;
using IndieGameZone.Domain.RequestFeatures;
using IndieGameZone.Domain.RequestsAndResponses.Requests.BanHistories;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Text.Json;

namespace IndieGameZone.API.Controllers
{
    [Route("api/ban-histories")]
    [ApiController]
    public class BanHistoriesController : ControllerBase
    {
        private readonly IServiceManager serviceManager;

        public BanHistoriesController(IServiceManager serviceManager)
        {
            this.serviceManager = serviceManager;
        }

        [HttpGet]
        public async Task<IActionResult> GetBanHistories([FromQuery] BanHistoryParameters banHistoryParameters, CancellationToken ct)
        {
            var pagedResult = await serviceManager.BanHistoryService.GetBanHistories(banHistoryParameters, ct);
            Response.Headers.Append("X-Pagination", JsonSerializer.Serialize(pagedResult.metaData));
            return Ok(pagedResult.banHistories);
        }

        [HttpGet("{id:guid}")]
        public async Task<IActionResult> GetBanHistoryById([FromRoute] Guid id, CancellationToken ct)
        {
            var banHistory = await serviceManager.BanHistoryService.GetBanHistoryById(id, ct);
            return Ok(banHistory);
        }

        [HttpGet("users/{userId:guid}")]
        public async Task<IActionResult> GetBanHistoriesByUserId(Guid userId, [FromQuery] BanHistoryParameters banHistoryParameters, CancellationToken ct)
        {
            var pagedResult = await serviceManager.BanHistoryService.GetBanHistoriesByUserId(userId, banHistoryParameters, false, ct);
            Response.Headers.Append("X-Pagination", JsonSerializer.Serialize(pagedResult.metaData));
            return Ok(pagedResult.banHistories);
        }

        [HttpPost]
        public async Task<IActionResult> CreateBanHistory([FromBody] BanHistoryForCreationDto banHistoryForCreationDto, CancellationToken ct)
        {
            await serviceManager.BanHistoryService.CreateBanHistory(banHistoryForCreationDto, ct);
            return StatusCode(201);
        }

        [HttpPut("{id:guid}")]
        public async Task<IActionResult> UpdateBanHistory([FromRoute] Guid id, [FromBody] BanHistoryForUpdateDto banHistoryForUpdateDto, CancellationToken ct)
        {
            await serviceManager.BanHistoryService.UpdateBanHistory(id, banHistoryForUpdateDto, ct);
            return NoContent();
        }

        [HttpPatch("{userId:guid}/unban")]
        public async Task<IActionResult> UnbanUser([FromRoute] Guid userId, CancellationToken ct)
        {
            await serviceManager.BanHistoryService.UnbanUser(userId, ct);
            return NoContent();
        }

        //[HttpDelete("{id:guid}")]
        //public async Task<IActionResult> DeleteBanHistory([FromRoute] Guid id, CancellationToken ct)
        //{
        //    await serviceManager.BanHistoryService.DeleteBanHistory(id, ct);
        //    return NoContent();
        //}
    }
}
