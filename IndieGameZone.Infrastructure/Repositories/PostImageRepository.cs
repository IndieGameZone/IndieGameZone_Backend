using IndieGameZone.Domain.Entities;
using IndieGameZone.Domain.IRepositories;
using IndieGameZone.Infrastructure.Persistence;
using Microsoft.EntityFrameworkCore;

namespace IndieGameZone.Infrastructure.Repositories
{
	internal sealed class PostImageRepository : RepositoryBase<PostImages>, IPostImageRepository
	{
		public PostImageRepository(AppDbContext appDbContext) : base(appDbContext)
		{
		}

		public void CreatePostImages(IEnumerable<PostImages> postImages) => CreateRange(postImages);

		public void DeletePostImages(IEnumerable<PostImages> postImages) => DeleteRange(postImages);

		public async Task<IEnumerable<PostImages>> GetPostImagesByPostId(Guid postId, bool trackChanges, CancellationToken ct = default) => await FindByCondition(x => x.PostId == postId, trackChanges)
				.ToListAsync(ct);
	}
}
