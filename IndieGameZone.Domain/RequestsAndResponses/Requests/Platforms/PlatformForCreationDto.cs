using System.ComponentModel.DataAnnotations;

namespace IndieGameZone.Domain.RequestsAndResponses.Requests.Platforms
{
	public class PlatformForCreationDto
	{
		[Required]
		public string Name { get; init; }
	}
}
