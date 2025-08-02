using IndieGameZone.Domain.Constants;
using IndieGameZone.Domain.RequestsAndResponses.Responses.Games;

namespace IndieGameZone.Domain.RequestsAndResponses.Responses.Transactions
{
	public class TransactionForReturnDto
	{
		public Guid Id { get; init; }
		public long OrderCode { get; init; }
		public double Amount { get; init; }
		public string Description { get; init; }
		public TransactionStatus Status { get; init; }
		public TransactionType Type { get; init; }
		public PaymentMethod PaymentMethod { get; init; }
		public DateTime CreatedAt { get; init; }
		public virtual GameForRecommendationDto? Game { get; set; }
		public Guid? OrderId { get; set; }
	}
}
