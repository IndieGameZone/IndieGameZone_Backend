using Azure.Core;
using IndieGameZone.Domain.Entities;
using IndieGameZone.Domain.RequestFeatures;
using IndieGameZone.Domain.RequestsAndResponses.Requests.Users;
using IndieGameZone.Domain.RequestsAndResponses.Responses.Users;
using IndieGameZone.Domain.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndieGameZone.Application.UserServices
{
    public interface IUserService
    {
        Task CreateUser(UserForCreationDto userForCreationDto, bool adminFlag, CancellationToken ct = default);
        Task ResendConfirmationEmail(string email, CancellationToken ct = default);
        Task ConfirmEmail(string token, string userId, CancellationToken ct = default);
        Task<Users> ValidateUser(UserForAuthenticationDto userForAuth, CancellationToken ct = default);
        Task<TokenDto> CreateToken(Users user, bool setRefreshExpiry, CancellationToken ct = default);
        Task<TokenDto> RefreshToken(string accessToken, string refreshToken, CancellationToken ct = default);
        Task<UserForReturnDto> GetUserByToken(string jwt, CancellationToken ct = default);
        Task<UserForReturnDto> GetUserById(string userId, CancellationToken ct = default);
        Task<(IEnumerable<UserForReturnDto> users, MetaData metaData)> GetUsers(UserParameters userParameters, CancellationToken ct = default);
        Task ChangeActiveStatus(Guid userId, CancellationToken ct = default);
        Task SendResetPasswordToken(string email, CancellationToken ct = default);
        Task ResetPassword(UserForResetPasswordDto userForResetPasswordDto, CancellationToken ct = default);
        Task UpdatePassword(Guid userId, UserForUpdatePasswordDto userForUpdatePasswordDto, CancellationToken ct = default);
        Task UpdateUser(Guid userId, UserForUpdateDto userForUpdateDto, CancellationToken ct = default);
        Task<TokenDto> LoginWithGoogleAsync(string idTokenFromFirebase, CancellationToken ct = default);
    }
}
