using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndieGameZone.Domain.RequestsAndResponses.Requests.Users
{
    public record UserForUpdateUsernameDto
    {
        [Required]
        public string NewUsername { get; init; }
    }
}
