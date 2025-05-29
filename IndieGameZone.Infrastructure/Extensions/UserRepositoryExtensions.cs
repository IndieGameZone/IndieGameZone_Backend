using IndieGameZone.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndieGameZone.Infrastructure.Extensions
{
    public static class UserRepositoryExtensions
    {
        public static IQueryable<Users> Search(this IQueryable<Users> users, string searchTerm)
        {
            if (string.IsNullOrWhiteSpace(searchTerm)) return users;
            var lowerCaseSearchTerm = searchTerm.Trim().ToLower();
            return users.Where(u => u.UserName!.ToLower().Contains(lowerCaseSearchTerm));
        }

        public static IQueryable<Users> Sort(this IQueryable<Users> users)
        {
            return users.OrderBy(u => u.UserName!);
        }
    }
}
