using System.Data;

namespace IndieGameZone.Domain.Repositories
{
	public interface IRepositoryManager
	{
		Task SaveAsync(CancellationToken ct = default);
		Task<IDbTransaction> BeginTransaction(CancellationToken ct = default);
	}
}
