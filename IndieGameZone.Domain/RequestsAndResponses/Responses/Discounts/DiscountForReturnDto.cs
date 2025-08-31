namespace IndieGameZone.Domain.RequestsAndResponses.Responses.Discounts
{
	public class DiscountForReturnDto
	{
		public Guid Id { get; init; }
		public double Percentage { get; init; }
		public DateOnly EndDate { get; init; }
	}
}
