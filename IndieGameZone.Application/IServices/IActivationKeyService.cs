using IndieGameZone.Domain.RequestsAndResponses.Requests.ActivationKeys;
using IndieGameZone.Domain.RequestsAndResponses.Responses.ActivationKeys;

namespace IndieGameZone.Application.IServices
{
	public interface IActivationKeyService
	{
		Task<bool> ValidateActivationKey(string activationKey, CancellationToken ct = default);
		Task<ActivationKeyForReturnDto> GetKeyByGamePlatformId(Guid userId, Guid gamePlatformId, CancellationToken ct = default);
		Task CreateActivationKey(Guid gamePlatformId, ActivationKeyForCreationDto activationKeyForCreationDto, CancellationToken ct = default);
	}
}
