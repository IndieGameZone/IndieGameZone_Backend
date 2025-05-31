namespace IndieGameZone.Domain.RequestsAndResponses.Responses.Libraries
{
	public class LibraryForReturnDto
	{
		public Guid UserId { get; init; }
		public Guid GameId { get; init; }
		public DateTime PurchasedAt { get; init; }
	}
}
