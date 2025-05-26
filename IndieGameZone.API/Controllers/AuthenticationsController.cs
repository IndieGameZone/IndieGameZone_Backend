using IndieGameZone.Application;
using IndieGameZone.Domain.RequestsAndResponses.Requests.Users;
using Microsoft.AspNetCore.Mvc;

namespace IndieGameZone.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthenticationsController : ControllerBase
    {
        private readonly IServiceManager serviceManager;

        public AuthenticationsController(IServiceManager serviceManager)
        {
            this.serviceManager = serviceManager;
        }

        [HttpPost("register")]
        public async Task<IActionResult> Register([FromBody] UserForCreationDto userForCreationDto, CancellationToken ct)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            await serviceManager.UserService.CreateUser(userForCreationDto, ct);
            return StatusCode(201);
        }

        [HttpGet("email-confirm")]
        public async Task<IActionResult> ConfirmEmail([FromQuery] string token, [FromQuery] string email, CancellationToken ct)
        {
            await serviceManager.UserService.ConfirmEmail(token, email, ct);
            return Ok("Email Confirmation Success");
        }
    }
}
