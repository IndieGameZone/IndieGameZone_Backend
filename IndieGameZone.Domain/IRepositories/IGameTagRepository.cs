using IndieGameZone.Domain.Entities;

namespace IndieGameZone.Domain.IRepositories
{
	public interface IGameTagRepository
	{
		void CreateGameTag(IEnumerable<GameTags> gameTags);
	}
}
