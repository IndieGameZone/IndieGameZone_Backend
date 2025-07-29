using IndieGameZone.Domain.Constants;
using IndieGameZone.Domain.Entities;
using IndieGameZone.Domain.IRepositories;
using IndieGameZone.Domain.RequestFeatures;
using IndieGameZone.Infrastructure.Extensions;
using IndieGameZone.Infrastructure.Persistence;
using Microsoft.EntityFrameworkCore;

namespace IndieGameZone.Infrastructure.Repositories
{
	internal sealed class CommercialRegistrationRepository : RepositoryBase<CommercialRegistrations>, ICommercialRegistrationRepository
	{
		public CommercialRegistrationRepository(AppDbContext appDbContext) : base(appDbContext)
		{
		}

		public void CreateCommercialRegistration(CommercialRegistrations commercialRegistration) => Create(commercialRegistration);

		public async Task<CommercialRegistrations?> GetCommercialRegistrationById(Guid id, bool trackChange, CancellationToken ct = default) =>
			await FindByCondition(a => a.Id.Equals(id), trackChange)
				.Include(cr => cr.Game)
					.ThenInclude(g => g.Developer)
						.ThenInclude(d => d.UserProfile)
                .Include(cr => cr.CommercialPackage)
				.AsSplitQuery()
                .SingleOrDefaultAsync(ct);

		public async Task<PagedList<CommercialRegistrations>> GetCommercialRegistrations(CommercialRegistrationParameters commercialRegistrationParameters, bool trackChange, CancellationToken ct = default)
		{
			var commercialRegistrationEntities = FindAll(trackChange)
				.Include(cr => cr.Game)
					.ThenInclude(g => g.Developer)
						.ThenInclude(d => d.UserProfile)
                .Include(cr => cr.CommercialPackage)
				.AsSplitQuery()
                .Sort();

			return await PagedList<CommercialRegistrations>.ToPagedList(commercialRegistrationEntities, commercialRegistrationParameters.PageNumber, commercialRegistrationParameters.PageSize, ct);
		}

		public async Task<PagedList<CommercialRegistrations>> GetCommercialRegistrationsByUser(Guid userId, CommercialRegistrationParameters commercialRegistrationParameters, bool trackChange, CancellationToken ct = default)
		{
			var commercialRegistrationEntities = FindAll(trackChange)
				.Include(cr => cr.Game)
					.ThenInclude(g => g.Developer)
						.ThenInclude(d => d.UserProfile)
                .Include(cr => cr.CommercialPackage)
                .Where(cr => cr.Game.DeveloperId == userId)
                .AsSplitQuery()
                .Sort();

			return await PagedList<CommercialRegistrations>.ToPagedList(
				commercialRegistrationEntities,
				commercialRegistrationParameters.PageNumber,
				commercialRegistrationParameters.PageSize,
				ct);
		}

		public async Task<PagedList<CommercialRegistrations>> GetCommercialRegistrationsByGame(Guid gameId, CommercialRegistrationParameters commercialRegistrationParameters, bool trackChange, CancellationToken ct = default)
		{
			var commercialRegistrationEntities = FindByCondition(cr => cr.GameId.Equals(gameId), trackChange)
				.Include(cr => cr.Game)
					.ThenInclude(g => g.Developer)
						.ThenInclude(d => d.UserProfile)
                .Include(cr => cr.CommercialPackage)
				.AsSplitQuery()
                .Sort();

			return await PagedList<CommercialRegistrations>.ToPagedList(
				commercialRegistrationEntities,
				commercialRegistrationParameters.PageNumber,
				commercialRegistrationParameters.PageSize,
				ct);
		}

		public async Task<PagedList<CommercialRegistrations>> GetCommercialRegistrationsByPackage(Guid commercialPackageId, CommercialRegistrationParameters commercialRegistrationParameters, bool trackChange, CancellationToken ct = default)
		{
			var commercialRegistrationEntities = FindByCondition(cr => cr.CommercialPackageId.Equals(commercialPackageId), trackChange)
				.Include(cr => cr.Game)
					.ThenInclude(g => g.Developer)
						.ThenInclude(d => d.UserProfile)
                .Include(cr => cr.CommercialPackage)
                .AsSplitQuery()
                .Sort();

			return await PagedList<CommercialRegistrations>.ToPagedList(
				commercialRegistrationEntities,
				commercialRegistrationParameters.PageNumber,
				commercialRegistrationParameters.PageSize,
				ct);
		}

		public void DeleteCommercialRegistration(CommercialRegistrations commercialRegistration) => Delete(commercialRegistration);

		public async Task<List<CommercialRegistrations>> GetRelevantRegistrationsForDateCheckAsync(CommercialPackageType packageType, Guid? categoryId, CancellationToken ct = default)
		{
			var registrations = FindByCondition(
		r => r.CommercialPackage.Type == packageType &&
			(packageType == CommercialPackageType.HomepageBanner ||
			 (packageType == CommercialPackageType.CategoryBanner && r.Game.CategoryId == categoryId)),
		trackChanges: false)
		.Include(r => r.CommercialPackage)
		.Include(r => r.Game)
			.ThenInclude(g => g.Developer)
						.ThenInclude(d => d.UserProfile)
        .AsSplitQuery()
        .Sort();

			return await registrations.ToListAsync(ct);
		}

		public Task<CommercialRegistrations?> GetCategoryCommercialRegistrationByGameId(Guid gameId, bool trackChange, CancellationToken ct = default)
		{
			var now = DateTime.Now;
            var registration = FindByCondition(
				r => r.GameId == gameId && r.StartDate <= DateOnly.FromDateTime(now) && DateOnly.FromDateTime(now) <= r.EndDate,
				trackChange)
				.Include(r => r.CommercialPackage)
	            .Include(r => r.Game)
					.ThenInclude(g => g.Developer)
						.ThenInclude(d => d.UserProfile)
                .Where(r => r.CommercialPackage.Type == CommercialPackageType.CategoryBanner)
	            .AsSplitQuery()
                .FirstOrDefaultAsync(ct);
			return registration;
		}

        public async Task<List<CommercialRegistrations>> GetRegistrationsForStatusUpdate(DateOnly today, CancellationToken ct = default)
        {
            return await FindByCondition(r =>
                (r.Status == CommercialRegistrationStatus.Pending && r.StartDate == today) || // activate or fail
                (r.Status == CommercialRegistrationStatus.Active && r.EndDate.HasValue && r.EndDate <= today) || // expire active
                (r.Status == CommercialRegistrationStatus.Pending && r.EndDate.HasValue && r.EndDate <= today), // expire pending
                trackChanges: true
            )
            .Include(r => r.Game)
				.ThenInclude(g => g.Developer)
						.ThenInclude(d => d.UserProfile)
            .ToListAsync(ct);
        }

    }
}
