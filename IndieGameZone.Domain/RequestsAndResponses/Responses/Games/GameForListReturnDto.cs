using IndieGameZone.Domain.Constants;
using IndieGameZone.Domain.RequestsAndResponses.Responses.Categories;
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
		public CensorStatus CensorStatus { get; init; }
		public DateTime CreatedAt { get; init; }
		public DateTime? CensoredAt { get; init; }
		public DateTime? UpdatedAt { get; init; }
		public double AverageRating { get; init; }
		public double NumberOfReviews { get; init; }
		public double Discount { get; init; }
		public virtual ICollection<GameTagForReturnDto> GameTags { get; init; }
		public virtual CategoryForReturnDto Category { get; init; }
	}
}
