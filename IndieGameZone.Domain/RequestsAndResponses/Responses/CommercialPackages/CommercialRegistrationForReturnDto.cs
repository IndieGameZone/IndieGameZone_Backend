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
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public Guid GameId { get; set; }
        public Guid CommercialPackageId { get; set; }
    }
}
