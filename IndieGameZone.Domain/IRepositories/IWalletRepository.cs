using IndieGameZone.Domain.Entities;
using IndieGameZone.Domain.RequestFeatures;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndieGameZone.Domain.IRepositories
{
    public interface IWalletRepository
    {
        //Task<PagedList<Wallets>> GetWallets(bool trackChange, CancellationToken ct = default);
        //Task<Wallets?> GetWalletById(Guid id, bool trackChange, CancellationToken ct = default);
        void CreateWallet(Wallets wallet);
        //void DeleteWallet(Wallets wallet);
    }
}
