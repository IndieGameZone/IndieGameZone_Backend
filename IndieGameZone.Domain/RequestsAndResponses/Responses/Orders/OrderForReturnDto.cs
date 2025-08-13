using IndieGameZone.Domain.RequestsAndResponses.Responses.CommercialPackages;
using IndieGameZone.Domain.RequestsAndResponses.Responses.Games;
using IndieGameZone.Domain.RequestsAndResponses.Responses.Transactions;

namespace IndieGameZone.Domain.RequestsAndResponses.Responses.Orders
{
	public class OrderForReturnDto
	{
		public Guid Id { get; init; }
		public double Amount { get; init; }
		public DateOnly? CommercialRegistrationStartDate { get; init; }
		public DateOnly? CommercialRegistrationEndDate { get; init; }
		public DateTime CreatedAt { get; init; }
		public GameForOrderReturnDto? Game { get; init; }
		public CommercialPackageForOrderReturnDto? CommercialPackage { get; init; } = null!;
		public TransactionForReturnDto Transaction { get; init; } = null!;
	}
}
