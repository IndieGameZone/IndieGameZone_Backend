using IndieGameZone.Domain.Constants;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndieGameZone.Domain.RequestsAndResponses.Responses.CommercialPackages
{
    public class CommercialPackageForReturnDto
    {
        public Guid Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public double Duration { get; set; }
        public double Price { get; set; }
        public CommercialPackageType Type { get; set; }


    }
}
