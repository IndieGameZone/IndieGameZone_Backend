using IndieGameZone.Application.AchievementServices;
using IndieGameZone.Application.AgeRestrictionServices;
using IndieGameZone.Application.CategoryServices;
using IndieGameZone.Application.CommercialPackageServices;
using IndieGameZone.Application.DiscountServices;
using IndieGameZone.Application.GamePlatformServices;
using IndieGameZone.Application.GameServices;
using IndieGameZone.Application.LanguageServices;
using IndieGameZone.Application.LibraryServices;
using IndieGameZone.Application.PlatformServices;
using IndieGameZone.Application.PostCommentServices;
using IndieGameZone.Application.PostReactionServices;
using IndieGameZone.Application.PostServices;
using IndieGameZone.Application.ReviewServices;
using IndieGameZone.Application.TagServices;
using IndieGameZone.Application.TransactionServices;
using IndieGameZone.Application.UserServices;
using IndieGameZone.Application.WishlistServices;
using IndieGameZone.Application.WithdrawRequestServices;

namespace IndieGameZone.Application
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
	}
}
