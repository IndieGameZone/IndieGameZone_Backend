using FirebaseAdmin.Auth;
using IndieGameZone.Application.BlobService;
using IndieGameZone.Application.EmailServices;
using IndieGameZone.Domain.Constants;
using IndieGameZone.Domain.Entities;
using IndieGameZone.Domain.Exceptions;
using IndieGameZone.Domain.IRepositories;
using IndieGameZone.Domain.RequestFeatures;
using IndieGameZone.Domain.RequestsAndResponses.Requests.Users;
using IndieGameZone.Domain.RequestsAndResponses.Responses.Users;
using IndieGameZone.Domain.Utils;
using MapsterMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.WebUtilities;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using Newtonsoft.Json.Linq;
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
        private readonly IBlobService blobService;

        public UserService(IRepositoryManager repositoryManager, IMapper mapper, UserManager<Users> userManager, RoleManager<Roles> roleManager, IEmailSender emailSender, IHttpContextAccessor httpContextAccessor, IConfiguration configuration, IBlobService blobService)
        {
            this.repositoryManager = repositoryManager;
            this.mapper = mapper;
            this.userManager = userManager;
            this.roleManager = roleManager;
            this.emailSender = emailSender;
            this.httpContextAccessor = httpContextAccessor;
            this.configuration = configuration;
            this.blobService = blobService;
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
				.FirstOrDefaultAsync(u => u.Id == guidUserId, ct);

			if (user == null)
				throw new UserNotFoundException();

			var dto = mapper.Map<UserForReturnDto>(user);

			var roleName = (await userManager.GetRolesAsync(user)).FirstOrDefault();

			return dto with
			{
				Role = !string.IsNullOrWhiteSpace(roleName)
					? new RoleForReturnDto { Name = roleName }
					: null,

				Fullname = user.UserProfile?.Fullname,
				Avatar = user.UserProfile?.Avatar,
				Bio = user.UserProfile?.Bio,
				Birthday = user.UserProfile?.Birthday,
				FacebookLink = user.UserProfile?.FacebookLink,
				BankName = user.UserProfile?.BankName,
				BankAccount = user.UserProfile?.BankAccount
			};
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

			if (!user.IsActive)
				throw new NotAuthenticatedException("User is deactivated");

			if (!user.EmailConfirmed)
				throw new NotAuthenticatedException("Your email has not been confirmed yet");

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

			bool isPasswordValid = await userManager.CheckPasswordAsync(user, userForAuth.Password!);
			if (!isPasswordValid)
			{
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

			return await CreateToken(user, setRefreshExpiry: false, ct);
		}

		public async Task<UserForReturnDto> GetUserByToken(string jwt, CancellationToken ct = default)
		{
			var handler = new JwtSecurityTokenHandler();
			var token = handler.ReadJwtToken(jwt);
			var userId = token.Claims.First(claim => claim.Type == ClaimTypes.NameIdentifier).Value;
			var dto = await GetUserById(userId, ct);
			if (dto == null) throw new UserNotFoundException();
			return dto;
		}

		public async Task<(IEnumerable<UserForReturnDto> users, MetaData metaData)> GetUsers(UserParameters userParameters, CancellationToken ct = default)
		{
			var usersWithMetaData = await repositoryManager.UserRepository.GetUsers(userParameters, false, ct);
			var userList = usersWithMetaData;

			var dtoList = new List<UserForReturnDto>();

			foreach (var user in userList)
			{
				var dto = mapper.Map<UserForReturnDto>(user);

				var roleName = (await userManager.GetRolesAsync(user)).FirstOrDefault();

				dtoList.Add(dto with
				{
					Role = !string.IsNullOrWhiteSpace(roleName)
						? new RoleForReturnDto { Name = roleName }
						: null,

					Fullname = user.UserProfile?.Fullname,
					Avatar = user.UserProfile?.Avatar,
					Bio = user.UserProfile?.Bio,
					Birthday = user.UserProfile?.Birthday,
					FacebookLink = user.UserProfile?.FacebookLink,
					BankName = user.UserProfile?.BankName,
					BankAccount = user.UserProfile?.BankAccount
				});
			}

			return (dtoList, usersWithMetaData.MetaData);
		}

        public async Task ChangeActiveStatus(Guid userId, CancellationToken ct = default)
        {
            var userEntity = await userManager.Users
                .FirstOrDefaultAsync(u => u.Id == userId, ct);

            if (userEntity == null) throw new UserNotFoundException();

            userEntity.IsActive = !userEntity.IsActive;
            await userManager.UpdateAsync(userEntity);
        }

        public async Task SendResetPasswordToken(string email, CancellationToken ct = default)
        {
            var userEntity = await userManager.FindByEmailAsync(email);
            if (userEntity is null) throw new UserNotFoundException();

            var token = await userManager.GeneratePasswordResetTokenAsync(userEntity);

            var mail = new Mail(userEntity.Email, "Reset password OTP", $@"
    <div style='font-family: Arial, sans-serif; background-color: #f4f4f4; padding: 20px; text-align: center;'>
        <div style='max-width: 600px; background: #ffffff; padding: 20px; border-radius: 8px; 
                    box-shadow: 0 0 10px rgba(0, 0, 0, 0.1); text-align: center;'>
            <h2 style='color: #333;'>Reset Your Password</h2>
            <p style='font-size: 16px; color: #555;'>We received a request to reset your password. Use the code below to complete the process:</p>
            <p style='font-size: 24px; font-weight: bold; color: #ff6f61; margin: 20px 0;'>{token}</p>
            <p style='font-size: 14px; color: #777;'>If you didn’t request a password reset, you can ignore this email.</p>
            <p style='font-size: 14px; color: #777;'>For assistance, contact our support team at 
                <a href='mailto:indiegamezonecompany@gmail.com' style='color: #ff6f61;'>indiegamezonecompany@gmail.com</a>
            </p>
            <p style='font-size: 12px; color: #777;'>&copy; 2025 IndieGameZone. All rights reserved.</p>
        </div>
    </div>");
            emailSender.SendEmail(mail);
        }

        public async Task ResetPassword(UserForResetPasswordDto dto, CancellationToken ct = default)
        {
            var user = await userManager.FindByEmailAsync(dto.Email);
            if (user is null) throw new UserNotFoundException();

            var result = await userManager.ResetPasswordAsync(user, dto.OTP, dto.Password);
            if (!result.Succeeded)
            {
                throw new RequestTokenBadRequest();
            }
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
            if (userForUpdateDto.Avatar is not null && userForUpdateDto.Avatar.Length > 0)
            {
                await blobService.DeleteBlob(userProfileEntity.Avatar.Split('/').Last(), StorageContainer.STORAGE_CONTAINER);
                string filename = $"{Guid.NewGuid()}{Path.GetExtension(userForUpdateDto.Avatar.FileName)}";
                userProfileEntity.Avatar = await blobService.UploadBlob(filename, StorageContainer.STORAGE_CONTAINER, userForUpdateDto.Avatar);
            }
            await repositoryManager.SaveAsync(ct);
        }

        public async Task<TokenDto> LoginWithGoogleAsync(string idTokenFromFirebase, CancellationToken ct = default)
        {
            // Step 1: Verify the token with Firebase
            var payload = await FirebaseAuth.DefaultInstance.VerifyIdTokenAsync(idTokenFromFirebase);
            var email = payload.Claims["email"]?.ToString();
            var name = payload.Claims["name"]?.ToString();
            var picture = payload.Claims["picture"]?.ToString();
            var phoneNumber = payload.Claims["phone_number"]?.ToString();

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
					UserName = await GenerateUniqueUsernameAsync(name),
					Email = email,
					EmailConfirmed = true,
					PhoneNumber = phoneNumber,
					PhoneNumberConfirmed = true,
					LockoutEnabled = true,
                    IsActive = true,
                    JoinedDate = DateTime.Now,
					LastLogin = DateTime.Now
				};

				var result = await userManager.CreateAsync(user);
				if (!result.Succeeded)
					throw new InvalidOperationException(string.Join("; ", result.Errors.Select(e => e.Description)));

                // Check if role exists in DB
                var roleExists = await roleManager.RoleExistsAsync(RoleEnum.Player.ToString());
                if (!roleExists)
                {
                    throw new InvalidOperationException($"Role '{RoleEnum.Player.ToString()}' does not exist in the database.");
                }

                var roleResult = await userManager.AddToRoleAsync(user, RoleEnum.Player.ToString());
                if (!roleResult.Succeeded)
                {
                    throw new InvalidOperationException(string.Join("; ", roleResult.Errors.Select(e => e.Description)));
                }

                // Create Profile + Wallet
                repositoryManager.UserProfileRepository.CreateUserProfile(new UserProfiles
				{
					UserId = user.Id,
					Avatar = picture ?? "https://media.istockphoto.com/vectors/default-profile-picture-avatar-photo-placeholder-vector-illustration-vector-id1223671392?k=6&m=1223671392&s=170667a&w=0&h=zP3l7WJinOFaGb2i1F4g8IS2ylw0FlIaa6x3tP9sebU=",
					Fullname = name
				});

				repositoryManager.WalletRepository.CreateWallet(new Wallets
				{
					UserId = user.Id,
					Balance = 0
				});

				await repositoryManager.SaveAsync(ct);
			}

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

            return await CreateToken(user, setRefreshExpiry: true, ct);
        }

        private async Task<string> GenerateUniqueUsernameAsync(string email)
        {
            var baseUsername = email.Split('@')[0];
            string finalUsername;
            do
            {
                var randomSuffix = GenerateRandomNumber(5);
                finalUsername = $"{baseUsername}{randomSuffix}";
            }
            while (await userManager.FindByNameAsync(finalUsername) != null);

            return finalUsername;
        }

        private string GenerateRandomNumber(int length)
        {
            var random = new Random();
            return string.Join("", Enumerable.Range(0, length).Select(_ => random.Next(0, 10)));
        }
    }
}
