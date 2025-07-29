using IndieGameZone.Application.IServices;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace IndieGameZone.API.Controllers
{
    [ApiController]
    [Route("api/test")]
    public class TestController : ControllerBase
    {
        private readonly IServiceManager serviceManager;

        public TestController(IServiceManager serviceManager)
        {
            this.serviceManager = serviceManager;
        }

        [HttpGet("public")]
        public IActionResult Public() => Ok("Public endpoint");

        [Authorize]
        [HttpGet("protected")]
        public IActionResult Protected() => Ok("Protected endpoint");

        [HttpPost("run-status-update")]
        public async Task<IActionResult> RunStatusUpdate(CancellationToken ct)
        {
            var updatedCount = await serviceManager.CommercialPackageService.RunStatusUpdateAsync(ct);
            return Ok($"✅ Updated {updatedCount} commercial registration statuses.");
        }
    }

}
