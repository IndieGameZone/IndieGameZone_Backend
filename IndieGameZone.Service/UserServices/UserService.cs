using IndieGameZone.Domain.Constants;
using IndieGameZone.Domain.Entities;
using IndieGameZone.Domain.Exceptions;
using IndieGameZone.Domain.IRepositories;
using IndieGameZone.Domain.RequestsAndResponses.Requests.Users;
using MapsterMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.WebUtilities;
using Quartz;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndieGameZone.Application.UserServices
{
    internal sealed class UserService : IUserService
    {
        private readonly IRepositoryManager repositoryManager;
        private readonly IMapper mapper;
        private readonly UserManager<Users> userManager;
        private readonly RoleManager<Roles> roleManager;

        public UserService(IRepositoryManager repositoryManager, IMapper mapper, UserManager<Users> userManager, RoleManager<Roles> roleManager)
        {
            this.repositoryManager = repositoryManager;
            this.mapper = mapper;
            this.userManager = userManager;
            this.roleManager = roleManager;
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
        }
    }
}
