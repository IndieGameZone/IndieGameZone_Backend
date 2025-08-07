namespace IndieGameZone.Domain.RequestsAndResponses.Responses.Coupons
{
	public class CouponForReturnDto
	{
		public Guid Id { get; init; }
		public string Code { get; init; }
		public double Percentage { get; init; }
		public bool IsUsed { get; init; }
		public DateOnly EndDate { get; init; }
	}
}
