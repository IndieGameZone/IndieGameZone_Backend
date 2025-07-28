using IndieGameZone.Domain.Constants;
using IndieGameZone.Domain.Entities;
using IndieGameZone.Domain.RequestFeatures;

namespace IndieGameZone.Domain.IRepositories
{
	public interface ICommercialRegistrationRepository
	{
		void CreateCommercialRegistration(CommercialRegistrations commercialRegistration);
		void DeleteCommercialRegistration(CommercialRegistrations commercialRegistration);
		Task<CommercialRegistrations?> GetCommercialRegistrationById(Guid id, bool trackChange, CancellationToken ct = default);
		Task<PagedList<CommercialRegistrations>> GetCommercialRegistrations(CommercialRegistrationParameters commercialRegistrationParameters, bool trackChange, CancellationToken ct = default);
		Task<PagedList<CommercialRegistrations>> GetCommercialRegistrationsByUser(Guid userId, CommercialRegistrationParameters commercialRegistrationParameters, bool trackChange, CancellationToken ct = default);
		Task<PagedList<CommercialRegistrations>> GetCommercialRegistrationsByGame(Guid gameId, CommercialRegistrationParameters commercialRegistrationParameters, bool trackChange, CancellationToken ct = default);
		Task<PagedList<CommercialRegistrations>> GetCommercialRegistrationsByPackage(Guid commercialPackageId, CommercialRegistrationParameters commercialRegistrationParameters, bool trackChange, CancellationToken ct = default);
		Task<List<CommercialRegistrations>> GetRelevantRegistrationsForDateCheckAsync(CommercialPackageType packageType, Guid? categoryId, CancellationToken ct = default);
		Task<CommercialRegistrations?> GetCategoryCommercialRegistrationByGameId(Guid gameId, bool trackChange, CancellationToken ct = default);

		//Task<bool> IsCommercialRegistrationExists(Guid userId, Guid commercialPackageId, CancellationToken ct = default);
		//Task<bool> IsCommercialRegistrationExistsById(Guid id, CancellationToken ct = default);
		//Task CreateCommercialRegistrationAsync(Guid userId, Guid commercialPackageId, CancellationToken ct = default);
		//Task CancelCommercialRegistrationAsync(Guid id, CancellationToken ct = default);
		//Task<List<Guid>> GetUserIdsByCommercialPackageIdAsync(Guid commercialPackageId, CancellationToken ct = default);
	}
}
