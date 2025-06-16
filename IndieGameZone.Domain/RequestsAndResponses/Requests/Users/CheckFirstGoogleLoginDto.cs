using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndieGameZone.Domain.RequestsAndResponses.Requests.Users
{
    public class CheckFirstGoogleLoginDto
    {
        [Required]
        public string IdToken { get; set; } = string.Empty;

    }
}
