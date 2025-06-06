using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndieGameZone.Domain.RequestsAndResponses.Requests.Users
{
    public record UserForUpdateDto
    {
        [Required]
        public string Fullname { get; init; }
        public IFormFile? Avatar { get; init; }
        public string? Bio { get; init; }
        [Required]
        public DateOnly Birthday { get; init; }
        public string? FacebookLink { get; init; }
        public string? BankName { get; init; }
        public string? BankAccount { get; init; }

    }
}
