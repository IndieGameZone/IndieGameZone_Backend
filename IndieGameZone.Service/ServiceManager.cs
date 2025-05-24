using IndieGameZone.Application.AchievementServices;
using IndieGameZone.Application.AgeRestrictionServices;
using IndieGameZone.Application.BlobService;
using IndieGameZone.Application.CategoryServices;
using IndieGameZone.Application.GameServices;
using IndieGameZone.Application.GameStatusServices;
using IndieGameZone.Application.LanguageServices;
using IndieGameZone.Application.PlatformServices;
using IndieGameZone.Application.TagServices;
using IndieGameZone.Domain.Entities;
using IndieGameZone.Domain.IRepositories;
using MapsterMapper;
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
		public ServiceManager(IRepositoryManager repositoryManager, IMapper mapper, UserManager<Users> userManager, IConfiguration configuration, IBlobService blobService)
		{
			languageService = new Lazy<ILanguageService>(() => new LanguageService(repositoryManager, mapper));
			tagService = new Lazy<ITagService>(() => new TagService(repositoryManager, mapper));
			categoryService = new Lazy<ICategoryService>(() => new CategoryService(repositoryManager, mapper));
			platformService = new Lazy<IPlatformService>(() => new PlatformService(repositoryManager, mapper));
			gameStatusService = new Lazy<IGameStatusService>(() => new GameStatusService(repositoryManager, mapper));
			ageRestrictionService = new Lazy<IAgeRestrictionService>(() => new AgeRestrictionService(repositoryManager, mapper));
			gameService = new Lazy<IGameService>(() => new GameService(repositoryManager, mapper, blobService));
			achievementService = new Lazy<IAchievementService>(() => new AchievementService(repositoryManager, mapper));
		}

		public ILanguageService LanguageService => languageService.Value;

		public ITagService TagService => tagService.Value;

		public ICategoryService CategoryService => categoryService.Value;

		public IPlatformService PlatformService => platformService.Value;

		public IGameStatusService GameStatusService => gameStatusService.Value;

		public IAgeRestrictionService AgeRestrictionService => ageRestrictionService.Value;

		public IGameService GameService => gameService.Value;

		public IAchievementService AchievementService => achievementService.Value;
	}
}
