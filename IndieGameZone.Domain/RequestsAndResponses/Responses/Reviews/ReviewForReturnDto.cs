using IndieGameZone.Domain.RequestsAndResponses.Responses.Games;
using IndieGameZone.Domain.RequestsAndResponses.Responses.Users;

namespace IndieGameZone.Domain.RequestsAndResponses.Responses.Reviews
{
	public class ReviewForReturnDto
	{
		public Guid Id { get; init; }
		public double Rating { get; init; }
		public string Comment { get; init; }
		public DateTime CreatedAt { get; init; }
		public UserShortForReturnDto User { get; init; }
		public GameForRecommendationDto Game { get; set; } = null!;
	}
}
