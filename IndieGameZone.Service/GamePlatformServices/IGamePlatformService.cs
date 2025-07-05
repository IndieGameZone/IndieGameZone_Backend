using IndieGameZone.Domain.RequestsAndResponses.Requests.GamePlatforms;

namespace IndieGameZone.Application.GamePlatformServices
{
	public interface IGamePlatformService
	{
		Task CreateGamePlatform(Guid gameId, ICollection<GamePlatformForCreationDto> gamePlatformForCreationDto, CancellationToken ct = default);
		Task UpdateGamePlatform(Guid gameId, ICollection<GamePlatformForUpdateDto> gamePlatformForUpdateDto, CancellationToken ct = default);
		Task UpdateGamePlatformActivationStatus(Guid developerId, Guid gamePlatformId, bool isActive, CancellationToken ct = default);
	}
}
