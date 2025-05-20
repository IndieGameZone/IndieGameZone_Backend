using Microsoft.AspNetCore.Identity;

namespace IndieGameZone.Domain.Entities
{
	public class Users : IdentityUser
	{
		public bool IsActive { get; set; }
		public string? RefreshToken { get; set; }
		public DateTime? RefreshTokenExpiryTime { get; set; }
	}
}
