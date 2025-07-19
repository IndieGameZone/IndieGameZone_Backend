using IndieGameZone.Domain.Constants;
using IndieGameZone.Domain.Entities;
using IndieGameZone.Domain.IRepositories;
using IndieGameZone.Domain.RequestFeatures;
using IndieGameZone.Infrastructure.Extensions;
using IndieGameZone.Infrastructure.Persistence;
using Microsoft.EntityFrameworkCore;

namespace IndieGameZone.Infrastructure.Repositories
{
	internal sealed class CommercialRegistrationRepository : RepositoryBase<CommercialRegistration>, ICommercialRegistrationRepository
	{
		public CommercialRegistrationRepository(AppDbContext appDbContext) : base(appDbContext)
		{
		}

		public void CreateCommercialRegistration(CommercialRegistration commercialRegistration) => Create(commercialRegistration);

		public async Task<CommercialRegistration?> GetCommercialRegistrationById(Guid id, bool trackChange, CancellationToken ct = default) =>
			await FindByCondition(a => a.Id.Equals(id), trackChange)
				.Include(cr => cr.Game)
				.Include(cr => cr.Transaction)
				.SingleOrDefaultAsync(ct);

		public async Task<PagedList<CommercialRegistration>> GetCommercialRegistrations(CommercialRegistrationParameters commercialRegistrationParameters, bool trackChange, CancellationToken ct = default)
		{
			var commercialRegistrationEntities = FindAll(trackChange)
				.Include(cr => cr.Game)
				.Include(cr => cr.Transaction)
				.Sort();

			return await PagedList<CommercialRegistration>.ToPagedList(commercialRegistrationEntities, commercialRegistrationParameters.PageNumber, commercialRegistrationParameters.PageSize, ct);
		}

		public async Task<PagedList<CommercialRegistration>> GetCommercialRegistrationsByUser(Guid userId, CommercialRegistrationParameters commercialRegistrationParameters, bool trackChange, CancellationToken ct = default)
		{
			var commercialRegistrationEntities = FindByCondition(cr => cr.Transaction.UserId == userId, trackChange)
				.Include(cr => cr.Game)
				.Include(cr => cr.Transaction)
				.Sort();

			return await PagedList<CommercialRegistration>.ToPagedList(
				commercialRegistrationEntities,
				commercialRegistrationParameters.PageNumber,
				commercialRegistrationParameters.PageSize,
				ct);
		}

		public async Task<PagedList<CommercialRegistration>> GetCommercialRegistrationsByGame(Guid gameId, CommercialRegistrationParameters commercialRegistrationParameters, bool trackChange, CancellationToken ct = default)
		{
			var commercialRegistrationEntities = FindByCondition(cr => cr.GameId.Equals(gameId), trackChange)
				.Include(cr => cr.Game)
				.Include(cr => cr.Transaction)
				.Sort();

			return await PagedList<CommercialRegistration>.ToPagedList(
				commercialRegistrationEntities,
				commercialRegistrationParameters.PageNumber,
				commercialRegistrationParameters.PageSize,
				ct);
		}

		public async Task<PagedList<CommercialRegistration>> GetCommercialRegistrationsByPackage(Guid commercialPackageId, CommercialRegistrationParameters commercialRegistrationParameters, bool trackChange, CancellationToken ct = default)
		{
			var commercialRegistrationEntities = FindByCondition(cr => cr.CommercialPackageId.Equals(commercialPackageId), trackChange)
				.Include(cr => cr.Game)
				.Include(cr => cr.Transaction)
				.Sort();

			return await PagedList<CommercialRegistration>.ToPagedList(
				commercialRegistrationEntities,
				commercialRegistrationParameters.PageNumber,
				commercialRegistrationParameters.PageSize,
				ct);
		}

		public void DeleteCommercialRegistration(CommercialRegistration commercialRegistration) => Delete(commercialRegistration);

		public async Task<List<CommercialRegistration>> GetRelevantRegistrationsForDateCheckAsync(CommercialPackageType packageType, Guid? categoryId, CancellationToken ct = default)
		{
			var registrations = FindByCondition(
		r => r.CommercialPackage.Type == packageType &&
			(packageType == CommercialPackageType.HomepageBanner ||
			 (packageType == CommercialPackageType.CategoryBanner && r.Game.CategoryId == categoryId)),
		trackChanges: false)
		.Include(r => r.CommercialPackage)
		.Include(r => r.Game)
		.Sort();

			return await registrations.ToListAsync(ct);
		}

		public Task<CommercialRegistration?> GetCategoryCommercialRegistrationByGameId(Guid gameId, bool trackChange, CancellationToken ct = default)
		{
			var registration = FindByCondition(
				r => r.GameId == gameId && r.StartDate <= DateOnly.FromDateTime(DateTime.Now) && DateOnly.FromDateTime(DateTime.Now) <= r.EndDate,
				trackChange)
				.Include(r => r.CommercialPackage).Where(r => r.CommercialPackage.Type == CommercialPackageType.CategoryBanner)
				.FirstOrDefaultAsync(ct);
			return registration;
		}
	}
}
