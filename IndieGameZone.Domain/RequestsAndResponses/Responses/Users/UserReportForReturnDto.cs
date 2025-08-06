using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndieGameZone.Domain.RequestsAndResponses.Responses.Users
{
    public class UserReportForReturnDto
    {
        public Guid Id { get; init; }
        public string? UserName { get; init; }
        public string? Email { get; init; }
        public string? Fullname { get; init; }
        public string? Avatar { get; init; }

    }
}
