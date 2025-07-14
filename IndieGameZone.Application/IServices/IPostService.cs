using IndieGameZone.Domain.RequestFeatures;
using IndieGameZone.Domain.RequestsAndResponses.Requests.Posts;
using IndieGameZone.Domain.RequestsAndResponses.Responses.Posts;

namespace IndieGameZone.Application.IServices
{
	public interface IPostService
	{
		Task CreatePost(Guid userId, Guid gameId, PostForCreationDto postForCreationDto, CancellationToken ct = default);
		Task UpdatePost(Guid userId, Guid postId, PostForUpdateDto postForUpdateDto, CancellationToken ct = default);
		Task DeletePost(Guid userId, Guid postId, CancellationToken ct = default);
		Task<(IEnumerable<PostForListReturnDto> posts, MetaData metaData)> GetPostsByGameId(Guid gameId, PostParameters postParameters, CancellationToken ct = default);
		Task<(IEnumerable<PostForListReturnDto> posts, MetaData metaData)> GetPostsByUserId(Guid userId, PostParameters postParameters, CancellationToken ct = default);
		Task<PostForSingleReturnDto> GetPostById(Guid postId, CancellationToken ct = default);
	}
}
