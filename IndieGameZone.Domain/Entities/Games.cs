using IndieGameZone.Domain.Constants;

namespace IndieGameZone.Domain.Entities
{
	public class Games
	{
		public Guid Id { get; set; }
		public string Name { get; set; } = string.Empty;
		public string CoverImage { get; set; } = string.Empty;
		public string VideoLink { get; set; } = string.Empty;
		public string Description { get; set; } = string.Empty;
		public bool AllowDonation { get; set; }
		public GameStatus Status { get; set; }
		public double Price { get; set; }
		public DateTime CreatedAt { get; set; }
		public DateTime? CensoredAt { get; set; }
		public DateTime? UpdatedAt { get; set; }
		public double AverageSession { get; set; }
		public Guid AgeRestrictionId { get; set; }
		public Guid DeveloperId { get; set; }
		public Guid CategoryId { get; set; }
		public Guid GameTypeId { get; set; }

		// Navigation properties
		public virtual ICollection<GameLanguages> GameLanguages { get; set; } = new List<GameLanguages>();
		public virtual ICollection<GameImages> GameImages { get; set; } = new List<GameImages>();
		public virtual ICollection<GameTags> GameTags { get; set; } = new List<GameTags>();
		public virtual Categories Category { get; set; } = null!;
		public virtual ICollection<GamePlatforms> GamePlatforms { get; set; } = new List<GamePlatforms>();
		public virtual AgeRestrictions AgeRestriction { get; set; } = null!;
		public virtual Users Developers { get; set; } = null!;
		public virtual ICollection<Reviews> Reviews { get; set; } = new List<Reviews>();
		public virtual ICollection<Discounts> Discounts { get; set; } = new List<Discounts>();
		public virtual ICollection<CommercialRegistration> CommercialRegistration { get; set; } = new List<CommercialRegistration>();
		public virtual ICollection<Wishlists> Wishlists { get; set; } = new List<Wishlists>();
		public virtual ICollection<Libraries> Libraries { get; set; } = new List<Libraries>();
		public virtual ICollection<Posts> Posts { get; set; } = new List<Posts>();
		public virtual ICollection<Reports> Reports { get; set; } = new List<Reports>();
		public virtual ICollection<GameRecommendations> GameRecommendations { get; set; } = new List<GameRecommendations>();
		public virtual ICollection<Transactions> Transactions { get; set; } = new List<Transactions>();

	}
}
