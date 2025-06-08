using IndieGameZone.Domain.Entities;

namespace IndieGameZone.Domain.IRepositories
{
	public interface IPostTagRepository
	{
		void CreatePostTag(IEnumerable<PostTags> postTags);
		void DeletePostTag(IEnumerable<PostTags> postTags);
		Task<IEnumerable<PostTags>> GetPostTagsByPostId(Guid postId, bool trackChanges, CancellationToken ct = default);
	}
}
