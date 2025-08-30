using IndieGameZone.Domain.Entities;
using IndieGameZone.Domain.RequestFeatures;

namespace IndieGameZone.Domain.IRepositories
{
	public interface IPostRepository
	{
		void CreatePost(Posts post);
		void DeletePost(Posts posts);
		Task<PagedList<Posts>> GetPostsByGameId(Guid gameId, PostParameters postParameters, bool trackChange, CancellationToken ct = default);
		Task<PagedList<Posts>> GetPosts(PostParameters postParameters, bool trackChange, CancellationToken ct = default);
		Task<PagedList<Posts>> GetPostsByUserId(Guid userId, PostParameters postParameters, bool trackChange, CancellationToken ct = default);
		Task<PagedList<Posts>> GetActivePostsByUserId(Guid userId, PostParameters postParameters, bool trackChange = false, CancellationToken ct = default);
		Task<Posts?> GetPostById(Guid postId, bool trackChange, CancellationToken ct = default);
		IQueryable<Posts> GetPostsByUserId(Guid userId, bool trackChange = false, CancellationToken ct = default);
	}
}
