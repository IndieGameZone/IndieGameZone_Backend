using IndieGameZone.Domain.Entities;

namespace IndieGameZone.Domain.IRepositories
{
	public interface IDiscountRepository
	{
		void CreateDiscount(Discounts discount);
		Task<Discounts?> GetActiveDiscountByGameId(Guid gameId, bool trackChange, CancellationToken ct = default);
	}
}
