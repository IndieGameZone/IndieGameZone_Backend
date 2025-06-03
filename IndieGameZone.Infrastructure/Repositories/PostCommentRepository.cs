using IndieGameZone.Domain.Entities;
using IndieGameZone.Domain.IRepositories;
using IndieGameZone.Domain.RequestFeatures;
using IndieGameZone.Infrastructure.Extensions;
using IndieGameZone.Infrastructure.Persistence;
using Microsoft.EntityFrameworkCore;

namespace IndieGameZone.Infrastructure.Repositories
{
	internal sealed class PostCommentRepository : RepositoryBase<PostComments>, IPostCommentRepository
	{
		public PostCommentRepository(AppDbContext appDbContext) : base(appDbContext)
		{
		}

		public void CreateComment(PostComments comment) => Create(comment);

		public void DeleteComment(PostComments comment) => Delete(comment);

		public async Task<PostComments?> GetCommentById(Guid commentId, bool trackChange, CancellationToken ct = default) => await FindByCondition(c => c.Id.Equals(commentId), trackChange).FirstOrDefaultAsync(ct);

		public async Task<PagedList<PostComments>> GetCommentsByPostId(Guid postId, PostCommentParameters postCommentParameters, bool trackChange, CancellationToken ct = default)
		{
			var comments = FindByCondition(c => c.PostId.Equals(postId) && c.IsActive, trackChange)
				.Sort();

			return await PagedList<PostComments>.ToPagedList(comments, postCommentParameters.PageNumber, postCommentParameters.PageSize, ct);
		}
	}
}
