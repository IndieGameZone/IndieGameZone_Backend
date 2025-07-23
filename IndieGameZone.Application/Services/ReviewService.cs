using IndieGameZone.Application.IServices;
using IndieGameZone.Domain.Entities;
using IndieGameZone.Domain.Exceptions;
using IndieGameZone.Domain.IRepositories;
using IndieGameZone.Domain.RequestFeatures;
using IndieGameZone.Domain.RequestsAndResponses.Requests.Reviews;
using IndieGameZone.Domain.RequestsAndResponses.Responses.Reviews;
using MapsterMapper;

namespace IndieGameZone.Application.Services
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

		private async Task<bool> CheckGameOwnership(Guid userId, Guid gameId, CancellationToken ct = default)
		{
			var gameLibrary = await repositoryManager.LibraryRepository.GetLibraryByUserIdAndGameId(userId, gameId, false, ct);
			return gameLibrary != null;
		}

		public async Task CreateReview(Guid userId, Guid gameId, ReviewForCreationDto reviewForCreationDto, CancellationToken ct = default)
		{
			if (!await CheckGameOwnership(userId, gameId, ct))
			{
				throw new BadRequestException("You must own this game to create a review.");
			}

			var reviewEntities = mapper.Map<Reviews>(reviewForCreationDto);
			reviewEntities.Id = Guid.NewGuid();
			reviewEntities.UserId = userId;
			reviewEntities.GameId = gameId;
			reviewEntities.CreatedAt = DateTime.Now;

			repositoryManager.ReviewRepository.CreateReview(reviewEntities);
			await repositoryManager.SaveAsync(ct);

			await recombeeService.SendRatingEvent(userId, gameId, (reviewEntities.Rating - 3) / 2.0);
		}

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

		public async Task UpdateReview(Guid userId, Guid id, ReviewForUpdateDto reviewForUpdateDto, CancellationToken ct = default)
		{
			var reviewEntity = await repositoryManager.ReviewRepository.GetReviewById(id, true, ct);
			if (reviewEntity == null)
			{
				throw new NotFoundException("Review not found.");
			}
			if (reviewEntity.UserId != userId)
			{
				throw new BadRequestException("You can only update your own reviews.");
			}
			mapper.Map(reviewForUpdateDto, reviewEntity);
			await repositoryManager.SaveAsync(ct);
			await recombeeService.SendRatingEvent(userId, reviewEntity.GameId, (reviewForUpdateDto.Rating - 3) / 2.0);
		}
	}
}
