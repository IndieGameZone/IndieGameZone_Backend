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
		Task UpdatePostStatus(Guid postId, PostActivationDto postActivationDto, CancellationToken ct = default);
		Task<(IEnumerable<PostForReturnDto> posts, MetaData metaData)> GetPostsByGameId(Guid gameId, PostParameters postParameters, CancellationToken ct = default);
		Task<(IEnumerable<PostForReturnDto> posts, MetaData metaData)> GetPostsByUserId(Guid userId, PostParameters postParameters, CancellationToken ct = default);
		Task<(IEnumerable<PostForReturnDto> posts, MetaData metaData)> GetActivePostsByUserId(Guid userId, PostParameters postParameters, CancellationToken ct = default);
		Task<(IEnumerable<PostForReturnDto> posts, MetaData metaData)> GetPosts(PostParameters postParameters, CancellationToken ct = default);
		Task<PostForReturnDto> GetPostById(Guid postId, CancellationToken ct = default);
	}
}
