using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndieGameZone.Domain.Exceptions
{
    public sealed class RequestTokenBadRequest : BadRequestException
    {
        public RequestTokenBadRequest() : base("Invalid request. The token has some invalid values.")
        {
        }
    }
}
