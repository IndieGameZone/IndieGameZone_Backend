using IndieGameZone.Domain.Entities;
using IndieGameZone.Domain.Exceptions;
using IndieGameZone.Domain.IRepositories;
using IndieGameZone.Domain.RequestFeatures;
using IndieGameZone.Domain.RequestsAndResponses.Requests.Reviews;
using IndieGameZone.Domain.RequestsAndResponses.Responses.Reviews;
using MapsterMapper;

namespace IndieGameZone.Application.ReviewServices
{
	internal sealed class ReviewService : IReviewService
	{
		private readonly IRepositoryManager repositoryManager;
		private readonly IMapper mapper;

		public ReviewService(IRepositoryManager repositoryManager, IMapper mapper)
		{
			this.repositoryManager = repositoryManager;
			this.mapper = mapper;
		}

		public async Task CreateReview(Guid userId, Guid gameId, ReviewForCreationDto reviewForCreationDto, CancellationToken ct = default)
		{
			var reviewEntities = mapper.Map<Reviews>(reviewForCreationDto);
			reviewEntities.Id = Guid.NewGuid();
			reviewEntities.UserId = userId;
			reviewEntities.GameId = gameId;
			reviewEntities.CreatedAt = DateTime.Now;

			repositoryManager.ReviewRepository.CreateReview(reviewEntities);
			await repositoryManager.SaveAsync(ct);
		}

		public async Task DeleteReview(Guid userId, Guid id, CancellationToken ct = default)
		{
			var reviewEntity = await repositoryManager.ReviewRepository.GetReviewById(id, false, ct);
			if (reviewEntity == null)
			{
				throw new NotFoundException("Review not found.");
			}
			if (reviewEntity.UserId != userId)
			{
				throw new ForbiddenException("You are not allowed to delete this review.");
			}
			repositoryManager.ReviewRepository.DeleteReview(reviewEntity);
			await repositoryManager.SaveAsync(ct);
		}

		public async Task<(IEnumerable<ReviewForReturnDto> reviews, MetaData metaData)> GetReviewsByGameId(Guid gameId, ReviewParameters reviewParameters, CancellationToken ct = default)
		{
			var reviewsWithMetaData = await repositoryManager.ReviewRepository.GetReviewsByGameId(gameId, reviewParameters, false, ct);
			var reviews = mapper.Map<IEnumerable<ReviewForReturnDto>>(reviewsWithMetaData);
			return (reviews, reviewsWithMetaData.MetaData);
		}
	}
}
