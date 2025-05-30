using IndieGameZone.Domain.Entities;
using IndieGameZone.Domain.IRepositories;
using IndieGameZone.Domain.RequestFeatures;
using IndieGameZone.Infrastructure.Extensions;
using IndieGameZone.Infrastructure.Persistence;
using Microsoft.EntityFrameworkCore;

namespace IndieGameZone.Infrastructure.Repositories
{
	internal sealed class ReviewRepository : RepositoryBase<Reviews>, IReviewRepository
	{
		public ReviewRepository(AppDbContext appDbContext) : base(appDbContext)
		{
		}

		public void CreateReview(Reviews review) => Create(review);

		public void DeleteReview(Reviews review) => Delete(review);

		public async Task<Reviews?> GetReviewById(Guid id, bool trackChange, CancellationToken ct = default) => await FindByCondition(r => r.Id.Equals(id), trackChange)
			.SingleOrDefaultAsync(ct);

		public async Task<PagedList<Reviews>> GetReviewsByGameId(Guid gameId, ReviewParameters reviewParameters, bool trackChange, CancellationToken ct = default)
		{
			var reviewEntities = FindByCondition(r => r.GameId.Equals(gameId), trackChange)
				.Sort();

			return await PagedList<Reviews>.ToPagedList(reviewEntities, reviewParameters.PageNumber, reviewParameters.PageSize, ct);
		}
	}
}
