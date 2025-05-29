using IndieGameZone.Domain.RequestsAndResponses.Responses.GameImages;

namespace IndieGameZone.Application.GameInfoServices
{
	public interface IGameImageService
	{
		Task<IEnumerable<GameImageForReturnDto>> GetGameInfosByGameId(Guid gameId, CancellationToken ct = default);
	}
}
