using IndieGameZone.Domain.Constants;
using System.ComponentModel.DataAnnotations;

namespace IndieGameZone.Domain.RequestsAndResponses.Requests.Games
{
	public class GameForUpdateDto
	{
		[Required]
		public string Name { get; init; }
		[Required]
		public string CoverImage { get; init; }
		public string? VideoLink { get; init; }
		[Required]
		public string Description { get; init; }
		[Required]
		public string ShortDescription { get; init; }
		[Required]
		public string InstallInstruction { get; init; }
		public string? VersionDescription { get; init; }
		[Required]
		public bool AllowDonation { get; init; }
		[Required]
		public bool RequireActivationKey { get; init; }
		[Required]
		public GameStatus Status { get; init; }
		[Required]
		public GameVisibility Visibility { get; init; }
		[Required]
		[Range(0, double.MaxValue, ErrorMessage = "Amount must be atleast 0.")]
		public double Price { get; init; }
		[Required]
		public double AverageSession { get; set; }
		[Required]
		public Guid AgeRestrictionId { get; init; }
		[Required]
		public Guid CategoryId { get; init; }
		[Required]
		public ICollection<Guid> LanguageIds { get; init; }
		[Required]
		public ICollection<Guid> TagIds { get; init; }
	}
}
