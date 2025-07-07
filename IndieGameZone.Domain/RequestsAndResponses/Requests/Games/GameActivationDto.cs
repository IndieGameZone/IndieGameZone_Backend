using IndieGameZone.Domain.Constants;
using System.ComponentModel.DataAnnotations;

namespace IndieGameZone.Domain.RequestsAndResponses.Requests.Games
{
	public class GameActivationDto
	{
		[Required]
		public CensorStatus CensorStatus { get; init; }
		public string? CensorReason { get; init; }
	}
}
