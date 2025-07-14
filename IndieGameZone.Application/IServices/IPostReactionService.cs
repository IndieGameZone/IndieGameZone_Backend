namespace IndieGameZone.Application.IServices
{
	public interface IPostReactionService
	{
		Task CreateOrDeleteReactions(Guid userId, Guid postId, CancellationToken ct = default);
		Task<bool> IsPostLikedByUser(Guid userId, Guid postId, CancellationToken ct = default);
		Task<int> GetNumberOfLikesByPostId(Guid postId, CancellationToken ct = default);
	}
}
