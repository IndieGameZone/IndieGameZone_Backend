using IndieGameZone.Domain.Entities;
using IndieGameZone.Domain.RequestFeatures;

namespace IndieGameZone.Domain.IRepositories
{
	public interface ITagRepository
	{
		Task<IEnumerable<Tags>> GetTags(TagParameters tagParameters, bool trackChange, CancellationToken ct = default);
		Task<Tags?> GetTagById(Guid id, bool trackChange, CancellationToken ct = default);
		void CreateTag(Tags tag);
		void DeleteTag(Tags tag);
	}
}
