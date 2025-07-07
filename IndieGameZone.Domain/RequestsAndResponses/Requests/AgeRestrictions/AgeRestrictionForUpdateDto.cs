using System.ComponentModel.DataAnnotations;

namespace IndieGameZone.Domain.RequestsAndResponses.Requests.AgeRestrictions
{
	public class AgeRestrictionForUpdateDto
	{
		[Required]
		public string Code { get; init; }
		[Required]
		public string Description { get; init; }
	}
}
