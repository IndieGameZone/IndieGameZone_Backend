using IndieGameZone.Domain.RequestsAndResponses.Requests.GameInfos;
using IndieGameZone.Domain.RequestsAndResponses.Responses.GameInfos;

namespace IndieGameZone.Application.GameInfoServices
{
	public interface IGameInfoService
	{
		Task CreateGameInfo(Guid gameId, IEnumerable<GameInfoForCreationDto> gameInfoForCreationDtos, CancellationToken ct = default);
		Task UpdateGameInfosByGameId(Guid gameId, IEnumerable<GameInfoForUpdateDto> gameInfoForUpdateDtos, CancellationToken ct = default);
		Task<IEnumerable<GameInfoForReturnDto>> GetGameInfosByGameId(Guid gameId, CancellationToken ct = default);
	}
}
