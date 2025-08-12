using IndieGameZone.Domain.RequestsAndResponses.Responses.PostImages;
using IndieGameZone.Domain.RequestsAndResponses.Responses.PostTags;
using IndieGameZone.Domain.RequestsAndResponses.Responses.Users;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndieGameZone.Domain.RequestsAndResponses.Responses.Posts
{
    public class PostWithoutGameForReturnDto
    {
        public Guid Id { get; init; }
        public string Title { get; init; }
        public string Content { get; init; }
        public ICollection<PostImageForReturnDto> PostImages { get; init; }
        public ICollection<PostTagForReturnDto> PostTags { get; init; }
        public int NumberOfComments { get; init; }
        public int NumberOfLikes { get; init; }
        public DateTime CreatedAt { get; init; }
        public UserShortForReturnDto User { get; init; }
    }
}
