using IndieGameZone.Application.BackgroundJobServices;
using IndieGameZone.Application.Hub;
using IndieGameZone.Application.IHub;
using IndieGameZone.Application.IServices;
using IndieGameZone.Domain.Constants;
using IndieGameZone.Domain.Entities;
using IndieGameZone.Domain.Exceptions;
using IndieGameZone.Domain.IRepositories;
using IndieGameZone.Domain.RequestFeatures;
using IndieGameZone.Domain.RequestsAndResponses.Requests.Posts;
using IndieGameZone.Domain.RequestsAndResponses.Responses.Posts;
using MapsterMapper;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.SignalR;
using Microsoft.EntityFrameworkCore;
using Quartz;

namespace IndieGameZone.Application.Services
{
	internal sealed class PostService : IPostService
	{
		private readonly IRepositoryManager repositoryManager;
		private readonly IMapper mapper;
		private readonly IBlobService blobService;
		private readonly ISchedulerFactory schedulerFactory;
		private readonly UserManager<Users> userManager;
		private readonly IHubContext<NotificationHub, INotificationHub> notificationHub;

		public PostService(IRepositoryManager repositoryManager, IMapper mapper, IBlobService blobService, ISchedulerFactory schedulerFactory, UserManager<Users> userManager, IHubContext<NotificationHub, INotificationHub> notificationHub)
		{
			this.repositoryManager = repositoryManager;
			this.mapper = mapper;
			this.blobService = blobService;
			this.schedulerFactory = schedulerFactory;
			this.userManager = userManager;
			this.notificationHub = notificationHub;
		}

		private async Task CheckPostAchievement(Guid userId, CancellationToken ct = default)
		{
			var postCount = await repositoryManager.PostRepository.GetPostsByUserId(userId, false).CountAsync();
			var userAchievements = repositoryManager.UserAchievementRepository.GetUserAchievementsByUserId(userId, false);

			var achievement = await repositoryManager.AchievementRepository.GetAchievementByLevelAndType(postCount, AchievementType.Post, false, ct);
			if (achievement is null || userAchievements.Any(x => x.AchievementId == achievement.Id))
			{
				return;
			}
			repositoryManager.UserAchievementRepository.AddUserAchievement(new UserAchievements
			{
				UserId = userId,
				AchievementId = achievement.Id,
			});
			var notification = new Notifications
			{
				Id = Guid.NewGuid(),
				UserId = userId,
				Message = $"Congratulations! You have earned the {achievement.Name} achievement and receive a {achievement.DiscountAward}% discount.",
				CreatedAt = DateTime.Now,
				IsRead = false
			};
			repositoryManager.NotificationRepository.CreateNotification(notification);
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
			await notificationHub.Clients.User(userId.ToString()).SendNotification(notification);
		}

		private async Task DeleteOldPostImage(Guid postId, IEnumerable<string> newPostImages, CancellationToken ct)
		{
			var existingPostImages = await repositoryManager.PostImageRepository.GetPostImagesByPostId(postId, false, ct);
			var existingImageUrls = existingPostImages.Select(x => x.Image).ToList();
			if (existingImageUrls is null || !existingImageUrls.Any())
			{
				return;
			}
			var imagesToDelete = existingImageUrls.Except(newPostImages);
			foreach (var image in imagesToDelete)
			{
				await blobService.DeleteBlob(image.Split('/').Last(), StorageContainer.STORAGE_CONTAINER);
			}
			repositoryManager.PostImageRepository.DeletePostImages(existingPostImages);
			await repositoryManager.SaveAsync(ct);
		}

