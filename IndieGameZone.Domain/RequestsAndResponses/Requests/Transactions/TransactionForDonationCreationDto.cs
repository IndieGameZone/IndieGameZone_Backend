using IndieGameZone.Domain.Constants;
using System.ComponentModel.DataAnnotations;

namespace IndieGameZone.Domain.RequestsAndResponses.Requests.Transactions
{
	public class TransactionForDonationCreationDto
	{
		[Range(1000, double.MaxValue, ErrorMessage = "Amount must be greater than 1000.")]
		[Required]
		public double Amount { get; init; }
		[Required]
		public PaymentMethod PaymentMethod { get; init; }
	}
}
