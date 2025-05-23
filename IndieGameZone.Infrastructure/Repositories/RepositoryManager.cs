using IndieGameZone.Domain.IRepositories;
using IndieGameZone.Infrastructure.Persistence;
using Microsoft.EntityFrameworkCore.Storage;
using System.Data;

namespace IndieGameZone.Infrastructure.Repositories
{
	public sealed class RepositoryManager : IRepositoryManager
	{
		private readonly AppDbContext appDbContext;
		private readonly Lazy<ILanguageRepository> languageRepository;
		private readonly Lazy<ITagRepository> tagRepository;
		private readonly Lazy<ICategoryRepository> categoryRepository;

		public RepositoryManager(AppDbContext appDbContext)
		{
			this.appDbContext = appDbContext;
			languageRepository = new Lazy<ILanguageRepository>(() => new LanguageRepository(appDbContext));
			tagRepository = new Lazy<ITagRepository>(() => new TagRepository(appDbContext));
			categoryRepository = new Lazy<ICategoryRepository>(() => new CategoryRepository(appDbContext));
		}

		public ILanguageRepository LanguageRepository => languageRepository.Value;

		public ITagRepository TagRepository => tagRepository.Value;

		public ICategoryRepository CategoryRepository => categoryRepository.Value;

		public async Task<IDbTransaction> BeginTransaction(CancellationToken ct = default)
		{
			var transaction = await appDbContext.Database.BeginTransactionAsync(ct);
			return transaction.GetDbTransaction();
		}

		public Task SaveAsync(CancellationToken ct = default) => appDbContext.SaveChangesAsync(ct);
	}
}
