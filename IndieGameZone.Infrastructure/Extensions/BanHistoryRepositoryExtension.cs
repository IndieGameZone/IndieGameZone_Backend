using IndieGameZone.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndieGameZone.Infrastructure.Extensions
{
    public static class BanHistoryRepositoryExtension
    {
        public static IQueryable<BanHistories> Sort(this IQueryable<BanHistories> source)
        {
            return source.OrderBy(a => a.BanDate);
        }
    }
}
