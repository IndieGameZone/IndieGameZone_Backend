using IndieGameZone.Domain.RequestsAndResponses.Responses.Categories;
using IndieGameZone.Domain.RequestsAndResponses.Responses.Discounts;
using IndieGameZone.Domain.RequestsAndResponses.Responses.GameTags;

namespace IndieGameZone.Domain.RequestsAndResponses.Responses.Games
{
	public class GameForListReturnDto
	{
		public Guid Id { get; init; }
		public string Name { get; init; }
		public string CoverImage { get; init; }
		public double Price { get; init; }
		public double PriceAfterDiscount { get; set; }
		public string ShortDescription { get; init; }
		public virtual ICollection<DiscountForReturnDto> Discounts { get; init; }
		public virtual ICollection<GameTagForReturnDto> GameTags { get; set; }
		public virtual CategoryForReturnDto Category { get; init; }
	}
}
