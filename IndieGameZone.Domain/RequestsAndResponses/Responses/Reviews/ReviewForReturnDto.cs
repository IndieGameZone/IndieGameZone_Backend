namespace IndieGameZone.Domain.RequestsAndResponses.Responses.Reviews
{
	public class ReviewForReturnDto
	{
		public Guid Id { get; init; }
		public double Rating { get; init; }
		public string Comment { get; init; }
		public DateTime CreatedAt { get; init; }
		public Guid UserId { get; init; }
		public Guid GameId { get; init; }
	}
}
