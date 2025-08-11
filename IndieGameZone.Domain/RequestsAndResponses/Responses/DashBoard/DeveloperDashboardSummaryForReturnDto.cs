using IndieGameZone.Domain.RequestsAndResponses.Responses.Games;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndieGameZone.Domain.RequestsAndResponses.Responses.DashBoard
{
    public class DeveloperDashboardSummaryForReturnDto
    {
        public double TotalRevenueAllTime { get; set; }
        public double TotalDonationAllTime { get; set; }
        public Dictionary<string, double> RevenueByMonth { get; set; } = new(); // key = "yyyy-MM"
        public IEnumerable<GameWithDownloadsDto> Top5BestDownloadedGames { get; set; } = new List<GameWithDownloadsDto>();

    }
}
