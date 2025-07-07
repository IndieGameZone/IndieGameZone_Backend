using IndieGameZone.Domain.Constants;
using System.ComponentModel.DataAnnotations;

namespace IndieGameZone.Domain.RequestsAndResponses.Requests.Transactions
{
	public class TransactionForGameCreation
	{
		public string? CouponCode { get; init; }
		[Required]
		public PaymentMethod PaymentMethod { get; init; }
	}
}
