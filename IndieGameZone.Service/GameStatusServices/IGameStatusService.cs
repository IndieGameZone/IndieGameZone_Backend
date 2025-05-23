using IndieGameZone.Domain.RequestsAndResponses.Requests.GameStatuses;
using IndieGameZone.Domain.RequestsAndResponses.Responses.GameStatuses;

namespace IndieGameZone.Application.GameStatusServices
{
	public interface IGameStatusService
	{
		Task CreateGameStatus(GameStatusForCreationDto gameStatusForCreationDto, CancellationToken ct = default);
		Task UpdateGameStatus(Guid id, GameStatusForUpdateDto gameStatusForUpdateDto, CancellationToken ct = default);
		Task DeleteGameStatus(Guid id, CancellationToken ct = default);
		Task<GameStatusForReturnDto> GetGameStatusById(Guid id, CancellationToken ct = default);
		Task<IEnumerable<GameStatusForReturnDto>> GetGameStatuses(CancellationToken ct = default);
	}
}
