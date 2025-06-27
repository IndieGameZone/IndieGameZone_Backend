using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndieGameZone.Domain.RequestsAndResponses.Requests.BanHistories
{
    public class BanHistoryForCreationDto
    {
        [Required]
        public DateTime UnbanDate { get; init; }
        [Required]
        public string Reason { get; init; } = string.Empty;
        [Required]
        public Guid UserId { get; init; }
    }
}
