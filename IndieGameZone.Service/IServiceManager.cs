using IndieGameZone.Application.AchievementServices;
using IndieGameZone.Application.AgeRestrictionServices;
using IndieGameZone.Application.CategoryServices;
using IndieGameZone.Application.DiscountServices;
using IndieGameZone.Application.GamePlatformServices;
using IndieGameZone.Application.GameServices;
using IndieGameZone.Application.GameTypeServices;
using IndieGameZone.Application.LanguageServices;
using IndieGameZone.Application.LibraryServices;
using IndieGameZone.Application.PlatformServices;
using IndieGameZone.Application.ReviewServices;
using IndieGameZone.Application.TagServices;
using IndieGameZone.Application.TransactionServices;
using IndieGameZone.Application.UserServices;
using IndieGameZone.Application.WishlistServices;

namespace IndieGameZone.Application
{
	public interface IServiceManager
	{
		ILanguageService LanguageService { get; }
		ITagService TagService { get; }
		ICategoryService CategoryService { get; }
		IPlatformService PlatformService { get; }
		IGameTypeService GameTypeService { get; }
		IAgeRestrictionService AgeRestrictionService { get; }
		IGameService GameService { get; }
		IAchievementService AchievementService { get; }
		IUserService UserService { get; }
		IDiscountService DiscountService { get; }
		IGamePlatformService GamePlatformService { get; }
		IWishlistService WishlistService { get; }
		ITransactionService TransactionService { get; }
		IReviewService ReviewService { get; }
		ILibraryService LibraryService { get; }

	}
}
