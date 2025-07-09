using IndieGameZone.Domain.Constants;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndieGameZone.Domain.RequestsAndResponses.Responses.CommercialPackages
{
    public class CommercialRegistrationForReturnDto
    {
        public Guid Id { get; set; }
        public DateOnly StartDate { get; set; }
        public DateOnly EndDate { get; set; }
        public DateTime CreatedAt { get; set; }
        public GameVisibility Visibility { get; set; }
        public Guid GameId { get; set; }
        public Guid CommercialPackageId { get; set; }
        public Guid TransactionId { get; set; }

    }
}
