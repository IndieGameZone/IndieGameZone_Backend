using IndieGameZone.Application;
using IndieGameZone.Application.UserServices;
using IndieGameZone.Domain.RequestsAndResponses.Requests.Users;
using IndieGameZone.Domain.Utils;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;

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

        [HttpPost("login")]
        public async Task<IActionResult> Login([FromBody] UserForAuthenticationDto userForAuth, CancellationToken ct)
        {
            var user = await serviceManager.UserService.ValidateUser(userForAuth, ct);

            if (user != null)
            {
                var token = await serviceManager.UserService.CreateToken(user, true, ct);
                return Ok(token);
            }

            return Unauthorized();
        }


        [HttpGet("email-confirm")]
        public async Task<IActionResult> ConfirmEmail([FromQuery] string token, [FromQuery] string email, CancellationToken ct)
        {
            await serviceManager.UserService.ConfirmEmail(token, email, ct);
            return Ok("Email Confirmation Success");
        }


        [HttpPost("refresh-token")]
        public async Task<IActionResult> RefreshToken([FromBody] TokenDto tokenDto, CancellationToken ct)
        {
            if (tokenDto is null)
                return BadRequest("Invalid client request");

            try
            {
                var newToken = await serviceManager.UserService.RefreshToken(tokenDto, ct);
                return Ok(newToken);
            }
            catch (SecurityTokenException)
            {
                return Unauthorized("Invalid or expired refresh token");
            }
        }
    }
}
