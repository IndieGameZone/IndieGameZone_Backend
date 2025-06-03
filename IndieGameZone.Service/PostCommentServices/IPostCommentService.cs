using IndieGameZone.Domain.RequestFeatures;
using IndieGameZone.Domain.RequestsAndResponses.Requests.PostComments;
using IndieGameZone.Domain.RequestsAndResponses.Responses.PostComments;

namespace IndieGameZone.Application.PostCommentServices
{
	public interface IPostCommentService
	{
		Task CreateComment(Guid userId, Guid postId, PostCommentForCreationDto postCommentForCreationDto, CancellationToken ct = default);
		Task DeleteComment(Guid userId, Guid commentId, CancellationToken ct = default);
		Task UpdateComment(Guid userId, Guid commentId, PostCommentForUpdateDto postCommentForUpdateDto, CancellationToken ct = default);
		Task<(IEnumerable<PostCommentForReturnDto> comments, MetaData metaData)> GetCommentsByPostId(Guid postId, PostCommentParameters postCommentParameters, CancellationToken ct = default);
	}
}
