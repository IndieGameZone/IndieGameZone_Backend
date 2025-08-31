using IndieGameZone.Domain.Entities;
using IndieGameZone.Domain.RequestFeatures;
using IndieGameZone.Domain.RequestsAndResponses.Requests.Users;
using IndieGameZone.Domain.RequestsAndResponses.Responses.DashBoard;
using IndieGameZone.Domain.RequestsAndResponses.Responses.Users;
using IndieGameZone.Domain.Utils;

namespace IndieGameZone.Application.IServices
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
		Task SendResetPasswordToken(string email, CancellationToken ct = default);
		Task ResetPassword(UserForResetPasswordDto userForResetPasswordDto, CancellationToken ct = default);
		Task UpdatePassword(Guid userId, UserForUpdatePasswordDto userForUpdatePasswordDto, CancellationToken ct = default);
		Task UpdateUser(Guid userId, UserForUpdateDto userForUpdateDto, CancellationToken ct = default);
		Task<(bool isFirstTime, TokenDto? dto)> IsFirstGoogleLoginAsync(string idToken, CancellationToken ct = default);
		Task<TokenDto> LoginWithGoogleAsync(GoogleLoginDto dto, CancellationToken ct = default);
		Task UpdateBirthday(Guid userId, DateOnly birthday, CancellationToken ct);
		Task UpdateUsername(Guid userId, string newUsername, CancellationToken ct = default);
		Task PingAsync(string jwt, CancellationToken ct = default);
		Task UpdateBankInfoAsync(Guid userId, UserForUpdateBankInfoDto dto, CancellationToken ct);
		Task<IEnumerable<NewPlayersByMonthForReturnDto>> GetNewPlayersByMonthAsync(int year, CancellationToken ct = default);
		Task<(int numberOfPost, int numberOfFollower, int numberOfFollowee)> GetUserSocialStats(Guid userId, CancellationToken ct = default);

	}
}
