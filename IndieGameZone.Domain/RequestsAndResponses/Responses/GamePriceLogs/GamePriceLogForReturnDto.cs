namespace IndieGameZone.Domain.RequestsAndResponses.Responses.GamePriceLogs
{
	public class GamePriceLogForReturnDto
	{
		public Guid Id { get; init; }
		public double Price { get; init; }
		public DateTime CreatedAt { get; init; }
	}
}
