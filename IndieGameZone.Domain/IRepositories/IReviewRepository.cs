using IndieGameZone.Domain.Entities;
using IndieGameZone.Domain.RequestFeatures;

namespace IndieGameZone.Domain.IRepositories
{
	public interface IReviewRepository
	{
		Task<PagedList<Reviews>> GetReviewsByGameId(Guid gameId, ReviewParameters reviewParameters, bool trackChange, CancellationToken ct = default);
		Task<Reviews?> GetReviewById(Guid id, bool trackChange, CancellationToken ct = default);
		void CreateReview(Reviews review);
		void DeleteReview(Reviews review);
	}
}
