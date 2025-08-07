using Bogus;
using IndieGameZone.Application.Hub;
using IndieGameZone.Application.IHub;
using IndieGameZone.Application.IServices;
using IndieGameZone.Domain.Entities;
using IndieGameZone.Domain.IRepositories;
using MapsterMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.SignalR;
using Microsoft.Extensions.Configuration;
using Quartz;

namespace IndieGameZone.Application.Services
{
	public class ServiceManager : IServiceManager
	{
		private readonly Lazy<ILanguageService> languageService;
		private readonly Lazy<ITagService> tagService;
		private readonly Lazy<ICategoryService> categoryService;
		private readonly Lazy<IPlatformService> platformService;
		private readonly Lazy<IAgeRestrictionService> ageRestrictionService;
		private readonly Lazy<IGameService> gameService;
		private readonly Lazy<IAchievementService> achievementService;
		private readonly Lazy<IUserService> userService;
		private readonly Lazy<IDiscountService> discountService;
		private readonly Lazy<IWishlistService> wishlistService;
		private readonly Lazy<ITransactionService> transactionService;
		private readonly Lazy<IReviewService> reviewService;
		private readonly Lazy<ILibraryService> libraryService;
		private readonly Lazy<IWithdrawRequestService> withdrawRequestService;
		private readonly Lazy<IPostService> postService;
		private readonly Lazy<IPostCommentService> postCommentService;
		private readonly Lazy<ICommercialPackageService> commercialPackageService;
		private readonly Lazy<IGamePlatformService> gamePlatformService;
		private readonly Lazy<IPostReactionService> postReactionService;
		private readonly Lazy<IReportReasonService> reportReasonService;
		private readonly Lazy<IUserFollowService> userFollowService;
		private readonly Lazy<IReportService> reportService;
		private readonly Lazy<INotificationService> notificationService;
		private readonly Lazy<IBanHistoryService> banHistoryService;
		private readonly Lazy<IGameCensorLogService> gameCensorLogService;
		private readonly Lazy<IDashBoardService> dashBoardService;
		private readonly Lazy<IGameImageService> gameImageService;
		private readonly Lazy<IOrderService> orderService;
		private readonly Lazy<IGamePriceLogService> gamePriceLogService;
		private readonly Lazy<ICouponService> couponService;

