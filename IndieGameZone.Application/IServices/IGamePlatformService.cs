using IndieGameZone.Domain.RequestsAndResponses.Requests.GamePlatforms;

namespace IndieGameZone.Application.IServices
{
	public interface IGamePlatformService
	{
		Task CreateGamePlatform(Guid gameId, ICollection<GamePlatformForCreationDto> gamePlatformForCreationDto, CancellationToken ct = default);
		Task UpdateGamePlatform(Guid gameId, ICollection<GamePlatformForUpdateDto> gamePlatformForUpdateDto, CancellationToken ct = default);
		Task UpdateGamePlatformActivationStatus(Guid gamePlatformId, bool isActive, CancellationToken ct = default);
		Task UpdateGamePlatformById(Guid gamePlatformId, GamePlatformForUpdateDto gamePlatformForUpdateDto, CancellationToken ct = default);
		Task DeleteGamePlatform(Guid gamePlatformId, CancellationToken ct = default);
		Task<string> GetFilePassword(Guid userId, Guid gamePlatformId, CancellationToken ct = default);
	}
}
