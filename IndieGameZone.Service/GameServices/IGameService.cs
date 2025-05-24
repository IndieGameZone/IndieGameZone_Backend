using IndieGameZone.Domain.RequestFeatures;
using IndieGameZone.Domain.RequestsAndResponses.Responses.Games;

namespace IndieGameZone.Application.GameServices
{
	public interface IGameService
	{
		Task<(IEnumerable<GameForListReturnDto> games, MetaData metaData)> GetGames(GameParameters gameParameters, CancellationToken ct = default);
		Task<GameForSingleReturnDto> GetGameById(Guid gameId, CancellationToken ct = default);
		Task DeleteGame(Guid developerId, Guid gameId, CancellationToken ct = default);
	}
}
