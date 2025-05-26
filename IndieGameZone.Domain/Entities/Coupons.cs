namespace IndieGameZone.Domain.Entities
{
	public class Coupons
	{
		public Guid Id { get; set; }
		public string Code { get; set; } = string.Empty;
		public double Percentage { get; set; }
		public bool IsUsed { get; set; }
		public DateOnly StartDate { get; set; }
		public DateOnly EndDate { get; set; }
		public Guid UserId { get; set; }

		//Navigation property
		public Users User { get; set; } = null!;
	}
}
