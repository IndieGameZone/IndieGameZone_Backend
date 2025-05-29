using IndieGameZone.Domain.Entities;
using IndieGameZone.Domain.RequestFeatures;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndieGameZone.Domain.IRepositories
{
    public interface IUserRepository
    {
        Task<PagedList<Users>> GetUsers(UserParameters userParameters, bool trackChange, CancellationToken ct = default);
    }
}
