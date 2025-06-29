using IndieGameZone.Domain.Entities;

namespace IndieGameZone.Domain.IRepositories
{
	public interface IPostReactionRepository
	{
		void CreateReactions(PostReactions postReactions);
		void DeleteReactions(PostReactions postReactions);
		Task<PostReactions?> GetReaction(Guid userId, Guid postId, bool trackChange, CancellationToken ct = default);
		IQueryable<PostReactions> GetReactionsByPostId(Guid postId, bool trackChange, CancellationToken ct = default);
		IQueryable<PostReactions> GetReactionsByUserId(Guid userId, bool trackChange, CancellationToken ct = default);

	}
}
