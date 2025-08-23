using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndieGameZone.Domain.RequestsAndResponses.Responses.DashBoard
{
    public class NewPlayersByMonthForReturnDto
    {
        public int Month { get; set; }
        public int Count { get; set; }
    }
}
