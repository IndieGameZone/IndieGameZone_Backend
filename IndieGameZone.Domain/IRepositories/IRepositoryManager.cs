using System.Data;

namespace IndieGameZone.Domain.IRepositories
{
	public interface IRepositoryManager
	{
		Task SaveAsync(CancellationToken ct = default);
		Task<IDbTransaction> BeginTransaction(CancellationToken ct = default);
		ILanguageRepository LanguageRepository { get; }
		ITagRepository TagRepository { get; }
		ICategoryRepository CategoryRepository { get; }
		IPlatformRepository PlatformRepository { get; }
		IGameStatusRepository GameStatusRepository { get; }
	}
}
