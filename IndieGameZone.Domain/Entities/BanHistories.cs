namespace IndieGameZone.Domain.Entities
{
	public class BanHistories
	{
		public Guid Id { get; set; }
		public DateTime BanDate { get; set; }
		public DateTime UnbanDate { get; set; }
		public string Reason { get; set; } = string.Empty;
		public Guid UserId { get; set; }

		//Navigation Properties
		public virtual Users User { get; set; } = null!;
	}
}
