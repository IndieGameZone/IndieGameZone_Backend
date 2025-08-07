namespace IndieGameZone.Application.IServices
{
	public interface IServiceManager
	{
		ILanguageService LanguageService { get; }
		ITagService TagService { get; }
		ICategoryService CategoryService { get; }
		IPlatformService PlatformService { get; }
		IAgeRestrictionService AgeRestrictionService { get; }
		IGameService GameService { get; }
		IAchievementService AchievementService { get; }
		IUserService UserService { get; }
		IDiscountService DiscountService { get; }
		IWishlistService WishlistService { get; }
		ITransactionService TransactionService { get; }
		IReviewService ReviewService { get; }
		ILibraryService LibraryService { get; }
		IWithdrawRequestService WithdrawRequestService { get; }
		IPostService PostService { get; }
		IPostCommentService PostCommentService { get; }
		ICommercialPackageService CommercialPackageService { get; }
		IGamePlatformService GamePlatformService { get; }
		IPostReactionService PostReactionService { get; }
		IReportReasonService ReportReasonService { get; }
		IUserFollowService UserFollowService { get; }
		IReportService ReportService { get; }
		INotificationService NotificationService { get; }
		IBanHistoryService BanHistoryService { get; }
		IGameCensorLogService GameCensorLogService { get; }
		IDashBoardService DashBoardService { get; }
		IGameImageService GameImageService { get; }
		IOrderService OrderService { get; }
		IGamePriceLogService GamePriceLogService { get; }
		ICouponService CouponService { get; }
		IDownloadSlotService DownloadSlotService { get; }
	}
}