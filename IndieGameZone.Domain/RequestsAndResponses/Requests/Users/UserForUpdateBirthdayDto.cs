using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndieGameZone.Domain.RequestsAndResponses.Requests.Users
{
    public class UserForUpdateBirthdayDto
    {
        public DateOnly Birthday { get; set; }
    }
}
