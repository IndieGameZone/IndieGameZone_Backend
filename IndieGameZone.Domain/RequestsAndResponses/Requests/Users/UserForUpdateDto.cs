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
        public string? Fullname { get; init; }
        public string? Avatar { get; init; }
        public string? Bio { get; init; }
        public DateOnly? Birthday { get; init; }
        public string? YoutubeChannelLink { get; init; }
        public string? FacebookLink { get; init; }

    }
}
