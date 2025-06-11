using IndieGameZone.Domain.IRepositories;
using IndieGameZone.Infrastructure.Persistence;
using Microsoft.EntityFrameworkCore.Storage;
using System.Data;

namespace IndieGameZone.Infrastructure.Repositories
{
	public sealed class RepositoryManager : IRepositoryManager
	{
		private readonly AppDbContext appDbContext;
		private readonly Lazy<ILanguageRepository> languageRepository;
		private readonly Lazy<ITagRepository> tagRepository;
		private readonly Lazy<ICategoryRepository> categoryRepository;
		private readonly Lazy<IPlatformRepository> platformRepository;
		private readonly Lazy<IAgeRestrictionRepository> ageRestrictionRepository;
		private readonly Lazy<IGameRepository> gameRepository;
		private readonly Lazy<IAchievementRepository> achievementRepository;
		private readonly Lazy<IUserRepository> userRepository;
		private readonly Lazy<IUserProfileRepository> userProfileRepository;
		private readonly Lazy<IWalletRepository> walletRepository;
		private readonly Lazy<IGamePlatformRepository> gamePlatformRepository;
		private readonly Lazy<GameImageRepository> gameImageRepository;
		private readonly Lazy<IGameLanguageRepository> gameLanguageRepository;
		private readonly Lazy<IGameTagRepository> gameTagRepository;
		private readonly Lazy<IDiscountRepository> discountRepository;
		private readonly Lazy<IWishlistRepository> wishlistRepository;
		private readonly Lazy<ITransactionRepository> transactionRepository;
		private readonly Lazy<IReviewRepository> reviewRepository;
		private readonly Lazy<ILibraryRepository> libraryRepository;
		private readonly Lazy<IWithdrawRequestRepository> withdrawRequestRepository;
		private readonly Lazy<IPostRepository> postRepository;
		private readonly Lazy<IPostCommentRepository> postCommentRepository;
		private readonly Lazy<ICommercialPackageRepository> commercialPackageRepository;
		private readonly Lazy<IPostReactionRepository> postReactionRepository;
		private readonly Lazy<IReportReasonRepository> reportReasonRepository;
		private readonly Lazy<IUserFollowRepository> userFollowRepository;
		private readonly Lazy<IPostTagRepository> postTagRepository;
		private readonly Lazy<IReportRepository> reportRepository;
		private readonly Lazy<INotificationRepository> notificationRepository;

		public RepositoryManager(AppDbContext appDbContext)
		{
			this.appDbContext = appDbContext;
			languageRepository = new Lazy<ILanguageRepository>(() => new LanguageRepository(appDbContext));
			tagRepository = new Lazy<ITagRepository>(() => new TagRepository(appDbContext));
			categoryRepository = new Lazy<ICategoryRepository>(() => new CategoryRepository(appDbContext));
			platformRepository = new Lazy<IPlatformRepository>(() => new PlatformRepository(appDbContext));
			ageRestrictionRepository = new Lazy<IAgeRestrictionRepository>(() => new AgeRestrictionRepository(appDbContext));
			gameRepository = new Lazy<IGameRepository>(() => new GameRepository(appDbContext));
			achievementRepository = new Lazy<IAchievementRepository>(() => new AchievementRepository(appDbContext));
			userRepository = new Lazy<IUserRepository>(() => new UserRepository(appDbContext));
			userProfileRepository = new Lazy<IUserProfileRepository>(() => new UserProfileRepository(appDbContext));
			walletRepository = new Lazy<IWalletRepository>(() => new WalletRepository(appDbContext));
			gamePlatformRepository = new Lazy<IGamePlatformRepository>(() => new GamePlatformRepository(appDbContext));
			gameImageRepository = new Lazy<GameImageRepository>(() => new GameImageRepository(appDbContext));
			gameLanguageRepository = new Lazy<IGameLanguageRepository>(() => new GameLanguageRepository(appDbContext));
			gameTagRepository = new Lazy<IGameTagRepository>(() => new GameTagRepository(appDbContext));
			discountRepository = new Lazy<IDiscountRepository>(() => new DiscountRepository(appDbContext));
			wishlistRepository = new Lazy<IWishlistRepository>(() => new WishlistRepository(appDbContext));
			transactionRepository = new Lazy<ITransactionRepository>(() => new TransactionRepository(appDbContext));
			reviewRepository = new Lazy<IReviewRepository>(() => new ReviewRepository(appDbContext));
			libraryRepository = new Lazy<ILibraryRepository>(() => new LibraryRepository(appDbContext));
			withdrawRequestRepository = new Lazy<IWithdrawRequestRepository>(() => new WithdrawRequestRepository(appDbContext));
			postRepository = new Lazy<IPostRepository>(() => new PostRepository(appDbContext));
			postCommentRepository = new Lazy<IPostCommentRepository>(() => new PostCommentRepository(appDbContext));
			commercialPackageRepository = new Lazy<ICommercialPackageRepository>(() => new CommercialPackageRepository(appDbContext));
			postReactionRepository = new Lazy<IPostReactionRepository>(() => new PostReactionRepository(appDbContext));
			reportReasonRepository = new Lazy<IReportReasonRepository>(() => new ReportReasonRepository(appDbContext));
			userFollowRepository = new Lazy<IUserFollowRepository>(() => new UserFollowRepository(appDbContext));
			postTagRepository = new Lazy<IPostTagRepository>(() => new PostTagRepository(appDbContext));
			reportRepository = new Lazy<IReportRepository>(() => new ReportRepository(appDbContext));
			notificationRepository = new Lazy<INotificationRepository>(() => new NotificationRepository(appDbContext));

		}

