using IndieGameZone.Domain.RequestsAndResponses.Responses.AgeRestrictions;
using IndieGameZone.Domain.RequestsAndResponses.Responses.Categories;
using IndieGameZone.Domain.RequestsAndResponses.Responses.GameInfos;
using IndieGameZone.Domain.RequestsAndResponses.Responses.GameLanguages;
using IndieGameZone.Domain.RequestsAndResponses.Responses.GamePlatforms;
using IndieGameZone.Domain.RequestsAndResponses.Responses.GameStatuses;
using IndieGameZone.Domain.RequestsAndResponses.Responses.GameTags;

namespace IndieGameZone.Domain.RequestsAndResponses.Responses.Games
{
	public class GameForSingleReturnDto
	{
		public Guid Id { get; init; }
		public string Name { get; init; }
		public string CoverImage { get; init; }
		public bool IsActive { get; init; }
		public double Price { get; init; }
		public virtual ICollection<GameTagForReturnDto> GameTags { get; init; }
		public virtual CategoryForReturnDto Category { get; init; }
		public virtual AgeRestrictionForReturnDto AgeRestriction { get; set; }
		public virtual ICollection<GamePlatformForReturnDto> GamePlatforms { get; init; }
		public virtual ICollection<GameLanguageForReturnDto> GameLanguages { get; init; }
		public virtual GameStatusForReturnDto GameStatus { get; init; }
		public virtual ICollection<GameInfoForReturnDto> GameInfos { get; init; }
	}
}
