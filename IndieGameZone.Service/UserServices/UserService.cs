using IndieGameZone.Application.EmailServices;
using IndieGameZone.Domain.Constants;
using IndieGameZone.Domain.Entities;
using IndieGameZone.Domain.Exceptions;
using IndieGameZone.Domain.IRepositories;
using IndieGameZone.Domain.RequestsAndResponses.Requests.Users;
using IndieGameZone.Domain.Utils;
using MapsterMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.WebUtilities;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Security.Cryptography;
using System.Text;

namespace IndieGameZone.Application.UserServices
{
	internal sealed class UserService : IUserService
	{
		private readonly IRepositoryManager repositoryManager;
		private readonly IMapper mapper;
		private readonly UserManager<Users> userManager;
		private readonly RoleManager<Roles> roleManager;
		private readonly IEmailSender emailSender;
		private readonly IHttpContextAccessor httpContextAccessor;
		private readonly IConfiguration configuration;

		public UserService(IRepositoryManager repositoryManager, IMapper mapper, UserManager<Users> userManager, RoleManager<Roles> roleManager, IEmailSender emailSender, IHttpContextAccessor httpContextAccessor, IConfiguration configuration)
		{
			this.repositoryManager = repositoryManager;
			this.mapper = mapper;
			this.userManager = userManager;
			this.roleManager = roleManager;
			this.emailSender = emailSender;
			this.httpContextAccessor = httpContextAccessor;
			this.configuration = configuration;
		}

		private async Task CheckUserExistWhenRegister(string userName, string email, CancellationToken ct = default)
		{
			if (await userManager.FindByNameAsync(userName) is not null)
				throw new UserBadRequestException("Username already exists");

			if (await userManager.FindByEmailAsync(email) is not null)
				throw new UserBadRequestException("Email already exists");
		}

		private async Task<Users?> CheckUserExistById(Guid userId, CancellationToken ct = default)
		{
			var user = await userManager.FindByIdAsync(userId.ToString());
			if (user == null) throw new UserNotFoundException();
			return user;
		}

		public async Task CreateUser(UserForCreationDto userForCreationDto, CancellationToken ct = default)
		{
			await CheckUserExistWhenRegister(userForCreationDto.UserName, userForCreationDto.Email);
			if (userForCreationDto.Role != RoleEnum.Player && userForCreationDto.Role != RoleEnum.Developer)
			{
				throw new InvalidOperationException("Only 'Player' and 'Developer' roles are allowed during registration.");
			}
			var user = mapper.Map<Users>(userForCreationDto);

			user.Id = Guid.NewGuid();
			user.EmailConfirmed = false;
			user.LockoutEnabled = true;
			user.IsActive = true;
			user.JoinedDate = DateTime.UtcNow;
			user.LastLogin = DateTime.UtcNow;

			// Create the user
			var result = await userManager.CreateAsync(user, userForCreationDto.Password);
			if (!result.Succeeded)
			{
				throw new InvalidOperationException(string.Join("; ", result.Errors.Select(e => e.Description)));
			}

			// Convert RoleEnum to string
			var roleName = userForCreationDto.Role.ToString();

			// Check if role exists in DB
			var roleExists = await roleManager.RoleExistsAsync(roleName);
			if (!roleExists)
			{
				throw new InvalidOperationException($"Role '{roleName}' does not exist in the database.");
			}

			// Assign role to user
			var roleResult = await userManager.AddToRoleAsync(user, roleName);
			if (!roleResult.Succeeded)
			{
				throw new InvalidOperationException(string.Join("; ", roleResult.Errors.Select(e => e.Description)));
			}

			// ✅ Create UserProfile and Wallet after successful user creation
			var userProfile = new UserProfiles
			{
				UserId = user.Id,
				Avatar = "https://media.istockphoto.com/vectors/default-profile-picture-avatar-photo-placeholder-vector-illustration-vector-id1223671392?k=6&m=1223671392&s=170667a&w=0&h=zP3l7WJinOFaGb2i1F4g8IS2ylw0FlIaa6x3tP9sebU=",
				Birthday = userForCreationDto.Birthday,
			};

			var wallet = new Wallets
			{
				UserId = user.Id,
				Balance = 0,
			};

			repositoryManager.UserProfileRepository.CreateUserProfile(userProfile);
			repositoryManager.WalletRepository.CreateWallet(wallet);
			await repositoryManager.SaveAsync(ct);

			string token = await userManager.GenerateEmailConfirmationTokenAsync(user);

			var request = httpContextAccessor.HttpContext?.Request;
			var param = new Dictionary<string, string?>
			{
				{ "token", token },
				{ "email", user.Email }
			};
			var uri = $"{request?.Scheme}://{request?.Host}/api/auth/email-confirm";
			var callbackUrl = QueryHelpers.AddQueryString(uri, param);

			var emailBody = $@"
        <p>Hi {user.UserName},</p>
        <p>Welcome to Indie Game Zone!</p>
        <p>Please confirm your email by clicking the link below:</p>
        <p><a href='{callbackUrl}'>Confirm Email</a></p>
        <p>If you didn’t register, please ignore this email.</p>";

			var mail = new Mail(user.Email!, "Email Confirmation – Indie Game Zone", emailBody);
			emailSender.SendEmail(mail);
		}
		public async Task ConfirmEmail(string token, string email, CancellationToken ct = default)
		{
			var user = await userManager.FindByEmailAsync(email);
			if (user == null) throw new RequestTokenBadRequest();

			var result = await userManager.ConfirmEmailAsync(user, token);
			if (!result.Succeeded)
			{
				throw new RequestTokenBadRequest();
			}
		}