		public async Task CreatePost(Guid userId, Guid gameId, PostForCreationDto postForCreationDto, CancellationToken ct = default)
		{
			var dbTransaction = await repositoryManager.BeginTransaction();
			var game = await repositoryManager.GameRepository.GetGameById(gameId, false, ct);
			if (game is null)
				throw new NotFoundException($"Game not found.");
			var user = userManager.FindByIdAsync(userId.ToString());
			if (user is null)
				throw new NotFoundException($"User not found.");
			if (postForCreationDto.Tags != null)
			{
				foreach (var tagId in postForCreationDto.Tags)
				{
					var tag = await repositoryManager.TagRepository.GetTagById(tagId, false, ct);
					if (tag is null)
						throw new NotFoundException($"Tag not found.");
				}
			}
			var postEntity = mapper.Map<Posts>(postForCreationDto);
			postEntity.Id = Guid.NewGuid();
			postEntity.UserId = userId;
			postEntity.GameId = gameId;
			postEntity.CreatedAt = DateTime.Now;
			postEntity.Status = PostStatus.PendingAIReview;

			if (postForCreationDto.Images != null && postForCreationDto.Images.Any())
			{
				var postImages = postForCreationDto.Images.Select(image => new PostImages
				{
					Id = Guid.NewGuid(),
					PostId = postEntity.Id,
					Image = image
				}).ToList();
				repositoryManager.PostImageRepository.CreatePostImages(postImages);
			}


			if (postForCreationDto.Tags != null && postForCreationDto.Tags.Any())
			{
				var postTags = postForCreationDto.Tags.Select(tagId => new PostTags
				{
					PostId = postEntity.Id,
					TagId = tagId
				}).ToList();
				repositoryManager.PostTagRepository.CreatePostTag(postTags);
			}

			repositoryManager.PostRepository.CreatePost(postEntity);

			await repositoryManager.SaveAsync(ct);

			await CheckPostAchievement(userId, ct);

			dbTransaction.Commit();

			IJobDetail job = JobBuilder.Create<ValidatePostJob>()
				.WithIdentity("PostJob", "PostGroup")
				.UsingJobData("postId", postEntity.Id.ToString())
				.Build();

			ITrigger trigger = TriggerBuilder.Create()
				.WithIdentity("PostTrigger", "PostGroup")
				.StartNow()
				.Build();

			var scheduler = await schedulerFactory.GetScheduler(ct);

			await scheduler.ScheduleJob(job, trigger, ct);
		}

		public async Task DeletePost(Guid userId, Guid postId, CancellationToken ct = default)
		{
			var dbTransaction = await repositoryManager.BeginTransaction();
			var user = await userManager.FindByIdAsync(userId.ToString());
			if (user is null)
				throw new NotFoundException($"User not found.");
			var post = await repositoryManager.PostRepository.GetPostById(postId, false, ct);
			if (post is null)
				throw new NotFoundException($"Post not found.");
			if (post.UserId != userId)
				throw new ForbiddenException("You are not authorized to delete this post.");
			var postImages = await repositoryManager.PostImageRepository.GetPostImagesByPostId(postId, false, ct);
			foreach (var image in postImages)
			{
				await blobService.DeleteBlob(image.Image.Split('/').Last(), StorageContainer.STORAGE_CONTAINER);
			}
			repositoryManager.PostImageRepository.DeletePostImages(postImages);

			repositoryManager.PostRepository.DeletePost(post);
			await repositoryManager.SaveAsync(ct);
			dbTransaction.Commit();
		}

		public async Task<PostForReturnDto> GetPostById(Guid postId, CancellationToken ct = default)
		{
			var post = await repositoryManager.PostRepository.GetPostById(postId, false, ct);
			if (post is null)
				throw new NotFoundException($"Post not found.");
			return mapper.Map<PostForReturnDto>(post);
		}

		public async Task<(IEnumerable<PostForReturnDto> posts, MetaData metaData)> GetPostsByGameId(Guid gameId, PostParameters postParameters, CancellationToken ct = default)
		{
			var game = await repositoryManager.GameRepository.GetGameById(gameId, false, ct);
			if (game is null)
				throw new NotFoundException($"Game not found.");
			var postWithMetaData = await repositoryManager.PostRepository.GetPostsByGameId(gameId, postParameters, false, ct);
			var posts = mapper.Map<IEnumerable<PostForReturnDto>>(postWithMetaData);
			return (posts, postWithMetaData.MetaData);
		}

