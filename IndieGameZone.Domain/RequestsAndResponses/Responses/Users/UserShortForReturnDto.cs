namespace IndieGameZone.Domain.RequestsAndResponses.Responses.Users
{
	public class UserShortForReturnDto
	{
		public Guid Id { get; init; }
		public string? UserName { get; init; }
		public string? Email { get; init; }
		public string? Fullname { get; init; }
		public string? Avatar { get; init; }
	}
}
