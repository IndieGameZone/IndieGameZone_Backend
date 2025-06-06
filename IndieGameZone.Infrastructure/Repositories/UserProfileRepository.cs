using IndieGameZone.Domain.Entities;
using IndieGameZone.Domain.IRepositories;
using IndieGameZone.Infrastructure.Persistence;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndieGameZone.Infrastructure.Repositories
{
    internal sealed class UserProfileRepository : RepositoryBase<UserProfiles>, IUserProfileRepository
    {
        public UserProfileRepository(AppDbContext appDbContext) : base(appDbContext)
        {
        }

        public async Task<UserProfiles?> GetUserProfileById(Guid id, bool trackChange, CancellationToken ct = default) => await FindByCondition(a => a.UserId.Equals(id), trackChange)
    .SingleOrDefaultAsync(ct);

        public void CreateUserProfile(UserProfiles userProfile) => Create(userProfile);

    }
}