		public async Task<(IEnumerable<PostForReturnDto> posts, MetaData metaData)> GetPostsByUserId(Guid userId, PostParameters postParameters, CancellationToken ct = default)
		{
			var user = await userManager.FindByIdAsync(userId.ToString());
			if (user is null)
				throw new NotFoundException($"User not found.");
			var postWithMetaData = await repositoryManager.PostRepository.GetPostsByUserId(userId, postParameters, false, ct);
			var posts = mapper.Map<IEnumerable<PostForReturnDto>>(postWithMetaData);
			return (posts, postWithMetaData.MetaData);
		}

		public async Task UpdatePost(Guid userId, Guid postId, PostForUpdateDto postForUpdateDto, CancellationToken ct = default)
		{
			var dbTransaction = await repositoryManager.BeginTransaction();
			var user = await userManager.FindByIdAsync(userId.ToString());
			if (user is null)
				throw new NotFoundException($"User not found.");
			var post = await repositoryManager.PostRepository.GetPostById(postId, true, ct);
			if (post is null)
				throw new NotFoundException($"Post not found.");
			if (post.UserId != userId)
				throw new ForbiddenException("You are not authorized to update this post.");
			if (postForUpdateDto.Tags != null)
			{
				foreach (var tagId in postForUpdateDto.Tags)
				{
					var tag = await repositoryManager.TagRepository.GetTagById(tagId, false, ct);
					if (tag is null)
						throw new NotFoundException($"Tag not found.");
				}
			}

			await DeleteOldPostImage(postId, postForUpdateDto.Images, ct);

			var existingPostTag = await repositoryManager.PostTagRepository.GetPostTagsByPostId(postId, false, ct);
			repositoryManager.PostTagRepository.DeletePostTag(existingPostTag);
			await repositoryManager.SaveAsync(ct);

			mapper.Map(postForUpdateDto, post);
			post.UpdatedAt = DateTime.Now;
			post.Status = PostStatus.PendingAIReview;

			if (postForUpdateDto.Images != null && postForUpdateDto.Images.Any())
			{
				var postImages = postForUpdateDto.Images.Select(image => new PostImages
				{
					Id = Guid.NewGuid(),
					PostId = postId,
					Image = image
				}).ToList();
				repositoryManager.PostImageRepository.CreatePostImages(postImages);
			}


			if (postForUpdateDto.Tags != null && postForUpdateDto.Tags.Any())
			{
				var postTags = postForUpdateDto.Tags.Select(tagId => new PostTags
				{
					PostId = postId,
					TagId = tagId
				}).ToList();
				repositoryManager.PostTagRepository.CreatePostTag(postTags);
			}


			await repositoryManager.SaveAsync(ct);

			dbTransaction.Commit();

			IJobDetail job = JobBuilder.Create<ValidatePostJob>()
				.WithIdentity("PostJob", "PostGroup")
				.UsingJobData("postId", postId.ToString())
				.Build();

			ITrigger trigger = TriggerBuilder.Create()
				.WithIdentity("PostTrigger", "PostGroup")
				.StartNow()
				.Build();

			var scheduler = await schedulerFactory.GetScheduler(ct);

			await scheduler.ScheduleJob(job, trigger, ct);
		}

		public async Task UpdatePostStatus(Guid postId, PostActivationDto postActivationDto, CancellationToken ct = default)
		{
			var post = await repositoryManager.PostRepository.GetPostById(postId, true, ct);
			if (post is null)
				throw new NotFoundException($"Post not found.");
			post.Status = postActivationDto.Status;
			post.CensoredAt = DateTime.Now;
			await repositoryManager.SaveAsync(ct);
		}
	}
}
