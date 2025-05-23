using System.ComponentModel.DataAnnotations;

namespace IndieGameZone.Domain.RequestsAndResponses.Requests.Languages
{
	public class LanguageForCreationDto
	{
		[Required]
		public string Name { get; init; }
	}
}
