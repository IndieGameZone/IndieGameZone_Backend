using IndieGameZone.Domain.RequestsAndResponses.Requests.GameTypes;
using IndieGameZone.Domain.RequestsAndResponses.Responses.GameTypes;

namespace IndieGameZone.Application.GameTypeServices
{
	public interface IGameTypeService
	{
		Task CreateGameType(GameTypeForCreationDto gameTypeForCreationDto, CancellationToken ct = default);
		Task UpdateGameType(Guid id, GameTypeForUpdateDto gameTypeForUpdateDto, CancellationToken ct = default);
		Task DeleteGameType(Guid id, CancellationToken ct = default);
		Task<GameTypeForReturnDto> GetGameTypeById(Guid id, CancellationToken ct = default);
		Task<IEnumerable<GameTypeForReturnDto>> GetGameTypes(CancellationToken ct = default);
	}
}
