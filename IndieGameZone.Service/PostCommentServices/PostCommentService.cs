using IndieGameZone.Domain.Entities;
using IndieGameZone.Domain.Exceptions;
using IndieGameZone.Domain.IRepositories;
using IndieGameZone.Domain.RequestFeatures;
using IndieGameZone.Domain.RequestsAndResponses.Requests.PostComments;
using IndieGameZone.Domain.RequestsAndResponses.Responses.PostComments;
using MapsterMapper;

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
