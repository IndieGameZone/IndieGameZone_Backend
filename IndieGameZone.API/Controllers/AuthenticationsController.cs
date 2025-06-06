using IndieGameZone.Application;
using IndieGameZone.Domain.RequestsAndResponses.Requests.Users;
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
			await serviceManager.UserService.CreateUser(userForCreationDto, false, ct);
			return StatusCode(201);
		}

		[HttpPost("login")]
		public async Task<IActionResult> Login([FromBody] UserForAuthenticationDto userForAuth, CancellationToken ct)
		{
			var user = await serviceManager.UserService.ValidateUser(userForAuth, ct);

			if (user == null)
				return Unauthorized();

			var tokenDto = await serviceManager.UserService.CreateToken(user, true, ct);

			// Set refresh token cookie
			Response.Cookies.Append("refreshToken", tokenDto.RefreshToken!, new CookieOptions
			{
				HttpOnly = true,
				Secure = true,
				SameSite = SameSiteMode.Lax,
				Expires = tokenDto.RefreshTokenExpiry
			});

			return Ok(tokenDto.AccessToken);
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
		public async Task<IActionResult> RefreshToken(CancellationToken ct)
		{
			var accessToken = Request.Headers["Authorization"].FirstOrDefault()?.Split(" ").Last();
			if (string.IsNullOrEmpty(accessToken))
				return BadRequest("Access token is missing");

			if (!Request.Cookies.TryGetValue("refreshToken", out var refreshToken))
				return Unauthorized("Refresh token not found");

			try
			{
				var tokenDto = await serviceManager.UserService.RefreshToken(accessToken, refreshToken, ct);

				Response.Cookies.Append("refreshToken", tokenDto.RefreshToken!, new CookieOptions
				{
					HttpOnly = true,
					Secure = true,
					SameSite = SameSiteMode.None,
					Expires = tokenDto.RefreshTokenExpiry
				});

				return Ok(tokenDto.AccessToken);
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

		[HttpPost("password-reset-request")]
		public async Task<IActionResult> SendResetPasswordToken([FromForm] string email, CancellationToken ct)
		{
			await serviceManager.UserService.SendResetPasswordToken(email, ct);
			return Ok();
		}

		[HttpPut("password-reset")]
		public async Task<IActionResult> ResetPassword([FromBody] UserForResetPasswordDto userForResetPasswordDto, CancellationToken ct)
		{
			await serviceManager.UserService.ResetPassword(userForResetPasswordDto, ct);
			return Ok();
		}
	}
}
