using IndieGameZone.Domain.RequestsAndResponses.Responses.Games;

namespace IndieGameZone.Domain.RequestsAndResponses.Responses.Libraries
{
	public class LibraryForReturnDto
	{
		public virtual GameForRecommendationDto Game { get; init; }
		public DateTime PurchasedAt { get; init; }
	}
}
