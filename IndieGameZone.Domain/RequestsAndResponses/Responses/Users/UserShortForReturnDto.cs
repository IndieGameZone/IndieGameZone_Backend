namespace IndieGameZone.Domain.RequestsAndResponses.Responses.Users
{
	public class UserShortForReturnDto
	{
		public Guid Id { get; init; }
		public string? UserName { get; init; }
		public string? Email { get; init; }
		public string? Fullname { get; init; }
		public string? Avatar { get; init; }
		public string? BankName { get; init; }
		public string? BankAccountNumber { get; init; }
		public string? BankAccountName { get; init; }
		public string? BankCode { get; init; }
		public string? BankBin { get; init; }
		public string? BankShortName { get; init; }
		public double Balance { get; init; }

	}
}
