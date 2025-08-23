
using Bogus;
using FirebaseAdmin.Auth;
using IndieGameZone.Application.IServices;
using IndieGameZone.Domain.Constants;
using IndieGameZone.Domain.Entities;
using IndieGameZone.Domain.Exceptions;
using IndieGameZone.Domain.IRepositories;
using IndieGameZone.Domain.RequestFeatures;
using IndieGameZone.Domain.RequestsAndResponses.Requests.Users;
using IndieGameZone.Domain.RequestsAndResponses.Responses.DashBoard;
using IndieGameZone.Domain.RequestsAndResponses.Responses.Users;
using IndieGameZone.Domain.Utils;
using MapsterMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.WebUtilities;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Security.Cryptography;
using System.Text;

namespace IndieGameZone.Application.Services
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
		private readonly IBlobService blobService;
		private readonly Faker faker;
		private readonly IRecombeeService recombeeService;

		public UserService(IRepositoryManager repositoryManager, IMapper mapper, UserManager<Users> userManager, RoleManager<Roles> roleManager, IEmailSender emailSender, IHttpContextAccessor httpContextAccessor, IConfiguration configuration, IBlobService blobService, Faker faker, IRecombeeService recombeeService)
		{
			this.repositoryManager = repositoryManager;
			this.mapper = mapper;
			this.userManager = userManager;
			this.roleManager = roleManager;
			this.emailSender = emailSender;
			this.httpContextAccessor = httpContextAccessor;
			this.configuration = configuration;
			this.blobService = blobService;
			this.faker = faker;
			this.recombeeService = recombeeService;
		}

		private async Task CheckUserExistWhenRegister(string userName, string email, CancellationToken ct = default)
		{
			if (await userManager.FindByNameAsync(userName) is not null)
				throw new UserBadRequestException("Username already exists");

			if (await userManager.FindByEmailAsync(email) is not null)
				throw new UserBadRequestException("Email already exists");
		}

		public async Task<UserForReturnDto> GetUserById(string userId, CancellationToken ct = default)
		{
			if (!Guid.TryParse(userId, out var guidUserId))
				throw new ArgumentException("Invalid user ID format", nameof(userId));

			var user = await userManager.Users
				.Include(u => u.UserProfile)
				.Include(u => u.Wallet)
				.FirstOrDefaultAsync(u => u.Id == guidUserId, ct);

			if (user == null)
				throw new UserNotFoundException();

			bool hasActiveBan = await repositoryManager.BanHistoryRepository.HasActiveBanAsync(user.Id, DateTime.Now, ct);

			user.IsActive = !hasActiveBan;
			await userManager.UpdateAsync(user);

			var dto = mapper.Map<UserForReturnDto>(user);

			var roleName = (await userManager.GetRolesAsync(user)).FirstOrDefault();

			dto = dto with
			{
				Role = !string.IsNullOrWhiteSpace(roleName)
					? new RoleForReturnDto { Name = roleName }
					: null
			};

			return dto;
		}

		public async Task CreateUser(UserForCreationDto userForCreationDto, bool adminFlag, CancellationToken ct = default)
		{
			await CheckUserExistWhenRegister(userForCreationDto.UserName, userForCreationDto.Email);
			if (!adminFlag)
			{
				if (userForCreationDto.Role != RoleEnum.Player && userForCreationDto.Role != RoleEnum.Developer)
				{
					throw new InvalidOperationException("Only 'Player' and 'Developer' roles are allowed during registration.");
				}
			}

			var user = mapper.Map<Users>(userForCreationDto);

			user.Id = Guid.NewGuid();
			user.EmailConfirmed = false;
			user.LockoutEnabled = true;
			user.IsActive = true;
			user.JoinedDate = DateTime.Now;
			user.LastLogin = DateTime.Now;
			if (adminFlag)
			{
				user.EmailConfirmed = true;
			}

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
			if (!adminFlag)
			{
				await SendConfirmationEmailAsync(user, ct);
			}
			await recombeeService.PushUserToRecombee(user.Id);
		}

		public async Task ResendConfirmationEmail(string email, CancellationToken ct = default)
		{
			var user = await userManager.FindByEmailAsync(email);
			if (user == null || user.EmailConfirmed)
				throw new UserBadRequestException("Invalid or already confirmed email.");

			await SendConfirmationEmailAsync(user, ct);
		}

		private async Task SendConfirmationEmailAsync(Users user, CancellationToken ct = default)
		{
			string token = await userManager.GenerateEmailConfirmationTokenAsync(user);
			string encodedToken = WebEncoders.Base64UrlEncode(Encoding.UTF8.GetBytes(token));

			var request = httpContextAccessor.HttpContext?.Request;
			var param = new Dictionary<string, string?>
			{
				{ "token", encodedToken },
				{ "userId", user.Id.ToString() }
			};

			var uri = $"{request?.Scheme}://indie-game-zone.vercel.app/verify-email";
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

		public async Task ConfirmEmail(string token, string userId, CancellationToken ct = default)
		{
			var user = await userManager.FindByIdAsync(userId);
			if (user == null) throw new UserNotFoundException();

			string decodedToken = Encoding.UTF8.GetString(WebEncoders.Base64UrlDecode(token));
			var result = await userManager.ConfirmEmailAsync(user, decodedToken);
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
				throw new NotAuthenticatedException("User not found");

			bool isPasswordValid = await userManager.CheckPasswordAsync(user, userForAuth.Password!);
			if (!isPasswordValid)
			{
				if (await userManager.IsLockedOutAsync(user))
				{
					var lockoutEnd = await userManager.GetLockoutEndDateAsync(user);
					if (lockoutEnd.HasValue)
					{
						var timeLeft = lockoutEnd.Value.DateTime - DateTime.Now;
						throw new NotAuthenticatedException(
							$"Your account is locked due to multiple failed login attempts. " +
							$"Please try again in {timeLeft.Minutes} minute(s) and {timeLeft.Seconds} second(s).");
					}

					throw new NotAuthenticatedException("Your account is locked due to multiple failed login attempts. Please try again later.");
				}

				// ❌ Increment failed login attempts
				await userManager.AccessFailedAsync(user);

				if (await userManager.IsLockedOutAsync(user))
				{
					var lockoutEnd = await userManager.GetLockoutEndDateAsync(user);
					if (lockoutEnd.HasValue)
					{
						var timeLeft = lockoutEnd.Value.DateTime - DateTime.Now;
						throw new NotAuthenticatedException(
							$"Your account has been locked due to multiple failed login attempts. " +
							$"Please try again in {timeLeft.Minutes} minute(s) and {timeLeft.Seconds} second(s).");
					}

					throw new NotAuthenticatedException("Your account has been locked due to multiple failed login attempts.");
				}

				throw new NotAuthenticatedException("Username or password is incorrect");
			}

			// 🛑 Check if account is locked
			if (await userManager.IsLockedOutAsync(user))
			{
				var lockoutEnd = await userManager.GetLockoutEndDateAsync(user);
				if (lockoutEnd.HasValue)
				{
					var timeLeft = lockoutEnd.Value.DateTime - DateTime.Now;
					throw new NotAuthenticatedException(
						$"Your account is locked due to multiple failed login attempts. " +
						$"Please try again in {timeLeft.Minutes} minute(s) and {timeLeft.Seconds} second(s).");
				}

				throw new NotAuthenticatedException("Your account is locked due to multiple failed login attempts. Please try again later.");
			}

			await CheckAndUpdateBanStatusAsync(user, ct);

			if (!user.EmailConfirmed)
				throw new NotAuthenticatedException("Your email has not been confirmed yet");

			// ✅ Reset failed count on successful login
			await userManager.ResetAccessFailedCountAsync(user);

			user.LastLogin = DateTime.Now;
			await userManager.UpdateAsync(user);

			return user;
		}

		public async Task<TokenDto> CreateToken(Users user, bool setRefreshExpiry, CancellationToken ct = default)
		{
			var jwtSettings = configuration.GetSection("JwtSettings");
			var signingCredentials = GetSigningCredentials();
			var claims = await GetClaims(user);
			var tokenOptions = GenerateTokenOptions(signingCredentials, claims);

			var refreshToken = await GenerateAndStoreRefreshToken(user, setRefreshExpiry, ct);

			return new TokenDto
			{
				AccessToken = new JwtSecurityTokenHandler().WriteToken(tokenOptions),
				RefreshToken = refreshToken,
				RefreshTokenExpiry = user.RefreshTokenExpiryTime ?? DateTime.Now.AddDays(Convert.ToDouble(jwtSettings["refreshTokenExpires"]))
			};
		}

		private async Task<string> GenerateAndStoreRefreshToken(Users user, bool setRefreshExpiry, CancellationToken ct = default)
		{
			var jwtSettings = configuration.GetSection("JwtSettings");

			user.RefreshToken = GenerateToken();
			if (setRefreshExpiry)
				user.RefreshTokenExpiryTime = DateTime.Now.AddDays(Convert.ToDouble(jwtSettings["refreshTokenExpires"]));

			await userManager.UpdateAsync(user);

			return user.RefreshToken;
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
				expires: DateTime.Now.AddMinutes(Convert.ToDouble(jwtSettings["accessTokenExpires"])),
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

		public async Task<TokenDto> RefreshToken(string accessToken, string refreshToken, CancellationToken ct = default)
		{
			var principal = GetPrincipalFromExpiredToken(accessToken);
			var username = principal.Identity!.Name!;

			var user = await userManager.FindByNameAsync(username);
			if (user == null ||
				user.RefreshToken != refreshToken ||
				user.RefreshTokenExpiryTime <= DateTime.Now)
			{
				throw new SecurityTokenException("Invalid or expired refresh token");
			}

			await CheckAndUpdateBanStatusAsync(user, ct);

			return await CreateToken(user, setRefreshExpiry: false, ct);
		}

		public async Task<UserForReturnDto> GetUserByToken(string jwt, CancellationToken ct = default)
		{
			var handler = new JwtSecurityTokenHandler();
			var token = handler.ReadJwtToken(jwt);
			var userId = token.Claims.First(claim => claim.Type == ClaimTypes.NameIdentifier).Value;

			var user = await userManager.FindByIdAsync(userId);
			if (user == null)
				throw new NotAuthenticatedException("User not found");
			await CheckAndUpdateBanStatusAsync(user, ct);

			var dto = await GetUserById(userId, ct);
			if (dto == null) throw new UserNotFoundException();
			return dto;
		}

		public async Task<(IEnumerable<UserForReturnDto> users, MetaData metaData)> GetUsers(UserParameters userParameters, CancellationToken ct = default)
		{
			var usersWithMetaData = await repositoryManager.UserRepository.GetUsers(userParameters, true, ct);

			var dtoList = new List<UserForReturnDto>();

			foreach (var user in usersWithMetaData)
			{
				bool hasActiveBan = await repositoryManager.BanHistoryRepository.HasActiveBanAsync(user.Id, DateTime.Now, ct);

				user.IsActive = !hasActiveBan;
				await userManager.UpdateAsync(user);

				var dto = mapper.Map<UserForReturnDto>(user);

				var roleName = (await userManager.GetRolesAsync(user)).FirstOrDefault();

				dtoList.Add(dto with
				{
					Role = !string.IsNullOrWhiteSpace(roleName)
						? new RoleForReturnDto { Name = roleName }
						: null
				});
			}

			return (dtoList, usersWithMetaData.MetaData);
		}

        public async Task SendResetPasswordToken(string email, CancellationToken ct = default)
        {
            var userEntity = await userManager.FindByEmailAsync(email);
            if (userEntity is null) throw new UserNotFoundException();

            // Generate 6-digit OTP
            var otp = new Random().Next(100000, 999999).ToString();

            // Expire in 10 minutes
            var expiry = DateTime.Now.AddMinutes(10);

            // Store OTP + expiry in Value (e.g., "123456|2025-08-17T07:10:00Z")
            var tokenValue = $"{otp}|{expiry:o}";

            // Remove old OTP if any
            await userManager.RemoveAuthenticationTokenAsync(userEntity, "ResetPassword", "OTP");

            // Save in AspNetUserTokens
            await userManager.SetAuthenticationTokenAsync(userEntity, "ResetPassword", "OTP", tokenValue);

            // Send email
            var mail = new Mail(userEntity.Email, "Reset password OTP", $@"
<div style='font-family: Arial, sans-serif; background-color: #f4f4f4; padding: 20px; text-align: center;'>
    <div style='max-width: 600px; background: #ffffff; padding: 20px; border-radius: 8px; 
                box-shadow: 0 0 10px rgba(0, 0, 0, 0.1); text-align: center;'>
        <h2 style='color: #333;'>Reset Your Password</h2>
        <p style='font-size: 16px; color: #555;'>Use the code below to reset your password:</p>
        <p style='font-size: 28px; font-weight: bold; color: #ff6f61; margin: 20px 0;'>{otp}</p>
        <p style='font-size: 14px; color: #777;'>This code will expire in 10 minutes.</p>
    </div>
</div>");
            emailSender.SendEmail(mail);
        }

        public async Task ResetPassword(UserForResetPasswordDto dto, CancellationToken ct = default)
        {
            var user = await userManager.FindByEmailAsync(dto.Email);
            if (user is null) throw new UserNotFoundException();

            // Get stored token (OTP + expiry)
            var storedValue = await userManager.GetAuthenticationTokenAsync(user, "ResetPassword", "OTP");
            if (string.IsNullOrEmpty(storedValue))
                throw new RequestTokenBadRequest();

            // Parse OTP and expiry
            var parts = storedValue.Split('|');
            if (parts.Length != 2)
                throw new RequestTokenBadRequest();

            var otp = parts[0];
            if (!DateTime.TryParse(parts[1], null, System.Globalization.DateTimeStyles.RoundtripKind, out var expiry))
                throw new RequestTokenBadRequest();

            // Validate OTP + expiry
            if (otp != dto.OTP || expiry < DateTime.Now)
                throw new RequestTokenBadRequest();

            // Reset password (remove old and set new)
            var removeResult = await userManager.RemovePasswordAsync(user);
            if (!removeResult.Succeeded)
                throw new Exception("Failed to remove old password");

            var addResult = await userManager.AddPasswordAsync(user, dto.Password);
            if (!addResult.Succeeded)
                throw new Exception("Failed to set new password");

            // Clear OTP after success
            await userManager.RemoveAuthenticationTokenAsync(user, "ResetPassword", "OTP");

            // Invalidate refresh token
            user.RefreshToken = null;
            await userManager.UpdateAsync(user);
        }

        public async Task UpdatePassword(Guid userId, UserForUpdatePasswordDto userForUpdatePasswordDto, CancellationToken ct = default)
		{
			var userEntity = await userManager.Users
			.FirstOrDefaultAsync(u => u.Id == userId, ct);

			if (userEntity == null) throw new UserNotFoundException();

			var result = await userManager.ChangePasswordAsync(
				userEntity,
				userForUpdatePasswordDto.CurrentPassword,
				userForUpdatePasswordDto.NewPassword
			);

			if (!result.Succeeded)
			{
				var errors = string.Join("; ", result.Errors.Select(e => e.Description));
				throw new UserBadRequestException($"Failed to change password: {errors}");
			}
		}

		public async Task UpdateUser(Guid userId, UserForUpdateDto userForUpdateDto, CancellationToken ct = default)
		{
			var userProfileEntity = await repositoryManager.UserProfileRepository.GetUserProfileById(userId, true, ct);
			if (userProfileEntity is null)
			{
				throw new NotFoundException($"User Profile not found.");
			}

			mapper.Map(userForUpdateDto, userProfileEntity);
			await repositoryManager.SaveAsync(ct);
		}

		public async Task<(bool isFirstTime, TokenDto? dto)> IsFirstGoogleLoginAsync(string idToken, CancellationToken ct = default)
		{
			// Step 1: Verify the token
			var payload = await FirebaseAuth.DefaultInstance.VerifyIdTokenAsync(idToken, ct);
			var email = payload.Claims["email"]?.ToString();
			var firebaseUserId = payload.Uid;

			if (string.IsNullOrEmpty(email))
				throw new InvalidOperationException("Invalid Google token: missing email");

			// Step 2: Check if user exists
			var user = await userManager.FindByEmailAsync(email);
			if (user == null)
			{
				// First-time login
				return (true, null);
			}

			// Step 3: Check if user has been banned
			await CheckAndUpdateBanStatusAsync(user, ct);

			// Step 4: Save Firebase login info if not already present
			var loginInfo = new UserLoginInfo("Firebase", firebaseUserId, "Google");

			var existingLogins = await userManager.GetLoginsAsync(user);
			if (!existingLogins.Any(l => l.LoginProvider == "Firebase" && l.ProviderKey == firebaseUserId))
			{
				var addLoginResult = await userManager.AddLoginAsync(user, loginInfo);
				if (!addLoginResult.Succeeded)
					throw new InvalidOperationException("Could not link Firebase login");
			}

			// Step 5: Update last login and generate tokens
			user.LastLogin = DateTime.Now;
			await userManager.UpdateAsync(user);

			var tokenDto = await CreateToken(user, setRefreshExpiry: true, ct);
			await PingAsync(tokenDto.AccessToken, ct);
			return (false, tokenDto);
		}

		public async Task<TokenDto> LoginWithGoogleAsync(GoogleLoginDto dto, CancellationToken ct = default)
		{
			// Step 1: Verify the token with Firebase
			var payload = await FirebaseAuth.DefaultInstance.VerifyIdTokenAsync(dto.IdToken, ct);
			var email = payload.Claims["email"]?.ToString();
			var name = payload.Claims["name"]?.ToString();
			var picture = payload.Claims["picture"]?.ToString();

			var firebaseUserId = payload.Uid;

			if (string.IsNullOrEmpty(email))
				throw new InvalidOperationException("Invalid Google token: missing email");

			// Step 2: Try to find existing user
			var user = await userManager.FindByEmailAsync(email);

			if (user == null)
			{
				// Step 3: Register new user
				user = new Users
				{
					Id = Guid.NewGuid(),
					UserName = await GenerateUniqueUsernameAsync(),
					Email = email,
					EmailConfirmed = true,
					LockoutEnabled = true,
					IsActive = true,
					JoinedDate = DateTime.Now,
					LastLogin = DateTime.Now
				};

				var result = await userManager.CreateAsync(user);
				if (!result.Succeeded)
					throw new InvalidOperationException(string.Join("; ", result.Errors.Select(e => e.Description)));

				// Check if role exists in DB
				var roleExists = await roleManager.RoleExistsAsync(dto.Role.ToString());
				if (!roleExists)
				{
					throw new InvalidOperationException($"Role '{dto.Role.ToString()}' does not exist in the database.");
				}

				var roleResult = await userManager.AddToRoleAsync(user, dto.Role.ToString());
				if (!roleResult.Succeeded)
				{
					throw new InvalidOperationException(string.Join("; ", roleResult.Errors.Select(e => e.Description)));
				}

				if (dto.Birthday is null)
				{

					throw new InvalidOperationException("Birthday is required for new users. Please provide a valid date.");
				}
				else
				{
					// Create Profile + Wallet
					repositoryManager.UserProfileRepository.CreateUserProfile(new UserProfiles
					{
						UserId = user.Id,
						Avatar = picture ?? "https://media.istockphoto.com/vectors/default-profile-picture-avatar-photo-placeholder-vector-illustration-vector-id1223671392?k=6&m=1223671392&s=170667a&w=0&h=zP3l7WJinOFaGb2i1F4g8IS2ylw0FlIaa6x3tP9sebU=",
						Fullname = name,
						Birthday = (DateOnly)dto.Birthday
					});
				}

				repositoryManager.WalletRepository.CreateWallet(new Wallets
				{
					UserId = user.Id,
					Balance = 0
				});

				await repositoryManager.SaveAsync(ct);

				SendWelcomeEmailAsync(email, name);
			}

			await CheckAndUpdateBanStatusAsync(user, ct);

			// Step 4: Save Firebase login info if not already present
			var loginInfo = new UserLoginInfo("Firebase", firebaseUserId, "Google");

			var existingLogins = await userManager.GetLoginsAsync(user);
			if (!existingLogins.Any(l => l.LoginProvider == "Firebase" && l.ProviderKey == firebaseUserId))
			{
				var addLoginResult = await userManager.AddLoginAsync(user, loginInfo);
				if (!addLoginResult.Succeeded)
					throw new InvalidOperationException("Could not link Firebase login");
			}

			// Step 5: Update last login and generate tokens
			user.LastLogin = DateTime.Now;
			await userManager.UpdateAsync(user);

			var tokenDto = await CreateToken(user, setRefreshExpiry: true, ct);
			await PingAsync(tokenDto.AccessToken, ct);
			return tokenDto;
		}

		private async Task<string> GenerateUniqueUsernameAsync()
		{
			string finalUsername;

			do
			{
				var adjective = faker.Hacker.Adjective(); // e.g., "fuzzy"
				var noun = faker.Hacker.Noun();           // e.g., "system"
				var number = faker.Random.Number(10000, 99999); // 5-digit suffix

				finalUsername = $"{adjective}{noun}{number}";
			}
			while (await userManager.FindByNameAsync(finalUsername) != null);

			return finalUsername;
		}

		private void SendWelcomeEmailAsync(string email, string fullname)
		{
			var emailBody = $@"
		<p>Hi {fullname},</p>
		<p>Welcome to Indie Game Zone!</p>
		<p>Thanks for signing up with your Google account.</p>
		<p>Explore the platform, connect with other gamers, and enjoy your stay!</p>
		<p>If you have any questions, feel free to contact our support team.</p>";

			var mail = new Mail(email!, "Welcome to Indie Game Zone!", emailBody);
			emailSender.SendEmail(mail);
		}

		public async Task UpdateBirthday(Guid userId, DateOnly birthday, CancellationToken ct)
		{
			var userProfileEntity = await repositoryManager.UserProfileRepository.GetUserProfileById(userId, true, ct);
			if (userProfileEntity is null)
			{
				throw new NotFoundException($"User Profile not found.");
			}

			userProfileEntity.Birthday = birthday;
			await repositoryManager.SaveAsync(ct);
		}

		public async Task UpdateUsername(Guid userId, string newUsername, CancellationToken ct)
		{
			var user = await userManager.FindByIdAsync(userId.ToString());
			if (user == null) throw new UserNotFoundException();
			if (user.LastUsernameChangedDate.HasValue &&
			   user.LastUsernameChangedDate.Value.AddDays(30) > DateTime.Now)
			{
				throw new UserBadRequestException("You can only change your username once every 30 days.");
			}
			if (newUsername.Equals(user.UserName)) throw new UserBadRequestException("New username cannot be the same as the current username.");
			if (await userManager.FindByNameAsync(newUsername) != null) throw new UserBadRequestException("Username already exists");
			user.UserName = newUsername;
			user.LastUsernameChangedDate = DateTime.Now;
			var result = await userManager.UpdateAsync(user);
			if (!result.Succeeded)
			{
				throw new InvalidOperationException(string.Join("; ", result.Errors.Select(e => e.Description)));
			}
		}

		private async Task CheckAndUpdateBanStatusAsync(Users user, CancellationToken ct)
		{
			bool hasActiveBan = await repositoryManager.BanHistoryRepository.HasActiveBanAsync(user.Id, DateTime.Now, ct);

			user.IsActive = !hasActiveBan;
			await userManager.UpdateAsync(user);

			if (hasActiveBan)
				throw new UserBadRequestException("Your account is currently banned.");

		}

		public async Task PingAsync(string jwt, CancellationToken ct = default)
		{
			var handler = new JwtSecurityTokenHandler();
			var token = handler.ReadJwtToken(jwt);
			var userId = token.Claims.First(claim => claim.Type == ClaimTypes.NameIdentifier).Value;

			if (!Guid.TryParse(userId, out var guidUserId))
				throw new NotAuthenticatedException("Invalid user ID in token.");

			var userProfile = await repositoryManager.UserProfileRepository.GetUserProfileById(guidUserId, trackChange: true, ct);

			if (userProfile == null)
				throw new NotFoundException("User profile not found.");

			userProfile.LastPingAt = DateTime.Now;
			await repositoryManager.SaveAsync(ct);
		}

		public async Task UpdateBankInfoAsync(Guid userId, UserForUpdateBankInfoDto dto, CancellationToken ct)
		{
			var userProfile = await repositoryManager.UserProfileRepository.GetUserProfileById(userId, true, ct);
			if (userProfile == null)
				throw new NotFoundException($"UserProfile for UserId {userId} not found");

			userProfile.BankName = dto.BankName;
			userProfile.BankAccountNumber = dto.BankAccountNumber;
			userProfile.BankAccountName = dto.BankAccountName;
			userProfile.BankCode = dto.BankCode;
			userProfile.BankBin = dto.BankBin;
			userProfile.BankShortName = dto.BankShortName;

			await repositoryManager.SaveAsync(ct);
		}

        public async Task<IEnumerable<NewPlayersByMonthForReturnDto>> GetNewPlayersByMonthAsync(int year, CancellationToken ct = default)
        {
            // Get all users registered in the given year
            var users = await userManager.Users
                .Where(u => u.JoinedDate.Year == year)
                .ToListAsync(ct);

            // Group by month
            var grouped = users
                .GroupBy(u => u.JoinedDate.Month)
                .Select(g => new NewPlayersByMonthForReturnDto
                {
                    Month = g.Key,
                    Count = g.Count()
                })
                .ToList();

            // Ensure all 12 months are present
            var fullReport = Enumerable.Range(1, 12)
                .Select(month => grouped.FirstOrDefault(x => x.Month == month)
                    ?? new NewPlayersByMonthForReturnDto
                    {
                        Month = month,
                        Count = 0
                    })
                .OrderBy(r => r.Month)
                .ToList();

            return fullReport;
        }

    }
}
