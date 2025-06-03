using IndieGameZone.Domain.Constants;
using IndieGameZone.Domain.RequestsAndResponses.Responses.AgeRestrictions;
using IndieGameZone.Domain.RequestsAndResponses.Responses.Categories;
using IndieGameZone.Domain.RequestsAndResponses.Responses.Discounts;
using IndieGameZone.Domain.RequestsAndResponses.Responses.GameImages;
using IndieGameZone.Domain.RequestsAndResponses.Responses.GameLanguages;
using IndieGameZone.Domain.RequestsAndResponses.Responses.GamePlatforms;
using IndieGameZone.Domain.RequestsAndResponses.Responses.GameTags;

namespace IndieGameZone.Domain.RequestsAndResponses.Responses.Games
{
	public class GameForSingleReturnDto
	{
		public Guid Id { get; init; }
		public string Name { get; init; }
		public string CoverImage { get; init; }
		public string Description { get; init; }
		public bool IsActive { get; init; }
		public double Price { get; init; }
		public double PriceAfterDiscount { get; set; }
		public bool AllowDonation { get; init; }
		public GameStatus Status { get; init; }
		public virtual ICollection<GameTagForReturnDto> GameTags { get; init; }
		public virtual CategoryForReturnDto Category { get; init; }
		public virtual AgeRestrictionForReturnDto AgeRestriction { get; set; }
		public virtual ICollection<GamePlatformForReturnDto> GamePlatforms { get; init; }
		public virtual ICollection<GameLanguageForReturnDto> GameLanguages { get; init; }
		public virtual ICollection<GameImageForReturnDto> GameImages { get; init; }
		public virtual ICollection<DiscountForReturnDto> Discounts { get; init; }
	}
}
