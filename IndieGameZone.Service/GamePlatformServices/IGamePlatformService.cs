using IndieGameZone.Domain.RequestsAndResponses.Requests.GamePlatforms;

namespace IndieGameZone.Application.GamePlatformServices
{
	public interface IGamePlatformService
	{
		Task CreateGamePlatform(Guid gameId, ICollection<GamePlatformForCreationDto> gamePlatformForCreationDto, CancellationToken ct = default);
		Task UpdateGamePlatform(Guid gameId, ICollection<GamePlatformForUpdateDto> gamePlatformForUpdateDto, CancellationToken ct = default);
	}
}
