using IndieGameZone.Domain.RequestsAndResponses.Requests.Platforms;
using IndieGameZone.Domain.RequestsAndResponses.Responses.Platforms;

namespace IndieGameZone.Application.IServices
{
	public interface IPlatformService
	{
		Task CreatePlatform(PlatformForCreationDto platformForCreationDto, CancellationToken ct = default);
		Task UpdatePlatform(Guid id, PlatformForUpdateDto platformForUpdateDto, CancellationToken ct = default);
		Task DeletePlatform(Guid id, CancellationToken ct = default);
		Task<PlatformForReturnDto> GetPlatformById(Guid id, CancellationToken ct = default);
		Task<IEnumerable<PlatformForReturnDto>> GetPlatforms(CancellationToken ct = default);
	}
}
