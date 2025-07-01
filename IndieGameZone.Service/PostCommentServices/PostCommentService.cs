using IndieGameZone.Domain.Entities;
using IndieGameZone.Domain.Exceptions;
using IndieGameZone.Domain.IRepositories;
using IndieGameZone.Domain.RequestFeatures;
using IndieGameZone.Domain.RequestsAndResponses.Requests.PostComments;
using IndieGameZone.Domain.RequestsAndResponses.Responses.PostComments;
using MapsterMapper;
using Microsoft.EntityFrameworkCore;

namespace IndieGameZone.Application.PostCommentServices
{
	internal sealed class PostCommentService : IPostCommentService
	{
		private readonly IRepositoryManager repositoryManager;
		private readonly IMapper mapper;

		public PostCommentService(IRepositoryManager repositoryManager, IMapper mapper)
		{
			this.repositoryManager = repositoryManager;
			this.mapper = mapper;
		}

		private async Task CheckCommentAchievements(Guid userId, CancellationToken ct = default)
		{
			var userAchievements = repositoryManager.UserAchievementRepository.GetUserAchievementsByUserId(userId, false);
			var commentCount = await repositoryManager.PostCommentRepository.GetCommentsByUserId(userId, false).CountAsync();
			if (commentCount == 1 && !userAchievements.Any(u => u.AchievementId == Guid.Parse("f3e1b3e3-9ac3-41e3-83a6-83b44b76446b")))
			{
				var achievement = await repositoryManager.AchievementRepository.GetAchievementById(Guid.Parse("f3e1b3e3-9ac3-41e3-83a6-83b44b76446b"), false, ct);
				if (achievement is null)
					throw new NotFoundException("Achievement not found.");
				repositoryManager.UserAchievementRepository.AddUserAchievement(new UserAchievements
				{
					UserId = userId,
					AchievementId = Guid.Parse("f3e1b3e3-9ac3-41e3-83a6-83b44b76446b")
				});
				repositoryManager.CouponRepository.CreateCoupon(new Coupons
				{
					Id = Guid.NewGuid(),
					Code = Guid.NewGuid().ToString(),
					Percentage = 3,
					IsUsed = false,
					EndDate = DateOnly.FromDateTime(DateTime.Now.AddDays(30)),
					UserId = userId
				});
				repositoryManager.NotificationRepository.CreateNotification(new Notifications
				{
					Id = Guid.NewGuid(),
					UserId = userId,
					Message = $"Congratulations! You have earned the {achievement.Name} achievement and a 3% discount coupon.",
					IsRead = false,
					CreatedAt = DateTime.Now
				});
			}
			else if (commentCount == 10 && !userAchievements.Any(u => u.AchievementId == Guid.Parse("d55f9b9a-d660-4c9a-bc35-94d7ef5a4eb3")))
			{
				var achievement = await repositoryManager.AchievementRepository.GetAchievementById(Guid.Parse("d55f9b9a-d660-4c9a-bc35-94d7ef5a4eb3"), false, ct);
				if (achievement is null)
					throw new NotFoundException("Achievement not found.");
				repositoryManager.UserAchievementRepository.AddUserAchievement(new UserAchievements
				{
					UserId = userId,
					AchievementId = Guid.Parse("d55f9b9a-d660-4c9a-bc35-94d7ef5a4eb3")
				});
				repositoryManager.CouponRepository.CreateCoupon(new Coupons
				{
					Id = Guid.NewGuid(),
					Code = Guid.NewGuid().ToString(),
					Percentage = 4,
					IsUsed = false,
					EndDate = DateOnly.FromDateTime(DateTime.Now.AddDays(30)),
					UserId = userId
				});
				repositoryManager.NotificationRepository.CreateNotification(new Notifications
				{
					Id = Guid.NewGuid(),
					UserId = userId,
					Message = $"Congratulations! You have earned the {achievement.Name} achievement and a 4% discount coupon.",
					IsRead = false,
					CreatedAt = DateTime.Now
				});
			}
			else if (commentCount == 50 && !userAchievements.Any(u => u.AchievementId == Guid.Parse("2190f97e-1533-4c91-9152-f7ae9ec6f8c0")))
			{
				var achievement = await repositoryManager.AchievementRepository.GetAchievementById(Guid.Parse("2190f97e-1533-4c91-9152-f7ae9ec6f8c0"), false, ct);
				if (achievement is null)
					throw new NotFoundException("Achievement not found.");
				repositoryManager.UserAchievementRepository.AddUserAchievement(new UserAchievements
				{
					UserId = userId,
					AchievementId = Guid.Parse("2190f97e-1533-4c91-9152-f7ae9ec6f8c0")
				});
				repositoryManager.CouponRepository.CreateCoupon(new Coupons
				{
					Id = Guid.NewGuid(),
					Code = Guid.NewGuid().ToString(),
					Percentage = 5,
					IsUsed = false,
					EndDate = DateOnly.FromDateTime(DateTime.Now.AddDays(30)),
					UserId = userId
				});
				repositoryManager.NotificationRepository.CreateNotification(new Notifications
				{
					Id = Guid.NewGuid(),
					UserId = userId,
					Message = $"Congratulations! You have earned the {achievement.Name} achievement and a 5% discount coupon.",
					IsRead = false,
					CreatedAt = DateTime.Now
				});

			}
			await repositoryManager.SaveAsync(ct);
		}

