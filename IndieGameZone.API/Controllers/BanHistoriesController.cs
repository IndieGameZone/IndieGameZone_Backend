using IndieGameZone.Application;
using IndieGameZone.Domain.RequestFeatures;
using IndieGameZone.Domain.RequestsAndResponses.Requests.Achievements;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Text.Json;

namespace IndieGameZone.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BanHistoriesController : ControllerBase
    {
        private readonly IServiceManager serviceManager;

        public BanHistoriesController(IServiceManager serviceManager)
        {
            this.serviceManager = serviceManager;
        }

        //[HttpGet]
        //public async Task<IActionResult> GetBanHistories([FromQuery] AchievementParameters achievementParameters, CancellationToken ct)
        //{
        //    var pagedResult = await serviceManager.AchievementService.GetAchievements(achievementParameters, ct);
        //    Response.Headers.Append("X-Pagination", JsonSerializer.Serialize(pagedResult.metaData));
        //    return Ok(pagedResult.achievements);
        //}

        //[HttpGet("{id:guid}")]
        //public async Task<IActionResult> GetBanHistoryById([FromRoute] Guid id, CancellationToken ct)
        //{
        //    var achievement = await serviceManager.AchievementService.GetAchievementById(id, ct);
        //    return Ok(achievement);
        //}

        [HttpPost]
        public async Task<IActionResult> CreateBanHistory([FromBody] AchievementForCreationDto achievementForCreationDto, CancellationToken ct)
        {
            await serviceManager.AchievementService.CreateAchievement(achievementForCreationDto, ct);
            return StatusCode(201);
        }

        //[HttpPut("{id:guid}")]
        //public async Task<IActionResult> UpdateBanHistory([FromRoute] Guid id, [FromBody] AchievementForUpdateDto achievementForUpdateDto, CancellationToken ct)
        //{
        //    await serviceManager.AchievementService.UpdateAchievement(id, achievementForUpdateDto, ct);
        //    return NoContent();
        //}

        //[HttpPatch("{id:guid}/unban")]
        //public async Task<IActionResult> UnbanUser([FromRoute] Guid id, [FromBody] AchievementForUpdateDto achievementForUpdateDto, CancellationToken ct)
        //{
        //    await serviceManager.AchievementService.UpdateAchievement(id, achievementForUpdateDto, ct);
        //    return NoContent();
        //}

        //[HttpDelete("{id:guid}")]
        //public async Task<IActionResult> DeleteBanHistory([FromRoute] Guid id, CancellationToken ct)
        //{
        //    await serviceManager.AchievementService.DeleteAchievement(id, ct);
        //    return NoContent();
        //}
    }
}
