namespace IndieGameZone.Domain.RequestsAndResponses.Responses.GameInfos
{
	public class GameInfoForReturnDto
	{
		public Guid Id { get; init; }
		public string? Image { get; init; }
		public string? Title { get; init; }
		public string? Description { get; init; }
	}
}
