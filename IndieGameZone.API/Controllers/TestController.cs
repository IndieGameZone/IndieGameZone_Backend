using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace IndieGameZone.API.Controllers
{
    [ApiController]
    [Route("api/test")]
    public class TestController : ControllerBase
    {
        [HttpGet("public")]
        public IActionResult Public() => Ok("Public endpoint");

        [Authorize]
        [HttpGet("protected")]
        public IActionResult Protected() => Ok("Protected endpoint");
    }

}
