using IndieGameZone.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndieGameZone.Infrastructure.Extensions
{
    public static class CommercialPackageRepositoryExtension
    {
        public static IQueryable<CommercialPackages> Sort(this IQueryable<CommercialPackages> source)
        {
            return source.OrderBy(a => a.Name);
        }
    }
}
