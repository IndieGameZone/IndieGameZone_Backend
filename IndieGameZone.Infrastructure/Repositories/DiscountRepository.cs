using IndieGameZone.Domain.Entities;
using IndieGameZone.Domain.IRepositories;
using IndieGameZone.Infrastructure.Persistence;

namespace IndieGameZone.Infrastructure.Repositories
{
	internal sealed class DiscountRepository : RepositoryBase<Discounts>, IDiscountRepository
	{
		public DiscountRepository(AppDbContext appDbContext) : base(appDbContext)
		{
		}

		public void CreateDiscount(Discounts discount) => Create(discount);
	}
}
