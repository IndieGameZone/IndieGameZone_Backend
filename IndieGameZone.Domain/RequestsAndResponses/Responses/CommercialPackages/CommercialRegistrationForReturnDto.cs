using IndieGameZone.Domain.Constants;
using IndieGameZone.Domain.RequestsAndResponses.Responses.Users;
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
        public CommercialRegistrationStatus Status { get; set; }
        public GameVisibility Visibility { get; set; }
        public Guid GameId { get; set; }
        public string GameName { get; set; } = string.Empty;

        public Guid CommercialPackageId { get; set; }
        public string CommercialPackageName { get; set; } = string.Empty;
        public double Price { get; set; }
        public int Duration { get; set; }

        public UserShortForReturnDto Developer { get; set; } = new UserShortForReturnDto();

    }
}
