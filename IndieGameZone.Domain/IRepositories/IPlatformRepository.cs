using IndieGameZone.Domain.Entities;

namespace IndieGameZone.Domain.IRepositories
{
	public interface IPlatformRepository
	{
		Task<IEnumerable<Platforms>> GetPlatforms(bool trackChange, CancellationToken ct = default);
		Task<Platforms?> GetPlatformById(Guid id, bool trackChange, CancellationToken ct = default);
		void CreatePlatform(Platforms platform);
		void DeletePlatform(Platforms platform);
	}
}
