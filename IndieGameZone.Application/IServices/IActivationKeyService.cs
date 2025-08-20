using IndieGameZone.Domain.RequestsAndResponses.Responses.ActivationKeys;

namespace IndieGameZone.Application.IServices
{
	public interface IActivationKeyService
	{
		Task ValidateActivationKey(Guid gameId, string activationKey, CancellationToken ct = default);
		Task<IEnumerable<ActivationKeyForReturnDto>> GetKeyByGameId(Guid userId, Guid gameId, CancellationToken ct = default);
		Task CreateActivationKey(Guid gameId, CancellationToken ct = default);
		Task ResetActivationKey(Guid userId, Guid gameId, CancellationToken ct = default);
	}
}
