using IndieGameZone.Domain.Constants;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndieGameZone.Domain.RequestsAndResponses.Requests.CommercialPackages
{
    public class CommercialPackageForCreationDto
    {
        [Required]
        public string Name { get; init; }
        [Required]
        public string Description { get; init; }
        [Required]
        public double Duration { get; init; }
        [Required]
        public double Price { get; init; }
        [Required]
        public CommercialPackageType Type { get; init; }

    }
}
