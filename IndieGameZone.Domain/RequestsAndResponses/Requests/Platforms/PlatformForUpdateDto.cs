using System.ComponentModel.DataAnnotations;

namespace IndieGameZone.Domain.RequestsAndResponses.Requests.Platforms
{
	public class PlatformForUpdateDto
	{
		[Required]
		public string Name { get; init; }
		[Required]
		public double Size { get; init; }
	}
}
