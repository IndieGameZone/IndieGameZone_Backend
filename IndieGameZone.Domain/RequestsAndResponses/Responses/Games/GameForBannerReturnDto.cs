using IndieGameZone.Domain.Constants;
using IndieGameZone.Domain.RequestsAndResponses.Responses.Categories;
using IndieGameZone.Domain.RequestsAndResponses.Responses.GameImages;
using IndieGameZone.Domain.RequestsAndResponses.Responses.GameTags;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndieGameZone.Domain.RequestsAndResponses.Responses.Games
{
    public class GameForBannerReturnDto
    {
        public Guid Id { get; init; }
        public string Name { get; init; }
        public string CoverImage { get; init; }
        public double Price { get; init; }
        public double PriceAfterDiscount { get; set; }
        public string ShortDescription { get; init; }
        public double Discount { get; init; }
        public virtual ICollection<GameTagForReturnDto> GameTags { get; init; }
        public virtual CategoryForReturnDto Category { get; init; }
        public virtual ICollection<GameImageForReturnDto> GameImages { get; init; }

    }
}
