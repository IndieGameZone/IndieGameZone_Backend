using IndieGameZone.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndieGameZone.Infrastructure.Extensions
{
    public static class CommercialRegistrationRepositoryExtension
    {
        public static IQueryable<CommercialRegistrations> Sort(this IQueryable<CommercialRegistrations> source)
        {
            return source.OrderBy(a => a.StartDate);
        }
    }
}
