using IndieGameZone.Domain.Constants;
using System.ComponentModel.DataAnnotations;

namespace IndieGameZone.Domain.RequestsAndResponses.Requests.Transactions
{
	public class TransactionForGameCreation
	{
		public Guid? CouponId { get; init; }
		[Required]
		public PaymentMethod PaymentMethod { get; init; }
	}
}
