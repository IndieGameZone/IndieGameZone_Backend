using IndieGameZone.Domain.Constants;
using IndieGameZone.Domain.RequestsAndResponses.Responses.AgeRestrictions;
using IndieGameZone.Domain.RequestsAndResponses.Responses.Categories;
using IndieGameZone.Domain.RequestsAndResponses.Responses.GameImages;
using IndieGameZone.Domain.RequestsAndResponses.Responses.GameLanguages;
using IndieGameZone.Domain.RequestsAndResponses.Responses.GamePlatforms;
using IndieGameZone.Domain.RequestsAndResponses.Responses.GameTags;
using IndieGameZone.Domain.RequestsAndResponses.Responses.Users;

namespace IndieGameZone.Domain.RequestsAndResponses.Responses.Games
{
	public class GameForSingleReturnDto
	{
		public Guid Id { get; init; }
		public string Name { get; init; }
		public string CoverImage { get; init; }
		public string VideoLink { get; init; }
		//public string InstallInstruction { get; init; }
		public string ShortDescription { get; init; }
		public string Description { get; init; }
		public double Price { get; init; }
		public double PriceAfterDiscount { get; set; }
		public double AverageSession { get; set; }
		public GameStatus Status { get; init; }
		public GameVisibility Visibility { get; set; }
		public CensorStatus CensorStatus { get; set; }
		public double NumberOfDownloads { get; set; }
		public double AverageRating { get; init; }
		public double NumberOfReviews { get; init; }
		public double Discount { get; init; }
		public virtual ICollection<GameTagForReturnDto> GameTags { get; init; }
		public virtual CategoryForReturnDto Category { get; init; }
		public DateTime CreatedAt { get; init; }
		public DateTime? CensoredAt { get; init; }
		public DateTime? UpdatedAt { get; init; }
		public string? CensorReason { get; init; }
		public virtual AgeRestrictionForReturnDto AgeRestriction { get; init; }
		public virtual ICollection<GamePlatformWithoutFileForReturnDto> GamePlatforms { get; init; }
		public virtual ICollection<GameLanguageForReturnDto> GameLanguages { get; init; }
		public virtual ICollection<GameImageForReturnDto> GameImages { get; init; }
		public virtual UserShortForReturnDto Developer { get; init; }
		public virtual UserShortForReturnDto? Moderator { get; init; }
	}
}
