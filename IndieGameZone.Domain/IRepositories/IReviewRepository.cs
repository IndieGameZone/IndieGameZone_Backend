using IndieGameZone.Domain.Entities;
using IndieGameZone.Domain.RequestFeatures;

namespace IndieGameZone.Domain.IRepositories
{
	public interface IReviewRepository
	{
		Task<PagedList<Reviews>> GetReviewsByGameId(Guid gameId, ReviewParameters reviewParameters, bool trackChange, CancellationToken ct = default);
		Task<PagedList<Reviews>> GetReviewsByUserId(Guid userId, ReviewParameters reviewParameters, bool trackChange, CancellationToken ct = default);
		Task<PagedList<Reviews>> GetReviewsByUserIdAndGameId(Guid userId, Guid gameId, ReviewParameters reviewParameters, bool trackChange, CancellationToken ct = default);
		Task<IEnumerable<Reviews>> GetReviewsByGameId(Guid gameId, bool trackChange, CancellationToken ct = default);
		IQueryable<Reviews> GetReviewsByGameId(Guid gameId, bool trackChange);
		IQueryable<Reviews> GetReviewsByGameIdAndRating(Guid gameId, int rating, bool trackChange);
		Task<Reviews?> GetReviewById(Guid id, bool trackChange, CancellationToken ct = default);
		void CreateReview(Reviews review);
		void DeleteReview(Reviews review);
	}
}
