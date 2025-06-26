using IndieGameZone.Domain.RequestFeatures;
using IndieGameZone.Domain.RequestsAndResponses.Responses.GameCensorLogs;

namespace IndieGameZone.Application.GameCensorLogServices
{
	public interface IGameCensorLogService
	{
		Task<(IEnumerable<GameCensorLogForReturnDto> gameCensorLogs, MetaData metaData)> GetGameCensorLogsByGameId(Guid gameId, GameCensorLogParameters gameCensorLogParameters, CancellationToken ct = default);
	}
}
