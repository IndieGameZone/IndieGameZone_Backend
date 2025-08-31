using System.ComponentModel.DataAnnotations;

namespace IndieGameZone.Domain.RequestsAndResponses.Requests.Discounts
{
	public class DiscountForCreationDto
	{
		[Required]
		public double Percentage { get; init; }
		[Required]
		public DateOnly EndDate { get; init; }
	}
}
