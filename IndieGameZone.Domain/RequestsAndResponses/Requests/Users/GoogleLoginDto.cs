using IndieGameZone.Domain.Constants;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndieGameZone.Domain.RequestsAndResponses.Requests.Users
{
    public class GoogleLoginDto
    {
        [Required]
        public string IdToken { get; set; } = string.Empty;
        public DateOnly? Birthday { get; init; }
        [EnumDataType(typeof(RoleEnum))]
        public RoleEnum? Role { get; init; }
    }
}
