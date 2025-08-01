using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndieGameZone.Domain.RequestsAndResponses.Responses.Users
{
    public record class UserForReturnDto
    {
        public Guid Id { get; init; }
        public string? UserName { get; init; }
        public string? Email { get; init; }
        public bool? EmailConfirmed { get; init; }
        public string? PhoneNumber { get; init; }
        public bool? PhoneNumberConfirmed { get; init; }
        public bool? TwoFactorEnabled { get; init; }
        public DateTimeOffset? LockoutEnd { get; init; }
        public bool? LockoutEnabled { get; init; }
        public bool? IsActive { get; init; }
        public DateTime? JoinedDate { get; init; }
        public DateTime? LastLogin { get; init; }
        public DateTime? LastUsernameChangedDate { get; init; }

        public string? Fullname { get; init; }
        public string? Avatar { get; init; }
        public string? Bio { get; init; }
        public DateOnly? Birthday { get; init; }
        public string? YoutubeChannelLink { get; init; }
        public string? FacebookLink { get; init; }
        public string? BankName { get; init; }
        public string? BankAccount { get; init; }
        public string? AccountName { get; init; }

        public double Balance { get; init; }

        public RoleForReturnDto? Role { get; set; }

    }
}
