using IndieGameZone.Application.CategoryServices;
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
		public ServiceManager(IRepositoryManager repositoryManager, IMapper mapper, UserManager<Users> userManager, IConfiguration configuration)
		{
			languageService = new Lazy<ILanguageService>(() => new LanguageService(repositoryManager, mapper));
			tagService = new Lazy<ITagService>(() => new TagService(repositoryManager, mapper));
			categoryService = new Lazy<ICategoryService>(() => new CategoryService(repositoryManager, mapper));
			platformService = new Lazy<IPlatformService>(() => new PlatformService(repositoryManager, mapper));
		}

		public ILanguageService LanguageService => languageService.Value;

		public ITagService TagService => tagService.Value;

		public ICategoryService CategoryService => categoryService.Value;

		public IPlatformService PlatformService => platformService.Value;
	}
}
