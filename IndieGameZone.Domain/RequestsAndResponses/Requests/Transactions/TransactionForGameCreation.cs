using IndieGameZone.Domain.Constants;

namespace IndieGameZone.Domain.RequestsAndResponses.Requests.Transactions
{
	public class TransactionForGameCreation
	{
		public string? CouponCode { get; init; }
		public PaymentMethod PaymentMethod { get; init; }
	}
}
