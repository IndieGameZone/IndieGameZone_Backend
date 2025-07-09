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
	}
}
