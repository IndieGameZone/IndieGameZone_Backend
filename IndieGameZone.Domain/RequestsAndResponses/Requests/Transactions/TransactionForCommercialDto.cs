using IndieGameZone.Domain.Constants;
using System.ComponentModel.DataAnnotations;

namespace IndieGameZone.Domain.RequestsAndResponses.Requests.Transactions
{
	public class TransactionForCommercialDto
	{
		[Required]
		public DateOnly StartDate { get; init; }
		[Required]
		public PaymentMethod PaymentMethod { get; init; }
	}
}
