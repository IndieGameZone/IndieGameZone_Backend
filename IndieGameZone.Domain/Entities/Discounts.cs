namespace IndieGameZone.Domain.Entities
{
	public class Discounts
	{
		public Guid Id { get; set; }
		public double Percentage { get; set; }
		public DateOnly StartDate { get; set; }
		public DateOnly EndDate { get; set; }
		public Guid GameId { get; set; }

		//Navigation property
		public Games Game { get; set; } = null!;
	}
}
