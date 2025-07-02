namespace IndieGameZone.Domain.Entities
{
	public class UserProfiles
	{
		public Guid UserId { get; set; }
		public string? Fullname { get; set; } = string.Empty;
		public string? Avatar { get; set; } = string.Empty;
		public string? Bio { get; set; } = string.Empty;
		public DateOnly Birthday { get; set; }
		public string? YoutubeChannelLink { get; set; } = string.Empty;
		public string? FacebookLink { get; set; } = string.Empty;
		public string? BankName { get; set; } = string.Empty;
		public string? BankAccount { get; set; } = string.Empty;
        public DateTime? LastPingAt { get; set; }

        // Navigation properties
        public virtual Users User { get; set; } = null!;
	}
}
