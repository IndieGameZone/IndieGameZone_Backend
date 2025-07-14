using IndieGameZone.Domain.RequestFeatures;
using IndieGameZone.Domain.RequestsAndResponses.Responses.GameCensorLogs;

namespace IndieGameZone.Application.IServices
{
	public interface IGameCensorLogService
	{
		Task<(IEnumerable<GameCensorLogForReturnDto> gameCensorLogs, MetaData metaData)> GetGameCensorLogsByGameId(Guid gameId, GameCensorLogParameters gameCensorLogParameters, CancellationToken ct = default);
	}
}
