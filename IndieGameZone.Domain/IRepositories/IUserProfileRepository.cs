using IndieGameZone.Domain.Entities;
using IndieGameZone.Domain.RequestFeatures;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndieGameZone.Domain.IRepositories
{
    public interface IUserProfileRepository
    {
        Task<UserProfiles?> GetUserProfileById(Guid id, bool trackChange, CancellationToken ct = default);
        void CreateUserProfile(UserProfiles userProfile);
        Task<int> CountUsersPingedAfter(DateTime threshold, CancellationToken ct = default);
    }
}
