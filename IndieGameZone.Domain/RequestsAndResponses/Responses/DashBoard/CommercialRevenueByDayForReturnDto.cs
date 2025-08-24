using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndieGameZone.Domain.RequestsAndResponses.Responses.DashBoard
{
    public class AdminRevenueByDayForReturnDto
    {
        public int Day { get; set; }
        public double CommercialRevenue { get; set; }
        public double GameRevenue { get; set; }

    }
}
