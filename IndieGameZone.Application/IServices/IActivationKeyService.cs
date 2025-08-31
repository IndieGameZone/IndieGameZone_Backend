using IndieGameZone.Domain.RequestsAndResponses.Responses.ActivationKeys;

namespace IndieGameZone.Application.IServices
{
	public interface IActivationKeyService
	{
		Task ValidateActivationKey(Guid gameId, string activationKey, CancellationToken ct = default);
		Task<bool> ValidateUsedActivationKey(Guid gameId, string activationKey, CancellationToken ct = default);
		Task<IEnumerable<ActivationKeyForReturnDto>> GetKeyByGameId(Guid userId, Guid gameId, CancellationToken ct = default);
		Task<ActivationKeyForReturnDto> CreateActivationKey(Guid gameId, CancellationToken ct = default);
		Task ResetActivationKey(Guid userId, Guid gameId, CancellationToken ct = default);
		Task<ActivationKeyForReturnDto> ResetActivationKeyForModerator(Guid gameId, string activationKey, CancellationToken ct = default);
	}
}
