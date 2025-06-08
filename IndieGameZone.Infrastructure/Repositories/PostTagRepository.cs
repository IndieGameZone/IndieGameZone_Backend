using IndieGameZone.Domain.Entities;
using IndieGameZone.Domain.IRepositories;
using IndieGameZone.Infrastructure.Persistence;
using Microsoft.EntityFrameworkCore;

namespace IndieGameZone.Infrastructure.Repositories
{
	internal sealed class PostTagRepository : RepositoryBase<PostTags>, IPostTagRepository
	{
		private readonly AppDbContext appDbContext;
		public PostTagRepository(AppDbContext appDbContext) : base(appDbContext)
		{
			this.appDbContext = appDbContext;
		}
		public void CreatePostTag(IEnumerable<PostTags> postTags) => appDbContext.PostTags.AddRange(postTags);
		public void DeletePostTag(IEnumerable<PostTags> postTags) => appDbContext.PostTags.RemoveRange(postTags);
		public async Task<IEnumerable<PostTags>> GetPostTagsByPostId(Guid postId, bool trackChanges, CancellationToken ct = default) =>
			await FindByCondition(pt => pt.PostId.Equals(postId), trackChanges)
				.ToListAsync(ct);
	}
}
