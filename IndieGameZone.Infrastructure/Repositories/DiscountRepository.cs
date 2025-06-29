using IndieGameZone.Domain.Entities;
using IndieGameZone.Domain.IRepositories;
using IndieGameZone.Infrastructure.Persistence;
using Microsoft.EntityFrameworkCore;

namespace IndieGameZone.Infrastructure.Repositories
{
	internal sealed class DiscountRepository : RepositoryBase<Discounts>, IDiscountRepository
	{
		public DiscountRepository(AppDbContext appDbContext) : base(appDbContext)
		{
		}

		public void CreateDiscount(Discounts discount) => Create(discount);

		public async Task<Discounts?> GetActiveDiscountByGameId(Guid gameId, bool trackChange, CancellationToken ct = default) => await
			FindByCondition(d => d.GameId == gameId && DateOnly.FromDateTime(DateTime.Now) <= d.EndDate, trackChange)
			.FirstOrDefaultAsync(ct);
	}
}
