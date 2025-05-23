using IndieGameZone.Domain.Entities;

namespace IndieGameZone.Domain.IRepositories
{
	public interface ITagRepository
	{
		Task<IEnumerable<Tags>> GetTags(bool trackChange, CancellationToken ct = default);
		Task<Tags?> GetTagById(Guid id, bool trackChange, CancellationToken ct = default);
		void CreateTag(Tags tag);
		void DeleteTag(Tags tag);
	}
}
