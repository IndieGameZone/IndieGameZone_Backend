using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndieGameZone.Domain.RequestsAndResponses.Requests.Users
{
    public record UserForUpdatePasswordDto
    {
        [Required]
        public string CurrentPassword { get; init; }
        [Required]
        public string NewPassword { get; init; }
        [Required]
        [Compare("NewPassword")]
        public string ConfirmPassword { get; init; }
    }
}
