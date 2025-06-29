using IndieGameZone.Domain.Constants;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndieGameZone.Domain.RequestsAndResponses.Requests.Transactions
{
    public class TransactionForCommercialDto
    {
        [Required]
        public Guid GameId { get; init; }
        [Required]
        public DateTime StartDate { get; init; }
        [Required]
        public DateTime EndDate { get; init; }
        [Required]
        public PaymentMethod PaymentMethod { get; init; }
    }
}
