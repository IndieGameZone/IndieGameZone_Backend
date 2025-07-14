using IndieGameZone.Domain.RequestsAndResponses.Requests.AgeRestrictions;
using IndieGameZone.Domain.RequestsAndResponses.Responses.AgeRestrictions;

namespace IndieGameZone.Application.IServices
{
	public interface IAgeRestrictionService
	{
		Task CreateAgeRestriction(AgeRestrictionForCreationDto ageRestrictionForCreationDto, CancellationToken ct = default);
		Task UpdateAgeRestriction(Guid id, AgeRestrictionForUpdateDto ageRestrictionForUpdateDto, CancellationToken ct = default);
		Task DeleteAgeRestriction(Guid id, CancellationToken ct = default);
		Task<AgeRestrictionForReturnDto> GetAgeRestrictionById(Guid id, CancellationToken ct = default);
		Task<IEnumerable<AgeRestrictionForReturnDto>> GetAgeRestrictions(CancellationToken ct = default);
	}
}
