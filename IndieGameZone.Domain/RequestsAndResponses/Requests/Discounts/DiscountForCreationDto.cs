namespace IndieGameZone.Domain.RequestsAndResponses.Requests.Discounts
{
	public class DiscountForCreationDto
	{
		public double Percentage { get; init; }
		public DateOnly StartDate { get; init; }
		public DateOnly EndDate { get; init; }
	}
}
