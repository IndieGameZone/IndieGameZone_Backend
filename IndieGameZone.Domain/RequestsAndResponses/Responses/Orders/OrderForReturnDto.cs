using IndieGameZone.Domain.RequestsAndResponses.Responses.CommercialPackages;
using IndieGameZone.Domain.RequestsAndResponses.Responses.Games;

namespace IndieGameZone.Domain.RequestsAndResponses.Responses.Orders
{
	public class OrderForReturnDto
	{
		public Guid Id { get; set; }
		public double Amount { get; set; }
		public DateOnly? CommercialRegistrationStartDate { get; set; }
		public DateOnly? CommercialRegistrationEndDate { get; set; }
		public DateTime CreatedAt { get; set; }
		public GameForListReturnDto? Game { get; set; }
		public CommercialPackageForReturnDto? CommercialPackage { get; set; } = null!;
	}
}
