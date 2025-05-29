using IndieGameZone.Application;
using IndieGameZone.Domain.RequestsAndResponses.Requests.Users;
using IndieGameZone.Domain.Utils;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;

namespace IndieGameZone.API.Controllers
{
	[Route("api/authentications")]
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

		[HttpPost("resend-confirmation")]
		public async Task<IActionResult> ResendEmailConfirmation([FromBody] ResendEmailDto dto, CancellationToken ct)
		{
			await serviceManager.UserService.ResendConfirmationEmail(dto.Email, ct);
			return Ok("Confirmation email resent.");
		}

		[HttpGet("email-confirm")]
		public async Task<IActionResult> ConfirmEmail([FromQuery] string token, [FromQuery] string userId, CancellationToken ct)
		{
			await serviceManager.UserService.ConfirmEmail(token, userId, ct);
			return Ok("Email confirmation success");
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

        [HttpGet("current-user")]
        [Authorize]
        public async Task<IActionResult> GetCurrentUser(CancellationToken ct)
        {
            var token = HttpContext.Request.Headers["Authorization"].ToString().Split(" ")[1];
            var user = await serviceManager.UserService.GetUserByToken(token, ct);
            return Ok(user);
        }
    }
}
