using IndieGameZone.Domain.Constants;
using IndieGameZone.Domain.RequestFeatures;
using IndieGameZone.Domain.RequestsAndResponses.Requests.Games;
using IndieGameZone.Domain.RequestsAndResponses.Responses.Games;

namespace IndieGameZone.Application.GameServices
{
	public interface IGameService
	{
		Task<(IEnumerable<GameForListReturnDto> games, MetaData metaData)> GetGames(GameParameters gameParameters, CancellationToken ct = default);
		Task<(IEnumerable<GameForListReturnDto> games, MetaData metaData)> GetActiveGames(ActiveGameParameters activeGameParameters, CancellationToken ct = default);
		Task<(IEnumerable<GameForListReturnDto> games, MetaData metaData)> GetGamesByDeveloperId(Guid developerId, GameParameters gameParameters, CancellationToken ct = default);
		Task<GameForSingleReturnDto> GetGameById(Guid gameId, CancellationToken ct = default);
		Task DeleteGame(Guid developerId, Guid gameId, CancellationToken ct = default);
		Task<Guid> CreateGame(Guid developerId, GameForCreationDto game, CancellationToken ct = default);
		Task UpdateGame(Guid developerId, Guid gameId, GameForUpdateDto game, CancellationToken ct = default);
		Task UpdateActiveStatus(Guid gameId, CensorStatus censorStatus, CancellationToken ct = default);
	}
}
