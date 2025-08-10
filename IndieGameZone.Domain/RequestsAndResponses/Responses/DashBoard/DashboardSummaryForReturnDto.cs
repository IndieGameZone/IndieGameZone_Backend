using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndieGameZone.Domain.RequestsAndResponses.Responses.DashBoard
{
    public class DashboardSummaryForReturnDto
    {
        public int OnlineUserCount { get; set; }
        public int TotalUserCount { get; set; }
        public double GamePurchaseRevenueByDeveloper { get; set; }
        public double GamePurchaseRevenueByAdmin { get; set; }
        public double CommercialPackageRevenue { get; set; }
    }
}
