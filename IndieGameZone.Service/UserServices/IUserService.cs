using IndieGameZone.Domain.Entities;
using IndieGameZone.Domain.RequestsAndResponses.Requests.Users;
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
        Task CreateUser(UserForCreationDto userForCreationDto, CancellationToken ct = default);
        Task ConfirmEmail(string token, string email, CancellationToken ct = default);
        Task<Users> ValidateUser(UserForAuthenticationDto userForAuth, CancellationToken ct = default);
        Task<TokenDto> CreateToken(Users user, bool setRefreshExpiry, CancellationToken ct = default);
        Task<TokenDto> RefreshToken(TokenDto tokenDto, CancellationToken ct = default);
    }
}
