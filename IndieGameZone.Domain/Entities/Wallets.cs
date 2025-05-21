namespace IndieGameZone.Domain.Entities
{
	public class Wallets
	{
		public Guid UserId { get; set; }
		public double Balance { get; set; }

		//Navigation Properties
		public virtual Users User { get; set; } = null!;
	}
}
