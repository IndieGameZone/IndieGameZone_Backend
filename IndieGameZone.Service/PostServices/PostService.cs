using IndieGameZone.Application.BackgroundJobServices;
using IndieGameZone.Application.BlobService;
using IndieGameZone.Domain.Constants;
using IndieGameZone.Domain.Entities;
using IndieGameZone.Domain.Exceptions;
using IndieGameZone.Domain.IRepositories;
using IndieGameZone.Domain.RequestFeatures;
using IndieGameZone.Domain.RequestsAndResponses.Requests.Posts;
using IndieGameZone.Domain.RequestsAndResponses.Responses.Posts;
using MapsterMapper;
using Quartz;

namespace IndieGameZone.Application.PostServices
{
	internal sealed class PostService : IPostService
	{
		private readonly IRepositoryManager repositoryManager;
		private readonly IMapper mapper;
		private readonly IBlobService blobService;
		private readonly ISchedulerFactory schedulerFactory;

		public PostService(IRepositoryManager repositoryManager, IMapper mapper, IBlobService blobService, ISchedulerFactory schedulerFactory)
		{
			this.repositoryManager = repositoryManager;
			this.mapper = mapper;
			this.blobService = blobService;
			this.schedulerFactory = schedulerFactory;
		}
		public async Task CreatePost(Guid userId, Guid gameId, PostForCreationDto postForCreationDto, CancellationToken ct = default)
		{
			var postEntity = mapper.Map<Posts>(postForCreationDto);
			postEntity.Id = Guid.NewGuid();
			postEntity.UserId = userId;
			postEntity.GameId = gameId;
			postEntity.CreatedAt = DateTime.Now;
			postEntity.Status = PostStatus.PendingAIReview;

			IList<PostTags> postTags = new List<PostTags>();
			foreach (var tagId in postForCreationDto.Tags)
			{
				var postTag = new PostTags
				{
					PostId = postEntity.Id,
					TagId = tagId
				};
				postTags.Add(postTag);
			}

			repositoryManager.PostRepository.CreatePost(postEntity);
			repositoryManager.PostTagRepository.CreatePostTag(postTags);
			await repositoryManager.SaveAsync(ct);

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
			var post = await repositoryManager.PostRepository.GetPostById(postId, false, ct);
			if (post is null)
				throw new NotFoundException($"Post not found.");
			if (post.UserId != userId)
				throw new ForbiddenException("You are not authorized to delete this post.");
			if (!string.IsNullOrEmpty(post.Image))
			{
				await blobService.DeleteBlob(post.Image.Split('/').Last(), StorageContainer.STORAGE_CONTAINER);
			}
			repositoryManager.PostRepository.DeletePost(post);
			await repositoryManager.SaveAsync(ct);
		}

		public async Task<PostForSingleReturnDto> GetPostById(Guid postId, CancellationToken ct = default)
		{
			var post = await repositoryManager.PostRepository.GetPostById(postId, false, ct);
			if (post is null)
				throw new NotFoundException($"Post not found.");
			return mapper.Map<PostForSingleReturnDto>(post);
		}

		public async Task<(IEnumerable<PostForListReturnDto> posts, MetaData metaData)> GetPostsByGameId(Guid gameId, PostParameters postParameters, CancellationToken ct = default)
		{
			var postWithMetaData = await repositoryManager.PostRepository.GetPostsByGameId(gameId, postParameters, false, ct);
			var posts = mapper.Map<IEnumerable<PostForListReturnDto>>(postWithMetaData);
			return (posts, postWithMetaData.MetaData);
		}

		public async Task<(IEnumerable<PostForListReturnDto> posts, MetaData metaData)> GetPostsByUserId(Guid userId, PostParameters postParameters, CancellationToken ct = default)
		{
			var postWithMetaData = await repositoryManager.PostRepository.GetPostsByUserId(userId, postParameters, false, ct);
			var posts = mapper.Map<IEnumerable<PostForListReturnDto>>(postWithMetaData);
			return (posts, postWithMetaData.MetaData);
		}

		public async Task UpdatePost(Guid userId, Guid postId, PostForUpdateDto postForUpdateDto, CancellationToken ct = default)
		{
			var existingPostTag = await repositoryManager.PostTagRepository.GetPostTagsByPostId(postId, false, ct);
			repositoryManager.PostTagRepository.DeletePostTag(existingPostTag);
			await repositoryManager.SaveAsync(ct);

			var post = await repositoryManager.PostRepository.GetPostById(postId, true, ct);
			if (post is null)
				throw new NotFoundException($"Post not found.");
			if (post.UserId != userId)
				throw new ForbiddenException("You are not authorized to update this post.");
			mapper.Map(postForUpdateDto, post);
			post.UpdatedAt = DateTime.Now;
			post.Status = PostStatus.PendingAIReview;

			IList<PostTags> postTags = new List<PostTags>();
			foreach (var tagId in postForUpdateDto.Tags)
			{
				var postTag = new PostTags
				{
					PostId = postId,
					TagId = tagId
				};
				postTags.Add(postTag);
			}
			repositoryManager.PostTagRepository.CreatePostTag(postTags);

			await repositoryManager.SaveAsync(ct);

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
	}
}
