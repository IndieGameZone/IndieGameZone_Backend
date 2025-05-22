using IndieGameZone.Domain.Entities;
using IndieGameZone.Infrastructure.Configurations;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace IndieGameZone.Infrastructure.Persistence
{
	public class RepositoryContext : IdentityDbContext<Users, Roles, Guid>
	{
		private readonly IPasswordHasher<Users> passwordHasher;

		public RepositoryContext(DbContextOptions<RepositoryContext> options, IPasswordHasher<Users> passwordHasher) : base(options)
		{
			this.passwordHasher = passwordHasher;
		}

		public DbSet<Achievements> Achievements { get; set; } = null!;
		public DbSet<AgeRestrictions> AgeRestrictions { get; set; } = null!;
		public DbSet<BanHistories> BanHistories { get; set; } = null!;
		public DbSet<Categories> Categories { get; set; } = null!;
		public DbSet<CommercialPackages> CommercialPackages { get; set; } = null!;
		public DbSet<CommercialRegistration> CommercialRegistration { get; set; } = null!;
		public DbSet<Coupons> Coupons { get; set; } = null!;
		public DbSet<Discounts> Discounts { get; set; } = null!;
		public DbSet<GameInfos> GameInfos { get; set; } = null!;
		public DbSet<GameLanguages> GameLanguages { get; set; } = null!;
		public DbSet<GamePlatforms> GamePlatforms { get; set; } = null!;
		public DbSet<GameRecommendations> GameRecommendations { get; set; } = null!;
		public DbSet<Games> Games { get; set; } = null!;
		public DbSet<GameTags> GameTags { get; set; } = null!;
		public DbSet<Languages> Languages { get; set; } = null!;
		public DbSet<Libraries> Libraries { get; set; } = null!;
		public DbSet<Notifications> Notifications { get; set; } = null!;
		public DbSet<Platforms> Platforms { get; set; } = null!;
		public DbSet<PostComments> PostComments { get; set; } = null!;
		public DbSet<PostReactions> PostReactions { get; set; } = null!;
		public DbSet<Posts> Posts { get; set; } = null!;
		public DbSet<PostTags> PostTags { get; set; } = null!;
		public DbSet<Reports> Reports { get; set; } = null!;
		public DbSet<ReportTypes> ReportTypes { get; set; } = null!;
		public DbSet<Reviews> Reviews { get; set; } = null!;
		public DbSet<Roles> Roles { get; set; } = null!;
		public DbSet<Tags> Tags { get; set; } = null!;
		public DbSet<Transactions> Transactions { get; set; } = null!;
		public DbSet<UserAchievements> UserAchievements { get; set; } = null!;
		public DbSet<UserFollows> UserFollows { get; set; } = null!;
		public DbSet<UserProfiles> UserProfiles { get; set; } = null!;
		public DbSet<Users> Users { get; set; } = null!;
		public DbSet<Wallets> Wallets { get; set; } = null!;
		public DbSet<Wishlists> Wishlists { get; set; } = null!;
		public DbSet<WithdrawRequests> WithdrawRequests { get; set; } = null!;


		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			base.OnModelCreating(modelBuilder);
			modelBuilder.Ignore<IdentityUserClaim<Guid>>();
			modelBuilder.Ignore<IdentityRoleClaim<Guid>>();
			modelBuilder.ApplyConfiguration(new AchievementConfiguration());
			modelBuilder.ApplyConfiguration(new AgeRestrictionConfiguration());
			modelBuilder.ApplyConfiguration(new BanHistoryConfiguration());
			modelBuilder.ApplyConfiguration(new CategoryConfiguration());
			modelBuilder.ApplyConfiguration(new CommercialPackageConfiguration());
			modelBuilder.ApplyConfiguration(new CommercialRegistrationConfiguration());
			modelBuilder.ApplyConfiguration(new CouponConfiguration());
			modelBuilder.ApplyConfiguration(new DiscountConfiguration());
			modelBuilder.ApplyConfiguration(new GameConfiguration());
			modelBuilder.ApplyConfiguration(new GameInfoConfiguration());
			modelBuilder.ApplyConfiguration(new GameRecommendationConfiguration());
			modelBuilder.ApplyConfiguration(new LanguageConfiguration());
			modelBuilder.ApplyConfiguration(new LibraryConfiguration());
			modelBuilder.ApplyConfiguration(new NotificationConfiguration());
			modelBuilder.ApplyConfiguration(new PlatformConfiguration());
			modelBuilder.ApplyConfiguration(new PostCommentConfiguration());
			modelBuilder.ApplyConfiguration(new PostConfiguration());
			modelBuilder.ApplyConfiguration(new PostReactionConfiguration());
			modelBuilder.ApplyConfiguration(new ReportConfiguration());
			modelBuilder.ApplyConfiguration(new ReportTypeConfiguration());
			modelBuilder.ApplyConfiguration(new ReviewConfiguration());
			modelBuilder.ApplyConfiguration(new RoleConfiguration());
			modelBuilder.ApplyConfiguration(new TagConfiguration());
			modelBuilder.ApplyConfiguration(new TransactionConfiguration());
			modelBuilder.ApplyConfiguration(new UserConfiguration(passwordHasher));
			modelBuilder.ApplyConfiguration(new UserFollowConfiguration());
			modelBuilder.ApplyConfiguration(new UserProfileConfiguration());
			modelBuilder.ApplyConfiguration(new WalletConfiguration());
			modelBuilder.ApplyConfiguration(new WishlistConfiguration());
			modelBuilder.ApplyConfiguration(new WithdrawRequestConfiguration());
			modelBuilder.ApplyConfiguration(new UserRoleConfiguration());
		}
	}
}
