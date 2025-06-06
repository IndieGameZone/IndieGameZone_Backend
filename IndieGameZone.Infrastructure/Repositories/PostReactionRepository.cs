using IndieGameZone.Domain.Entities;
using IndieGameZone.Domain.IRepositories;
using IndieGameZone.Infrastructure.Persistence;
using Microsoft.EntityFrameworkCore;

namespace IndieGameZone.Infrastructure.Repositories
{
	internal sealed class PostReactionRepository : RepositoryBase<PostReactions>, IPostReactionRepository
	{
		public PostReactionRepository(AppDbContext appDbContext) : base(appDbContext)
		{
		}

		public void CreateReactions(PostReactions postReactions) => Create(postReactions);

		public void DeleteReactions(PostReactions postReactions) => Delete(postReactions);

		public async Task<PostReactions?> GetReaction(Guid userId, Guid postId, bool trackChange, CancellationToken ct = default) => await FindByCondition(p => p.UserId == userId && p.PostId == postId, trackChange).SingleOrDefaultAsync(ct);

		public IQueryable<PostReactions> GetReactionsByPostId(Guid postId, bool trackChange, CancellationToken ct = default) => FindByCondition(p => p.PostId == postId, trackChange);
	}
}
