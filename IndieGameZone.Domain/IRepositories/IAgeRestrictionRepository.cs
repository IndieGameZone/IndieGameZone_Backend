using IndieGameZone.Domain.Entities;

namespace IndieGameZone.Domain.IRepositories
{
	public interface IAgeRestrictionRepository
	{
		Task<IEnumerable<AgeRestrictions>> GetAgeRestrictions(bool trackChange, CancellationToken ct = default);
		Task<AgeRestrictions?> GetAgeRestrictionById(Guid id, bool trackChange, CancellationToken ct = default);
		void CreateAgeRestriction(AgeRestrictions ageRestriction);
		void DeleteAgeRestriction(AgeRestrictions ageRestriction);
	}
}
