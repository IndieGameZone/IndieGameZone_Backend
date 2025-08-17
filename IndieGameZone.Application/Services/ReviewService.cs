using IndieGameZone.Application.IServices;
using IndieGameZone.Domain.Entities;
using IndieGameZone.Domain.Exceptions;
using IndieGameZone.Domain.IRepositories;
using IndieGameZone.Domain.RequestFeatures;
using IndieGameZone.Domain.RequestsAndResponses.Requests.Reviews;
using IndieGameZone.Domain.RequestsAndResponses.Responses.Reviews;
using MapsterMapper;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace IndieGameZone.Application.Services
{
	internal sealed class ReviewService : IReviewService
	{
		private readonly IRepositoryManager repositoryManager;
		private readonly IMapper mapper;
		private readonly IAIService aIService;
		private readonly IRecombeeService recombeeService;
		private readonly UserManager<Users> userManager;

		public ReviewService(IRepositoryManager repositoryManager, IMapper mapper, IAIService aIService, IRecombeeService recombeeService, UserManager<Users> userManager)
		{
			this.repositoryManager = repositoryManager;
			this.mapper = mapper;
			this.aIService = aIService;
			this.recombeeService = recombeeService;
			this.userManager = userManager;
		}

		private async Task<bool> CheckGameOwnership(Guid userId, Guid gameId, CancellationToken ct = default)
		{
			var gameLibrary = await repositoryManager.LibraryRepository.GetLibraryByUserIdAndGameId(userId, gameId, false, ct);
			return gameLibrary != null;
		}

		public async Task CreateReview(Guid userId, Guid gameId, ReviewForCreationDto reviewForCreationDto, CancellationToken ct = default)
		{
			var user = await userManager.Users.AsNoTracking().SingleOrDefaultAsync(u => u.Id == userId);
			if (user == null)
				throw new NotFoundException("User not found");
			var game = await repositoryManager.GameRepository.GetGameById(gameId, false, ct);
			if (game == null)
				throw new NotFoundException("Game not found");
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
			var game = await repositoryManager.GameRepository.GetGameById(gameId, false, ct);
			if (game == null)
			{
				throw new NotFoundException("Game not found.");
			}
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
			var user = await userManager.Users.AsNoTracking().SingleOrDefaultAsync(u => u.Id == userId);
			if (user == null)
				throw new NotFoundException("User not found");
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

		public async Task<IList<RatingStatistic>> GetReviewStatistic(Guid gameId, CancellationToken ct = default)
		{
			var game = await repositoryManager.GameRepository.GetGameById(gameId, false, ct);
			if (game == null)
			{
				throw new NotFoundException("Game not found.");
			}
			var totalCount = await repositoryManager.ReviewRepository.GetReviewsByGameId(gameId, false).CountAsync();

			var result = new List<RatingStatistic>();
			for (int rating = 1; rating <= 5; rating++)
			{
				var count = await repositoryManager.ReviewRepository.GetReviewsByGameIdAndRating(gameId, rating, false).CountAsync();
				result.Add(new RatingStatistic
				{
					Rating = rating,
					Percentage = totalCount == 0 ? 0 : count * 100.0 / totalCount
				});
			}
			return result;
		}

		public async Task<(IEnumerable<ReviewForReturnDto> reviews, MetaData metaData)> GetReviewsByUserId(Guid userId, ReviewParameters reviewParameters, CancellationToken ct = default)
		{
			var user = await userManager.Users.AsNoTracking().SingleOrDefaultAsync(u => u.Id == userId);
			if (user == null)
				throw new NotFoundException("User not found");
			var reviewsWithMetaData = await repositoryManager.ReviewRepository.GetReviewsByUserId(userId, reviewParameters, false, ct);
			var reviews = mapper.Map<IEnumerable<ReviewForReturnDto>>(reviewsWithMetaData);
			return (reviews, reviewsWithMetaData.MetaData);

		}

		public async Task<(IEnumerable<ReviewForReturnDto> reviews, MetaData metaData)> GetReviewsByUserIdAndGameId(Guid gameId, Guid userId, ReviewParameters reviewParameters, CancellationToken ct = default)
		{
			var user = await userManager.Users.AsNoTracking().SingleOrDefaultAsync(u => u.Id == userId);
			if (user == null)
				throw new NotFoundException("User not found");
			var game = await repositoryManager.GameRepository.GetGameById(gameId, false, ct);
			if (game == null)
				throw new NotFoundException("Game not found");
			var reviewsWithMetaData = await repositoryManager.ReviewRepository.GetReviewsByUserIdAndGameId(userId, gameId, reviewParameters, false, ct);
			var reviews = mapper.Map<IEnumerable<ReviewForReturnDto>>(reviewsWithMetaData);
			return (reviews, reviewsWithMetaData.MetaData);
		}
	}
}
