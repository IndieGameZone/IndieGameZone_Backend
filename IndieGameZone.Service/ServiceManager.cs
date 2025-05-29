using IndieGameZone.Application.AchievementServices;
using IndieGameZone.Application.AgeRestrictionServices;
using IndieGameZone.Application.BlobService;
using IndieGameZone.Application.CategoryServices;
using IndieGameZone.Application.DiscountServices;
using IndieGameZone.Application.EmailServices;
using IndieGameZone.Application.GameInfoServices;
using IndieGameZone.Application.GamePlatformServices;
using IndieGameZone.Application.GameServices;
using IndieGameZone.Application.GameStatusServices;
using IndieGameZone.Application.LanguageServices;
using IndieGameZone.Application.PlatformServices;
using IndieGameZone.Application.TagServices;
using IndieGameZone.Application.TransactionServices;
using IndieGameZone.Application.UserServices;
using IndieGameZone.Application.WishlistServices;
using IndieGameZone.Domain.Entities;
using IndieGameZone.Domain.IRepositories;
using MapsterMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Configuration;

namespace IndieGameZone.Application
{
	public class ServiceManager : IServiceManager
	{
		private readonly Lazy<ILanguageService> languageService;
		private readonly Lazy<ITagService> tagService;
		private readonly Lazy<ICategoryService> categoryService;
		private readonly Lazy<IPlatformService> platformService;
		private readonly Lazy<IGameStatusService> gameStatusService;
		private readonly Lazy<IAgeRestrictionService> ageRestrictionService;
		private readonly Lazy<IGameService> gameService;
		private readonly Lazy<IAchievementService> achievementService;
		private readonly Lazy<IUserService> userService;
		private readonly Lazy<IDiscountService> discountService;
		private readonly Lazy<IGameImageService> gameInfoService;
		private readonly Lazy<IGamePlatformService> gamePlatformService;
		private readonly Lazy<IWishlistService> wishlistService;
		private readonly Lazy<ITransactionService> transactionService;

		public ServiceManager(IRepositoryManager repositoryManager, IMapper mapper, UserManager<Users> userManager, RoleManager<Roles> roleManager, IConfiguration configuration, IBlobService blobService, IEmailSender emailSender, IHttpContextAccessor httpContextAccessor)
		{
			languageService = new Lazy<ILanguageService>(() => new LanguageService(repositoryManager, mapper));
			tagService = new Lazy<ITagService>(() => new TagService(repositoryManager, mapper));
			categoryService = new Lazy<ICategoryService>(() => new CategoryService(repositoryManager, mapper));
			platformService = new Lazy<IPlatformService>(() => new PlatformService(repositoryManager, mapper));
			gameStatusService = new Lazy<IGameStatusService>(() => new GameStatusService(repositoryManager, mapper));
			ageRestrictionService = new Lazy<IAgeRestrictionService>(() => new AgeRestrictionService(repositoryManager, mapper));
			gameService = new Lazy<IGameService>(() => new GameService(repositoryManager, mapper, blobService));
			achievementService = new Lazy<IAchievementService>(() => new AchievementService(repositoryManager, mapper));
			userService = new Lazy<IUserService>(() => new UserService(repositoryManager, mapper, userManager, roleManager, emailSender, httpContextAccessor, configuration));
			discountService = new Lazy<IDiscountService>(() => new DiscountService(repositoryManager, mapper));
			gameInfoService = new Lazy<IGameImageService>(() => new GameImageService(repositoryManager, mapper, blobService));
			gamePlatformService = new Lazy<IGamePlatformService>(() => new GamePlatformService(repositoryManager, mapper, blobService));
			wishlistService = new Lazy<IWishlistService>(() => new WishlistService(repositoryManager, mapper));
			transactionService = new Lazy<ITransactionService>(() => new TransactionService(repositoryManager, mapper, configuration));
		}

		public ILanguageService LanguageService => languageService.Value;

		public ITagService TagService => tagService.Value;

		public ICategoryService CategoryService => categoryService.Value;

		public IPlatformService PlatformService => platformService.Value;

		public IGameStatusService GameStatusService => gameStatusService.Value;

		public IAgeRestrictionService AgeRestrictionService => ageRestrictionService.Value;

		public IGameService GameService => gameService.Value;

		public IAchievementService AchievementService => achievementService.Value;

		public IUserService UserService => userService.Value;

		public IDiscountService DiscountService => discountService.Value;

		public IGameImageService GameInfoService => gameInfoService.Value;

		public IGamePlatformService GamePlatformService => gamePlatformService.Value;

		public IWishlistService WishlistService => wishlistService.Value;

		public ITransactionService TransactionService => transactionService.Value;
	}
}
