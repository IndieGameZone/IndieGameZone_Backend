using System.ComponentModel.DataAnnotations;

namespace IndieGameZone.Domain.RequestsAndResponses.Requests.Languages
{
	public class LanguageForUpdateDto
	{
		[Required]
		public string Name { get; init; }
	}
}
