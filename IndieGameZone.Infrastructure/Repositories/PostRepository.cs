using IndieGameZone.Domain.Entities;
using IndieGameZone.Domain.IRepositories;
using IndieGameZone.Domain.RequestFeatures;
using IndieGameZone.Infrastructure.Extensions;
using IndieGameZone.Infrastructure.Persistence;
using Microsoft.EntityFrameworkCore;

namespace IndieGameZone.Infrastructure.Repositories
{
	internal sealed class PostRepository : RepositoryBase<Posts>, IPostRepository
	{
		public PostRepository(AppDbContext appDbContext) : base(appDbContext)
		{
		}

		public void CreatePost(Posts post) => Create(post);

		public void DeletePost(Posts posts) => Delete(posts);

		public async Task<Posts?> GetPostById(Guid postId, bool trackChange, CancellationToken ct = default) => await
			FindByCondition(p => p.Id.Equals(postId), trackChange).FirstOrDefaultAsync(ct);

		public async Task<PagedList<Posts>> GetPostsByGameId(Guid gameId, PostParameters postParameters, bool trackChange, CancellationToken ct = default)
		{
			var posts = FindByCondition(p => p.GameId.Equals(gameId), trackChange)
				.Sort();

			return await PagedList<Posts>.ToPagedList(posts, postParameters.PageNumber, postParameters.PageSize, ct);
		}

		public Task<PagedList<Posts>> GetPostsByUserId(Guid userId, PostParameters postParameters, bool trackChange, CancellationToken ct = default)
		{
			var posts = FindByCondition(p => p.UserId.Equals(userId), trackChange)
				.Sort();
			return PagedList<Posts>.ToPagedList(posts, postParameters.PageNumber, postParameters.PageSize, ct);
		}
	}
}
