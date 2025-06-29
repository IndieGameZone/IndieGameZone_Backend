using IndieGameZone.Domain.Entities;
using IndieGameZone.Domain.RequestFeatures;

namespace IndieGameZone.Domain.IRepositories
{
	public interface IPostCommentRepository
	{
		void CreateComment(PostComments comment);
		void DeleteComment(PostComments comment);
		Task<PagedList<PostComments>> GetCommentsByPostId(Guid postId, PostCommentParameters postCommentParameters, bool trackChange, CancellationToken ct = default);
		Task<PostComments?> GetCommentById(Guid commentId, bool trackChange, CancellationToken ct = default);
		IQueryable<PostComments> GetCommentsByUserId(Guid userId, bool trackChange, CancellationToken ct = default);
	}
}
