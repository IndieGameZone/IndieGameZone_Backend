using IndieGameZone.Domain.RequestFeatures;
using IndieGameZone.Domain.RequestsAndResponses.Requests.Reviews;
using IndieGameZone.Domain.RequestsAndResponses.Responses.Reviews;

namespace IndieGameZone.Application.IServices
{
	public interface IReviewService
	{
		Task CreateReview(Guid userId, Guid gameId, ReviewForCreationDto reviewForCreationDto, CancellationToken ct = default);
		Task UpdateReview(Guid userId, Guid id, ReviewForUpdateDto reviewForUpdateDto, CancellationToken ct = default);
		Task<string> GetSummaryReviewByGameId(Guid gameId, CancellationToken ct = default);
		Task<(IEnumerable<ReviewForReturnDto> reviews, MetaData metaData)> GetReviewsByGameId(Guid gameId, ReviewParameters reviewParameters, CancellationToken ct = default);
	}
}
