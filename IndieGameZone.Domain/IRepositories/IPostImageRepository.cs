using IndieGameZone.Domain.Entities;

namespace IndieGameZone.Domain.IRepositories
{
	public interface IPostImageRepository
	{
		void CreatePostImages(IEnumerable<PostImages> postImages);
		void DeletePostImages(IEnumerable<PostImages> postImages);
		Task<IEnumerable<PostImages>> GetPostImagesByPostId(Guid postId, bool trackChanges, CancellationToken ct = default);
	}
}
