using IndieGameZone.Domain.Constants;

namespace IndieGameZone.Domain.RequestsAndResponses.Requests.Games
{
	public class GameForUpdateDto
	{
		public string Name { get; init; }
		public string CoverImage { get; init; }
		public string? VideoLink { get; init; }
		public string Description { get; init; }
		public string ShortDescription { get; init; }
		public string InstallInstruction { get; init; }
		public bool AllowDonation { get; init; }
		public GameStatus Status { get; init; }
		public GameVisibility Visibility { get; init; }
		public double Price { get; init; }
		public double AverageSession { get; set; }
		public Guid AgeRestrictionId { get; init; }
		public Guid CategoryId { get; init; }
		public ICollection<Guid> LanguageIds { get; init; }
		public ICollection<Guid> TagIds { get; init; }
	}
}
