using IndieGameZone.Domain.RequestFeatures;
using IndieGameZone.Domain.RequestsAndResponses.Requests.Games;
using IndieGameZone.Domain.RequestsAndResponses.Responses.Games;

namespace IndieGameZone.Application.IServices
{
	public interface IGameService
	{
		Task<(IEnumerable<GameForListReturnDto> games, MetaData metaData)> GetGames(GameParameters gameParameters, CancellationToken ct = default);
		Task<(IEnumerable<GameForListReturnDto> games, MetaData metaData)> GetActiveGames(ActiveGameParameters activeGameParameters, CancellationToken ct = default);
		Task<(IEnumerable<GameForListReturnDto> games, MetaData metaData)> GetGamesByDeveloperId(Guid developerId, GameParameters gameParameters, CancellationToken ct = default);
		Task<(IEnumerable<GameForListReturnDto> games, MetaData metaData)> GetActiveGamesByDeveloperId(Guid developerId, ActiveGameParameters activeGameParameters, CancellationToken ct = default);
		Task<GameForSingleReturnDto> GetGameById(Guid playerId, Guid gameId, CancellationToken ct = default);
		Task DeleteGame(Guid developerId, Guid gameId, CancellationToken ct = default);
		Task<Guid> CreateGame(Guid developerId, GameForCreationDto game, CancellationToken ct = default);
		Task UpdateGame(Guid developerId, Guid gameId, GameForUpdateDto game, CancellationToken ct = default);
		Task UpdateActiveStatus(Guid moderatorId, Guid gameId, GameActivationDto gameActivationDto, CancellationToken ct = default);
		Task<string> IncreaseNumberOfDownload(Guid userId, Guid gamePlatformId, CancellationToken ct = default);
		Task<PlatformFileDto> GetGamePlatformFile(Guid gameId, CancellationToken ct = default);
		Task<PlatformFileDto> GetActiveGamePlatformFile(Guid gameId, CancellationToken ct = default);
		Task<IEnumerable<GameForListReturnDto>> GetRecommendedGamesForUser(Guid userId, CancellationToken ct = default);
		Task<(int total, int approve, int reject, int manual, int ai)> GetNumberOfGameBasedOnCensorStatus(CancellationToken ct = default);
		Task<bool> CheckGameOwnership(Guid userId, Guid gameId, CancellationToken ct = default);
        Task<(IEnumerable<GameForListReturnDto> games, MetaData metaData)> GetTodayHomepageBannerGamesAsync(CancellationToken ct = default);
        Task<(IEnumerable<GameForListReturnDto> games, MetaData metaData)> GetTodayCategoryBannerGamesAsync(GameParameters gameParameters, CancellationToken ct = default);


    }
}
