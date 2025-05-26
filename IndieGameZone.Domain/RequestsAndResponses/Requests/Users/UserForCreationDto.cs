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
        public required string Email { get; init; }
        [Required]
        [RegularExpression(@"^[A-Za-z][A-Za-z0-9]{4,}$", ErrorMessage = "Username must be at least 5 characters long, contain only letters and numbers and must start with a letter.")]
        public required string UserName { get; init; }
        [Required]
        public required DateOnly Birthday { get; init; }
        [Required]
        [RegularExpression(@"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*[^A-Za-z\d])[^\s]{12,}$", ErrorMessage = "Password must be at least 12 characters long and include uppercase, lowercase, number, and special character.")]
        public required string Password { get; init; }
        [Required]
        [Compare("Password")]
        public required string ConfirmPassword { get; init; }
        [Required]
        [EnumDataType(typeof(RoleEnum))]
        public RoleEnum Role { get; init; }
    }
}