		public ILanguageRepository LanguageRepository => languageRepository.Value;

		public ITagRepository TagRepository => tagRepository.Value;

		public ICategoryRepository CategoryRepository => categoryRepository.Value;

		public IPlatformRepository PlatformRepository => platformRepository.Value;

		public IAgeRestrictionRepository AgeRestrictionRepository => ageRestrictionRepository.Value;

		public IGameRepository GameRepository => gameRepository.Value;

		public IAchievementRepository AchievementRepository => achievementRepository.Value;

		public IUserRepository UserRepository => userRepository.Value;

		public IUserProfileRepository UserProfileRepository => userProfileRepository.Value;

		public IWalletRepository WalletRepository => walletRepository.Value;

		public IGamePlatformRepository GamePlatformRepository => gamePlatformRepository.Value;

		public IGameImageRepository GameImageRepository => gameImageRepository.Value;

		public IGameLanguageRepository GameLanguageRepository => gameLanguageRepository.Value;

		public IGameTagRepository GameTagRepository => gameTagRepository.Value;

		public IDiscountRepository DiscountRepository => discountRepository.Value;

		public IWishlistRepository WishlistRepository => wishlistRepository.Value;

		public ITransactionRepository TransactionRepository => transactionRepository.Value;

		public IReviewRepository ReviewRepository => reviewRepository.Value;

		public ILibraryRepository LibraryRepository => libraryRepository.Value;

		public IWithdrawRequestRepository WithdrawRequestRepository => withdrawRequestRepository.Value;

		public IPostRepository PostRepository => postRepository.Value;

		public IPostCommentRepository PostCommentRepository => postCommentRepository.Value;

		public ICommercialPackageRepository CommercialPackageRepository => commercialPackageRepository.Value;

		public IPostReactionRepository PostReactionRepository => postReactionRepository.Value;

		public IReportReasonRepository ReportReasonRepository => reportReasonRepository.Value;

		public IUserFollowRepository UserFollowRepository => userFollowRepository.Value;

		public IPostTagRepository PostTagRepository => postTagRepository.Value;

		public IReportRepository ReportRepository => reportRepository.Value;

		public INotificationRepository NotificationRepository => notificationRepository.Value;

		public async Task<IDbTransaction> BeginTransaction(CancellationToken ct = default)
		{
			var transaction = await appDbContext.Database.BeginTransactionAsync(ct);
			return transaction.GetDbTransaction();
		}

		public Task SaveAsync(CancellationToken ct = default) => appDbContext.SaveChangesAsync(ct);

	}
}
