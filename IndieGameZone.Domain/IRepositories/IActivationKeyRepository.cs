using IndieGameZone.Domain.Entities;

namespace IndieGameZone.Domain.IRepositories
{
	public interface IActivationKeyRepository
	{
		void Create(ActivationKeys activationKey);
		void CreateRange(IEnumerable<ActivationKeys> activationKeys);
		Task<ActivationKeys?> GetByKey(string key, bool trackChange, CancellationToken ct = default);
		Task<IEnumerable<ActivationKeys>> GetByGameId(Guid gameId, bool trackChange, CancellationToken ct = default);
	}
}
