using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndieGameZone.Domain.RequestsAndResponses.Requests.Users
{
    public record UserForResetPasswordDto
    {
        [Required]
        [EmailAddress]
        public string Email { get; init; }
        [Required]
        public string OTP { get; init; }
        [Required]
        public string Password { get; init; }
        [Required]
        [Compare("Password")]
        public string ConfirmPassword { get; init; }
    }
}
