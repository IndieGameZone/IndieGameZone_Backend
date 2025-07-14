using IndieGameZone.Domain.RequestsAndResponses.Requests.Tags;
using IndieGameZone.Domain.RequestsAndResponses.Responses.Tags;

namespace IndieGameZone.Application.IServices
{
	public interface ITagService
	{
		Task<IEnumerable<TagForReturnDto>> GetTags(CancellationToken ct = default);
		Task<TagForReturnDto?> GetTagById(Guid id, CancellationToken ct = default);
		Task CreateTag(TagForCreationDto tagDto, CancellationToken ct = default);
		Task UpdateTag(Guid id, TagForUpdateDto tagDto, CancellationToken ct = default);
		Task DeleteTag(Guid id, CancellationToken ct = default);
	}
}
