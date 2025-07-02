using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndieGameZone.Domain.RequestsAndResponses.Responses.Games
{
    public class GameWithSalesDto
    {
        public GameForListReturnDto Game { get; set; }
        public int PurchaseCount { get; set; }
    }
}
