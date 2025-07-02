using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndieGameZone.Domain.RequestsAndResponses.Responses.Games
{
    public class GameWithRatingDto
    {
        public GameForListReturnDto Game { get; set; } = null!;
        public double AverageRating { get; set; }
    }
}
