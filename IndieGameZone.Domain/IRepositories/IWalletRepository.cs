using IndieGameZone.Domain.Entities;

namespace IndieGameZone.Domain.IRepositories
{
	public interface IWalletRepository
	{
		//Task<PagedList<Wallets>> GetWallets(bool trackChange, CancellationToken ct = default);
		//Task<Wallets?> GetWalletById(Guid id, bool trackChange, CancellationToken ct = default);
		void CreateWallet(Wallets wallet);
		Task<Wallets?> GetWalletByUserId(Guid userId, bool trackChange, CancellationToken ct = default);
		//void DeleteWallet(Wallets wallet);
	}
}
