using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndieGameZone.Domain.RequestsAndResponses.Responses.DashBoard
{
    public class GameMonthlyStatsByDayForReturnDto
    {
        public int Day { get; set; }               
        public double Revenue { get; set; }        
        public int DownloadCount { get; set; }     
    }
}
