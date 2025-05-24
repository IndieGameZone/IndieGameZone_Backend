namespace IndieGameZone.Domain.RequestsAndResponses.Responses.Games
{
	public class GameForListReturnDto
	{
		public Guid Id { get; init; }
		public string Name { get; init; }
		public string CoverImage { get; init; }
		public bool IsActive { get; init; }
		public double Price { get; init; }
	}
}
