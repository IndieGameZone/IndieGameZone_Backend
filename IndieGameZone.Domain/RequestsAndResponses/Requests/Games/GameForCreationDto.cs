using IndieGameZone.Domain.RequestsAndResponses.Requests.GameInfos;
using IndieGameZone.Domain.RequestsAndResponses.Requests.GamePlatforms;
using Microsoft.AspNetCore.Http;

namespace IndieGameZone.Domain.RequestsAndResponses.Requests.Games
{
	public class GameForCreationDto
	{
		public string Name { get; init; }
		public IFormFile CoverImage { get; init; }
		public string VideoLink { get; init; }
		public double Price { get; init; }
		public double AverageSession { get; set; }
		public Guid AgeRestrictionId { get; init; }
		public Guid CategoryId { get; init; }
		public Guid GameStatusId { get; init; }
		public ICollection<Guid> LanguageIds { get; init; }
		public ICollection<Guid> TagIds { get; init; }
		public ICollection<GameInfoForCreationDto> GameInfos { get; init; }
		public ICollection<GamePlatformForCreationDto> GamePlatforms { get; init; }
	}
}
