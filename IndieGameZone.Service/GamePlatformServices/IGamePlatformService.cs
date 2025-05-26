using IndieGameZone.Domain.RequestsAndResponses.Requests.GamePlatforms;
using IndieGameZone.Domain.RequestsAndResponses.Responses.GamePlatforms;

namespace IndieGameZone.Application.GamePlatformServices
{
	public interface IGamePlatformService
	{
		Task CreateGamePlatforms(Guid gameId, IEnumerable<GamePlatformForCreationDto> gamePlatformForCreationDtos, CancellationToken ct = default);
		Task UpdateGamePlatformsByGameId(Guid gameId, IEnumerable<GamePlatformForUpdateDto> gamePlatformForUpdateDtos, CancellationToken ct = default);
		Task<IEnumerable<GamePlatformForReturnDto>> GetGamePlatformsByGameId(Guid gameId, CancellationToken ct = default);
	}
}
