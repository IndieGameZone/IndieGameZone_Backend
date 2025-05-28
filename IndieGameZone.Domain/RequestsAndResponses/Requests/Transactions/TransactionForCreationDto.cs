namespace IndieGameZone.Domain.RequestsAndResponses.Requests.Transactions
{
	public class TransactionForCreationDto
	{
		public double Amount { get; init; }
		public string Description { get; init; }
		public Guid UserId { get; init; }
		public Guid? GameId { get; init; }
	}
}
