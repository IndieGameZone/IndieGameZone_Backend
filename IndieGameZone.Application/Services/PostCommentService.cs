using IndieGameZone.Application.BackgroundJobServices;
using IndieGameZone.Application.IServices;
using IndieGameZone.Domain.Constants;
using IndieGameZone.Domain.Entities;
using IndieGameZone.Domain.Exceptions;
using IndieGameZone.Domain.IRepositories;
using IndieGameZone.Domain.RequestFeatures;
using IndieGameZone.Domain.RequestsAndResponses.Requests.PostComments;
using IndieGameZone.Domain.RequestsAndResponses.Responses.PostComments;
using MapsterMapper;
using Microsoft.EntityFrameworkCore;
using Quartz;

namespace IndieGameZone.Application.Services
{
	internal sealed class PostCommentService : IPostCommentService
	{
		private readonly IRepositoryManager repositoryManager;
		private readonly IMapper mapper;
		private readonly ISchedulerFactory schedulerFactory;

		public PostCommentService(IRepositoryManager repositoryManager, IMapper mapper, ISchedulerFactory schedulerFactory)
		{
			this.repositoryManager = repositoryManager;
			this.mapper = mapper;
			this.schedulerFactory = schedulerFactory;
		}

		private async Task CheckCommentAchievements(Guid userId, CancellationToken ct = default)
		{
			var userAchievements = repositoryManager.UserAchievementRepository.GetUserAchievementsByUserId(userId, false);
			var commentCount = await repositoryManager.PostCommentRepository.GetCommentsByUserId(userId, false).CountAsync();
			var achievement = await repositoryManager.AchievementRepository.GetAchievementByLevelAndType(commentCount, AchievementType.Comment, false, ct);
			if (achievement == null || userAchievements.Any(u => u.AchievementId == achievement.Id))
			{
				return;
			}
			repositoryManager.UserAchievementRepository.AddUserAchievement(new UserAchievements
			{
				UserId = userId,
				AchievementId = achievement.Id
			});
			repositoryManager.NotificationRepository.CreateNotification(new Notifications
			{
				Id = Guid.NewGuid(),
				UserId = userId,
				Message = $"Congratulations! You have earned the {achievement.Name} achievement and receive a {achievement.DiscountAward}% discount.",
				IsRead = false,
				CreatedAt = DateTime.Now
			});
			repositoryManager.CouponRepository.CreateCoupon(new Coupons
			{
				Id = Guid.NewGuid(),
				Code = Guid.NewGuid().ToString(),
				Percentage = achievement.DiscountAward,
				IsUsed = false,
				EndDate = DateOnly.FromDateTime(DateTime.Now.AddDays(7)),
				UserId = userId
			});
			await repositoryManager.SaveAsync(ct);
		}

		public async Task CreateComment(Guid userId, Guid postId, PostCommentForCreationDto postCommentForCreationDto, CancellationToken ct = default)
		{
			var postComment = mapper.Map<PostComments>(postCommentForCreationDto);
			postComment.Id = Guid.NewGuid();
			postComment.UserId = userId;
			postComment.PostId = postId;
			postComment.CreatedAt = DateTime.Now;
			postComment.IsActive = false;

			repositoryManager.PostCommentRepository.CreateComment(postComment);
			await repositoryManager.SaveAsync(ct);

			await CheckCommentAchievements(userId, ct);

			IJobDetail job = JobBuilder.Create<ValidateCommentJob>()
				.WithIdentity("CommentJob", "CommentGroup")
				.UsingJobData("commentId", postComment.Id.ToString())
				.Build();

			ITrigger trigger = TriggerBuilder.Create()
				.WithIdentity("CommentTrigger", "CommentGroup")
				.StartNow()
				.Build();

			var scheduler = await schedulerFactory.GetScheduler(ct);

			await scheduler.ScheduleJob(job, trigger, ct);
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
			postComment.IsActive = false;
			postComment.UpdatedAt = DateTime.Now;
			await repositoryManager.SaveAsync(ct);

			IJobDetail job = JobBuilder.Create<ValidateCommentJob>()
				.WithIdentity("CommentJob", "CommentGroup")
				.UsingJobData("commentId", postComment.Id.ToString())
				.Build();

			ITrigger trigger = TriggerBuilder.Create()
				.WithIdentity("CommentTrigger", "CommentGroup")
				.StartNow()
				.Build();

			var scheduler = await schedulerFactory.GetScheduler(ct);

			await scheduler.ScheduleJob(job, trigger, ct);
		}
	}
}
