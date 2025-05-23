using IndieGameZone.Application.LanguageServices;
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
		public ServiceManager(IRepositoryManager repositoryManager, IMapper mapper, UserManager<Users> userManager, IConfiguration configuration)
		{
			languageService = new Lazy<ILanguageService>(() => new LanguageService(repositoryManager, mapper));
		}

		public ILanguageService LanguageService => languageService.Value;

	}
}
