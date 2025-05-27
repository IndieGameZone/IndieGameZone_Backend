using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndieGameZone.Domain.RequestsAndResponses.Requests.Users
{
    public class UserForAuthenticationDto
    {
        public string? UserNameOrEmail { get; init; }
        public string? Password { get; init; }
    }
}