		public async Task<Users> ValidateUser(UserForAuthenticationDto userForAuth, CancellationToken ct = default)
		{
			Users? user = await userManager.FindByNameAsync(userForAuth.UserNameOrEmail!);
			if (user == null)
				user = await userManager.FindByEmailAsync(userForAuth.UserNameOrEmail!);

			if (user == null)
				throw new NotAuthenticatedException("Username or password is incorrect");

			if (!user.IsActive)
				throw new NotAuthenticatedException("User is deactivated");

			if (!user.EmailConfirmed)
				throw new NotAuthenticatedException("Your email has not been confirmed yet");

			bool isPasswordValid = await userManager.CheckPasswordAsync(user, userForAuth.Password!);
			if (!isPasswordValid)
				throw new NotAuthenticatedException("Username or password is incorrect");

			// ✅ Optionally update last login here:
			user.LastLogin = DateTime.UtcNow;
			await userManager.UpdateAsync(user);

			return user;
		}

		public async Task<TokenDto> CreateToken(Users user, bool setRefreshExpiry, CancellationToken ct = default)
		{
			var jwtSettings = configuration.GetSection("JwtSettings");
			var signingCredentials = GetSigningCredentials();
			var claims = await GetClaims(user);
			var tokenOptions = GenerateTokenOptions(signingCredentials, claims);

			user.RefreshToken = GenerateToken();

			if (setRefreshExpiry)
				user.RefreshTokenExpiryTime = DateTime.UtcNow.AddDays(Convert.ToDouble(jwtSettings["refreshTokenExpires"]));

			await userManager.UpdateAsync(user);

			return new TokenDto
			{
				AccessToken = new JwtSecurityTokenHandler().WriteToken(tokenOptions),
				RefreshToken = user.RefreshToken
			};
		}

		private SigningCredentials GetSigningCredentials()
		{
			var key = Encoding.UTF8.GetBytes(configuration.GetSection("SecretKey").Value!);
			var secret = new SymmetricSecurityKey(key);
			return new SigningCredentials(secret, SecurityAlgorithms.HmacSha256);
		}

		private async Task<List<Claim>> GetClaims(Users user)
		{
			var claims = new List<Claim>
		{
			new Claim(ClaimTypes.Name, user.UserName!),
			new Claim(ClaimTypes.NameIdentifier, user.Id.ToString()),
			new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString()),
		};

			var roles = await userManager.GetRolesAsync(user);

			foreach (var role in roles)
			{
				claims.Add(new Claim(ClaimTypes.Role, role));
			}

			return claims;
		}

		private JwtSecurityToken GenerateTokenOptions(SigningCredentials signingCredentials,
			List<Claim> claims)
		{
			var jwtSettings = configuration.GetSection("JwtSettings");
			var tokenOptions = new JwtSecurityToken
			(
				issuer: jwtSettings["validIssuer"],
				audience: jwtSettings["validAudience"],
				claims: claims,
				expires: DateTime.UtcNow.AddMinutes(Convert.ToDouble(jwtSettings["accessTokenExpires"])),
				signingCredentials: signingCredentials
			);
			return tokenOptions;
		}

		private string GenerateToken()
		{
			var randomBytes = new byte[32];
			using var rng = RandomNumberGenerator.Create();
			rng.GetBytes(randomBytes);
			return Convert.ToBase64String(randomBytes);
		}

		private string GenerateOTP()
		{
			Random random = new Random();
			int otp = random.Next(100000, 999999);
			return otp.ToString();
		}

		private ClaimsPrincipal GetPrincipalFromExpiredToken(string token)
		{
			var jwtSettings = configuration.GetSection("JwtSettings");
			var secretKey = configuration.GetSection("SecretKey").Value!;
			var tokenValidationParameters = new TokenValidationParameters
			{
				ValidateIssuer = true,
				ValidateAudience = true,
				ValidateLifetime = false,
				ValidateIssuerSigningKey = true,

				ValidIssuer = jwtSettings["validIssuer"],
				ValidAudience = jwtSettings["validAudience"],
				IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(secretKey))
			};

			var tokenHandler = new JwtSecurityTokenHandler();
			SecurityToken securityToken;
			var principal = tokenHandler.ValidateToken(token, tokenValidationParameters, out securityToken);
			var jwtSecurityToken = securityToken as JwtSecurityToken;

			if (jwtSecurityToken == null ||
				!jwtSecurityToken.Header.Alg.Equals(SecurityAlgorithms.HmacSha256, StringComparison.InvariantCultureIgnoreCase))
				throw new SecurityTokenException("Invalid token");

			return principal;
		}

		public async Task<TokenDto> RefreshToken(TokenDto tokenDto, CancellationToken ct = default)
		{
			var principal = GetPrincipalFromExpiredToken(tokenDto.AccessToken);
			var username = principal.Identity!.Name!;

			var user = await userManager.FindByNameAsync(username);
			if (user == null || user.RefreshToken != tokenDto.RefreshToken || user.RefreshTokenExpiryTime <= DateTime.UtcNow)
				throw new SecurityTokenException("Invalid refresh token");

			return await CreateToken(user, false, ct);
		}
	}
}
