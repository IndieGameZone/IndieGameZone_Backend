using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndieGameZone.Domain.RequestsAndResponses.Responses.Users
{
    public class BankInfoForReturnDto
    {
        public string? BankName { get; init; }
        public string? BankCode { get; init; }
        public string? BankBin { get; init; }
        public string? BankShortName { get; init; }

    }
}
