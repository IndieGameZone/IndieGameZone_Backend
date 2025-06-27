using IndieGameZone.Application.AIService;
using IndieGameZone.Application.RecombeeServices;
using IndieGameZone.Domain.Entities;
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
		private readonly IAIService aIService;
		private readonly IRecombeeService recombeeService;

		public ReviewService(IRepositoryManager repositoryManager, IMapper mapper, IAIService aIService, IRecombeeService recombeeService)
		{
			this.repositoryManager = repositoryManager;
			this.mapper = mapper;
			this.aIService = aIService;
			this.recombeeService = recombeeService;
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

			await recombeeService.SendRatingEvent(userId, gameId, reviewEntities.Rating);
		}

		//public async Task DeleteReview(Guid userId, Guid id, CancellationToken ct = default)
		//{
		//	var reviewEntity = await repositoryManager.ReviewRepository.GetReviewById(id, false, ct);
		//	if (reviewEntity == null)
		//	{
		//		throw new NotFoundException("Review not found.");
		//	}
		//	if (reviewEntity.UserId != userId)
		//	{
		//		throw new ForbiddenException("You are not allowed to delete this review.");
		//	}
		//	repositoryManager.ReviewRepository.DeleteReview(reviewEntity);
		//	await repositoryManager.SaveAsync(ct);
		//}

		public async Task<(IEnumerable<ReviewForReturnDto> reviews, MetaData metaData)> GetReviewsByGameId(Guid gameId, ReviewParameters reviewParameters, CancellationToken ct = default)
		{
			var reviewsWithMetaData = await repositoryManager.ReviewRepository.GetReviewsByGameId(gameId, reviewParameters, false, ct);
			var reviews = mapper.Map<IEnumerable<ReviewForReturnDto>>(reviewsWithMetaData);
			return (reviews, reviewsWithMetaData.MetaData);
		}

		public async Task<string> GetSummaryReviewByGameId(Guid gameId, CancellationToken ct = default)
		{
			var reviews = await repositoryManager.ReviewRepository.GetReviewsByGameId(gameId, false, ct);
			if (reviews == null || !reviews.Any())
			{
				return "There are no review for this game";
			}
			var reviewTexts = reviews.Select(r => r.Comment).ToList();
			var summary = await aIService.SummarizeReviews(reviewTexts, ct);
			return summary;
		}
	}
}
