using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndieGameZone.Domain.RequestsAndResponses.Responses.DashBoard
{
    public class GameDashboardSummaryForReturnDto
    {
        public double TotalRevenueAllTime { get; set; }
        public double TotalDonationAllTime { get; set; }
        public Dictionary<string, double> RevenueByMonth { get; set; } = new();
        public int TotalDownloadsAllTime { get; set; }
    }
}
