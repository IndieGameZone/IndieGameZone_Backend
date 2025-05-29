using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndieGameZone.Domain.RequestsAndResponses.Responses.Users
{
    public record RoleForReturnDto
    {
        public string? Name { get; init; }
    }
}