		public ServiceManager(IRepositoryManager repositoryManager, IMapper mapper, UserManager<Users> userManager, RoleManager<Roles> roleManager, IConfiguration configuration, IBlobService blobService, IEmailSender emailSender, IHttpContextAccessor httpContextAccessor, ISchedulerFactory schedulerFactory, Faker faker, IAIService aIService, IRecombeeService recombeeService, IHubContext<NotificationHub, INotificationHub> notificationHub)
		{
			languageService = new Lazy<ILanguageService>(() => new LanguageService(repositoryManager, mapper));
			tagService = new Lazy<ITagService>(() => new TagService(repositoryManager, mapper));
			categoryService = new Lazy<ICategoryService>(() => new CategoryService(repositoryManager, mapper));
			platformService = new Lazy<IPlatformService>(() => new PlatformService(repositoryManager, mapper));
			ageRestrictionService = new Lazy<IAgeRestrictionService>(() => new AgeRestrictionService(repositoryManager, mapper));
			gameService = new Lazy<IGameService>(() => new GameService(repositoryManager, mapper, blobService, schedulerFactory, recombeeService, userManager));
			achievementService = new Lazy<IAchievementService>(() => new AchievementService(repositoryManager, mapper));
			userService = new Lazy<IUserService>(() => new UserService(repositoryManager, mapper, userManager, roleManager, emailSender, httpContextAccessor, configuration, blobService, faker, recombeeService));
			discountService = new Lazy<IDiscountService>(() => new DiscountService(repositoryManager, mapper));
			wishlistService = new Lazy<IWishlistService>(() => new WishlistService(repositoryManager, mapper, recombeeService, userManager));
			transactionService = new Lazy<ITransactionService>(() => new TransactionService(repositoryManager, mapper, configuration, recombeeService, userManager, notificationHub));
			reviewService = new Lazy<IReviewService>(() => new ReviewService(repositoryManager, mapper, aIService, recombeeService, userManager));
			libraryService = new Lazy<ILibraryService>(() => new LibraryService(repositoryManager, mapper));
			withdrawRequestService = new Lazy<IWithdrawRequestService>(() => new WithdrawRequestService(repositoryManager, mapper, blobService));
			postService = new Lazy<IPostService>(() => new PostService(repositoryManager, mapper, blobService, schedulerFactory, userManager, notificationHub));
			postCommentService = new Lazy<IPostCommentService>(() => new PostCommentService(repositoryManager, mapper, schedulerFactory, notificationHub));
			commercialPackageService = new Lazy<ICommercialPackageService>(() => new CommercialPackageService(repositoryManager, mapper));
			gamePlatformService = new Lazy<IGamePlatformService>(() => new GamePlatformService(repositoryManager, mapper, blobService));
			postReactionService = new Lazy<IPostReactionService>(() => new PostReactionService(repositoryManager, notificationHub));
			reportReasonService = new Lazy<IReportReasonService>(() => new ReportReasonService(repositoryManager, mapper));
			userFollowService = new Lazy<IUserFollowService>(() => new UserFollowService(repositoryManager, notificationHub));
			reportService = new Lazy<IReportService>(() => new ReportService(repositoryManager, mapper));
			notificationService = new Lazy<INotificationService>(() => new NotificationService(repositoryManager, mapper));
			banHistoryService = new Lazy<IBanHistoryService>(() => new BanHistoryService(repositoryManager, mapper, userManager));
			gameCensorLogService = new Lazy<IGameCensorLogService>(() => new GameCensorLogService(repositoryManager, mapper));
			dashBoardService = new Lazy<IDashBoardService>(() => new DashBoardService(repositoryManager, mapper, userManager));
			gameImageService = new Lazy<IGameImageService>(() => new GameImageService(repositoryManager, blobService, schedulerFactory));
			orderService = new Lazy<IOrderService>(() => new OrderService(repositoryManager, mapper));
			gamePriceLogService = new Lazy<IGamePriceLogService>(() => new GamePriceLogService(repositoryManager, mapper));
			couponService = new Lazy<ICouponService>(() => new CouponService(repositoryManager, mapper));
		}

		public ILanguageService LanguageService => languageService.Value;

		public ITagService TagService => tagService.Value;

		public ICategoryService CategoryService => categoryService.Value;

		public IPlatformService PlatformService => platformService.Value;

		public IAgeRestrictionService AgeRestrictionService => ageRestrictionService.Value;

		public IGameService GameService => gameService.Value;

		public IAchievementService AchievementService => achievementService.Value;

		public IUserService UserService => userService.Value;

		public IDiscountService DiscountService => discountService.Value;

		public IWishlistService WishlistService => wishlistService.Value;

		public ITransactionService TransactionService => transactionService.Value;

		public IReviewService ReviewService => reviewService.Value;

		public ILibraryService LibraryService => libraryService.Value;

		public IWithdrawRequestService WithdrawRequestService => withdrawRequestService.Value;

		public IPostService PostService => postService.Value;

		public IPostCommentService PostCommentService => postCommentService.Value;

		public ICommercialPackageService CommercialPackageService => commercialPackageService.Value;

		public IGamePlatformService GamePlatformService => gamePlatformService.Value;

		public IPostReactionService PostReactionService => postReactionService.Value;

		public IReportReasonService ReportReasonService => reportReasonService.Value;

		public IUserFollowService UserFollowService => userFollowService.Value;

		public IReportService ReportService => reportService.Value;

		public INotificationService NotificationService => notificationService.Value;

		public IBanHistoryService BanHistoryService => banHistoryService.Value;

		public IGameCensorLogService GameCensorLogService => gameCensorLogService.Value;

		public IDashBoardService DashBoardService => dashBoardService.Value;

		public IGameImageService GameImageService => gameImageService.Value;

		public IOrderService OrderService => orderService.Value;

		public IGamePriceLogService GamePriceLogService => gamePriceLogService.Value;

		public ICouponService CouponService => couponService.Value;
	}
}