		public async Task CreateComment(Guid userId, Guid postId, PostCommentForCreationDto postCommentForCreationDto, CancellationToken ct = default)
		{
			var postComment = mapper.Map<PostComments>(postCommentForCreationDto);
			postComment.Id = Guid.NewGuid();
			postComment.UserId = userId;
			postComment.PostId = postId;
			postComment.CreatedAt = DateTime.Now;
			postComment.IsActive = true;

			repositoryManager.PostCommentRepository.CreateComment(postComment);
			await repositoryManager.SaveAsync(ct);

			await CheckCommentAchievements(userId, ct);
		}

		public async Task DeleteComment(Guid userId, Guid commentId, CancellationToken ct = default)
		{
			var postComment = await repositoryManager.PostCommentRepository.GetCommentById(commentId, false, ct);
			if (postComment == null)
			{
				throw new NotFoundException("Comment not found.");
			}
			if (postComment.UserId != userId)
			{
				throw new ForbiddenException("You do not have permission to delete this comment.");
			}
			repositoryManager.PostCommentRepository.DeleteComment(postComment);
			await repositoryManager.SaveAsync(ct);
		}

		public async Task<(IEnumerable<PostCommentForReturnDto> comments, MetaData metaData)> GetCommentsByPostId(Guid postId, PostCommentParameters postCommentParameters, CancellationToken ct = default)
		{
			var postCommentWithMetaData = await repositoryManager.PostCommentRepository.GetCommentsByPostId(postId, postCommentParameters, false, ct);
			var postComments = mapper.Map<IEnumerable<PostCommentForReturnDto>>(postCommentWithMetaData);
			return (postComments, postCommentWithMetaData.MetaData);
		}

		public async Task UpdateComment(Guid userId, Guid commentId, PostCommentForUpdateDto postCommentForUpdateDto, CancellationToken ct = default)
		{
			var postComment = await repositoryManager.PostCommentRepository.GetCommentById(commentId, true, ct);
			if (postComment == null)
			{
				throw new NotFoundException("Comment not found.");
			}
			if (postComment.UserId != userId)
			{
				throw new ForbiddenException("You do not have permission to update this comment.");
			}

			mapper.Map(postCommentForUpdateDto, postComment);
			postComment.UpdatedAt = DateTime.Now;
			await repositoryManager.SaveAsync(ct);
		}
	}
}
