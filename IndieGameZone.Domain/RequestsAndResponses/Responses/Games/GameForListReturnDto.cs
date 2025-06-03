using IndieGameZone.Domain.Constants;
using IndieGameZone.Domain.RequestsAndResponses.Responses.Discounts;

namespace IndieGameZone.Domain.RequestsAndResponses.Responses.Games
{
	public class GameForListReturnDto
	{
		public Guid Id { get; init; }
		public string Name { get; init; }
		public string CoverImage { get; init; }
		public string Description { get; init; }
		public GameStatus Status { get; init; }
		public bool AllowDonation { get; init; }
		public double Price { get; init; }
		public double PriceAfterDiscount { get; set; }
		public virtual ICollection<DiscountForReturnDto> Discounts { get; init; }
	}
}
