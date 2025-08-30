using IndieGameZone.Domain.Constants;
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

		public Task<PagedList<Posts>> GetActivePostsByUserId(Guid userId, PostParameters postParameters, bool trackChange = false, CancellationToken ct = default)
		{
			var posts = FindByCondition(p => p.UserId.Equals(userId) && p.Status == PostStatus.Approved, trackChange)
				.Include(p => p.PostTags).ThenInclude(p => p.Tag).AsSplitQuery()
				.Include(p => p.PostImages).AsSplitQuery()
				.Include(p => p.PostReactions).AsSplitQuery()
				.Include(p => p.PostComments).ThenInclude(pc => pc.User).AsSplitQuery()
				.Include(p => p.User).ThenInclude(u => u.UserProfile).AsSplitQuery()
				.Include(p => p.Game).AsSplitQuery()
				.Sort();
			return PagedList<Posts>.ToPagedList(posts, postParameters.PageNumber, postParameters.PageSize, ct);
		}

		public async Task<Posts?> GetPostById(Guid postId, bool trackChange, CancellationToken ct = default) => await
			FindByCondition(p => p.Id.Equals(postId), trackChange)
			.Include(p => p.PostTags).ThenInclude(p => p.Tag).AsSplitQuery()
			.Include(p => p.PostImages).AsSplitQuery()
			.Include(p => p.PostReactions).AsSplitQuery()
			.Include(p => p.PostComments).ThenInclude(pc => pc.User).AsSplitQuery()
			.Include(p => p.User).ThenInclude(u => u.UserProfile).AsSplitQuery()
			.Include(p => p.Game).AsSplitQuery()
			.FirstOrDefaultAsync(ct);

		public async Task<PagedList<Posts>> GetPosts(PostParameters postParameters, bool trackChange, CancellationToken ct = default)
		{
			var posts = FindAll(trackChange)
				.Include(p => p.PostTags).ThenInclude(p => p.Tag).AsSplitQuery()
				.Include(p => p.PostImages).AsSplitQuery()
				.Include(p => p.PostReactions).AsSplitQuery()
				.Include(p => p.PostComments).ThenInclude(pc => pc.User).AsSplitQuery()
				.Include(p => p.User).ThenInclude(u => u.UserProfile).AsSplitQuery()
				.Include(p => p.Game).AsSplitQuery()
				.Sort();
			return await PagedList<Posts>.ToPagedList(posts, postParameters.PageNumber, postParameters.PageSize, ct);
		}

		public async Task<PagedList<Posts>> GetPostsByGameId(Guid gameId, PostParameters postParameters, bool trackChange, CancellationToken ct = default)
		{
			var posts = FindByCondition(p => p.GameId.Equals(gameId) && p.Status == PostStatus.Approved, trackChange)
				.Include(p => p.PostTags).ThenInclude(p => p.Tag).FilterByTags(postParameters.Tags).AsSplitQuery()
				.Include(p => p.PostImages).AsSplitQuery()
				.Include(p => p.PostReactions).AsSplitQuery()
				.Include(p => p.PostComments).ThenInclude(pc => pc.User).AsSplitQuery()
				.Include(p => p.User).ThenInclude(u => u.UserProfile).AsSplitQuery()
				.Include(p => p.Game).AsSplitQuery()
				.Sort();

			return await PagedList<Posts>.ToPagedList(posts, postParameters.PageNumber, postParameters.PageSize, ct);
		}

		public async Task<PagedList<Posts>> GetPostsByUserId(Guid userId, PostParameters postParameters, bool trackChange, CancellationToken ct = default)
		{
			var posts = FindByCondition(p => p.UserId.Equals(userId), trackChange)
				.Include(p => p.PostTags).ThenInclude(p => p.Tag).AsSplitQuery()
				.Include(p => p.PostImages).AsSplitQuery()
				.Include(p => p.PostReactions).AsSplitQuery()
				.Include(p => p.PostComments).ThenInclude(pc => pc.User).AsSplitQuery()
				.Include(p => p.User).ThenInclude(u => u.UserProfile).AsSplitQuery()
				.Include(p => p.Game).AsSplitQuery()
				.Sort();
			return await PagedList<Posts>.ToPagedList(posts, postParameters.PageNumber, postParameters.PageSize, ct);
		}

		public IQueryable<Posts> GetPostsByUserId(Guid userId, bool trackChange = false, CancellationToken ct = default) => FindByCondition(p => p.UserId.Equals(userId), trackChange);
	}
}
