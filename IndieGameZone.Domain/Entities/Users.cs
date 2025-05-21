using Microsoft.AspNetCore.Identity;

namespace IndieGameZone.Domain.Entities
{
	public class Users : IdentityUser<Guid>
	{
		public bool IsActive { get; set; }
		public string? RefreshToken { get; set; }
		public DateTime? RefreshTokenExpiryTime { get; set; }

		//Navigation Properties
		public virtual Wallets Wallet { get; set; } = null!;
		public virtual ICollection<BanHistories> BanHistories { get; set; } = null!;
		public virtual ICollection<Achievements> Achievements { get; set; } = null!;
		public virtual ICollection<Notifications> Notifications { get; set; } = null!;
		public virtual ICollection<Games> Games { get; set; } = null!;
		public virtual ICollection<Reviews> Reviews { get; set; } = new List<Reviews>();
	}
}
