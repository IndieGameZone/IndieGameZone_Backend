using IndieGameZone.Domain.IRepositories;
using IndieGameZone.Infrastructure.Persistence;
using Microsoft.EntityFrameworkCore.Storage;
using System.Data;

namespace IndieGameZone.Infrastructure.Repositories
{
	public sealed class RepositoryManager : IRepositoryManager
	{
		private readonly RepositoryContext repositoryContext;

		public RepositoryManager(RepositoryContext repositoryContext)
		{
			this.repositoryContext = repositoryContext;
		}
		public async Task<IDbTransaction> BeginTransaction(CancellationToken ct = default)
		{
			var transaction = await repositoryContext.Database.BeginTransactionAsync(ct);
			return transaction.GetDbTransaction();
		}

		public Task SaveAsync(CancellationToken ct = default) => repositoryContext.SaveChangesAsync(ct);
	}
}
