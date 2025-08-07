using IndieGameZone.Domain.RequestFeatures;
using IndieGameZone.Domain.RequestsAndResponses.Responses.GamePriceLogs;

namespace IndieGameZone.Application.IServices
{
	public interface IGamePriceLogService
	{
		Task<(IEnumerable<GamePriceLogForReturnDto> gamePriceLogs, MetaData metaData)> GetGamePriceLogsByGameId(Guid gameId, GamePriceLogParameters gamePriceLogParameters, CancellationToken ct = default);
	}
}
