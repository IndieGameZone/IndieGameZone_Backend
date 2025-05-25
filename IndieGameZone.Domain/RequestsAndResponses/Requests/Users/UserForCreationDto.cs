using IndieGameZone.Domain.Constants;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndieGameZone.Domain.RequestsAndResponses.Requests.Users
{
    public class UserForCreationDto
    {
        [EmailAddress]
        [Required]
        public string Email { get; init; }
        [Required]
        [RegularExpression(@"^[A-Za-z][A-Za-z0-9]{5,}$", ErrorMessage = "Username must be at least 5 characters long, contain only letters and numbers and must start with a letter.")]
        public string UserName { get; init; }
        [Required]
        public DateOnly Birthday { get; init; }
        [Required]
        [RegularExpression(@"^[A-Za-z0-9]{5,}$", ErrorMessage = "Password must be at least 5 characters long and contain only letters and numbers.")]
        public string Password { get; init; }
        [Required]
        [Compare("Password")]
        public string ConfirmPassword { get; init; }
        [Required]
        [EnumDataType(typeof(RoleEnum))]
        public RoleEnum Role { get; init; }
    }
}
