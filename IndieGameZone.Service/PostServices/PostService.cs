using IndieGameZone.Application.BlobService;
using IndieGameZone.Domain.Constants;
using IndieGameZone.Domain.Entities;
using IndieGameZone.Domain.Exceptions;
using IndieGameZone.Domain.IRepositories;
using IndieGameZone.Domain.RequestFeatures;
using IndieGameZone.Domain.RequestsAndResponses.Requests.Posts;
using IndieGameZone.Domain.RequestsAndResponses.Responses.Posts;
using MapsterMapper;

namespace IndieGameZone.Application.PostServices
{
	internal sealed class PostService : IPostService
	{
		private readonly IRepositoryManager repositoryManager;
		private readonly IMapper mapper;
		private readonly IBlobService blobService;

		public PostService(IRepositoryManager repositoryManager, IMapper mapper, IBlobService blobService)
		{
			this.repositoryManager = repositoryManager;
			this.mapper = mapper;
			this.blobService = blobService;
		}
		public async Task CreatePost(Guid userId, Guid gameId, PostForCreationDto postForCreationDto, CancellationToken ct = default)
		{
			var postEntity = mapper.Map<Posts>(postForCreationDto);
			postEntity.Id = Guid.NewGuid();
			postEntity.UserId = userId;
			postEntity.GameId = gameId;
			postEntity.CreatedAt = DateTime.Now;
			if (postForCreationDto.Image is not null && postForCreationDto.Image.Length > 0)
			{
				string filename = $"{Guid.NewGuid()}{Path.GetExtension(postForCreationDto.Image.FileName)}";
				postEntity.Image = await blobService.UploadBlob(filename, StorageContainer.STORAGE_CONTAINER, postForCreationDto.Image);
			}
			else
			{
				postEntity.Image = string.Empty;
			}
			repositoryManager.PostRepository.CreatePost(postEntity);
			await repositoryManager.SaveAsync(ct);
		}

		public async Task DeletePost(Guid userId, Guid postId, CancellationToken ct = default)
		{
			var post = await repositoryManager.PostRepository.GetPostById(postId, false, ct);
			if (post is null)
				throw new NotFoundException($"Post not found.");
			if (post.UserId != userId)
				throw new UnauthorizedAccessException("You are not authorized to delete this post.");
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
			var post = await repositoryManager.PostRepository.GetPostById(postId, true, ct);
			if (post is null)
				throw new NotFoundException($"Post not found.");
			if (post.UserId != userId)
				throw new UnauthorizedAccessException("You are not authorized to update this post.");
			mapper.Map(postForUpdateDto, post);
			if (postForUpdateDto.Image is not null && postForUpdateDto.Image.Length > 0)
			{
				await blobService.DeleteBlob(post.Image.Split('/').Last(), StorageContainer.STORAGE_CONTAINER);
				string filename = $"{Guid.NewGuid()}{Path.GetExtension(postForUpdateDto.Image.FileName)}";
				post.Image = await blobService.UploadBlob(filename, StorageContainer.STORAGE_CONTAINER, postForUpdateDto.Image);
			}
			post.UpdatedAt = DateTime.Now;
			await repositoryManager.SaveAsync(ct);
		}
	}
}
