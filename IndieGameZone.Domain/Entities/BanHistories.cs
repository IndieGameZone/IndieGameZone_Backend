namespace IndieGameZone.Domain.Entities
{
	public class BanHistories
	{
		public Guid Id { get; set; }
		public DateTime BanDate { get; set; }
		public DateTime UnbanDate { get; set; }
		public string Reason { get; set; } = string.Empty;
        public Guid BannedUserId { get; set; }
        public Guid BannedByUserId { get; set; }

        // Navigation Properties
        public virtual Users BannedUser { get; set; } = null!;
        public virtual Users BannedByUser { get; set; } = null!;
    }
}
