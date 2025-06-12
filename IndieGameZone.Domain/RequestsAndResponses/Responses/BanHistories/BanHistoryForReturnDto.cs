using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndieGameZone.Domain.RequestsAndResponses.Responses.BanHistories
{
    public class BanHistoryForReturnDto
    {
        public Guid Id { get; init; }
        public DateTime BanDate { get; init; }
        public DateTime UnbanDate { get; init; }
        public string Reason { get; init; } = string.Empty;
        public Guid UserId { get; init; }
    }
}
