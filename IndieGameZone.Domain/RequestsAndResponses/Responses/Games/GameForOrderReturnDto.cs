using IndieGameZone.Domain.RequestsAndResponses.Responses.Categories;

namespace IndieGameZone.Domain.RequestsAndResponses.Responses.Games
{
	public class GameForOrderReturnDto
	{
		public Guid Id { get; init; }
		public string Name { get; init; }
		public string CoverImage { get; init; }
		public double Price { get; init; }
		public virtual CategoryForReturnDto Category { get; init; }
	}
}
