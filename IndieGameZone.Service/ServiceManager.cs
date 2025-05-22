using IndieGameZone.Domain.Entities;
using IndieGameZone.Domain.Repositories;
using MapsterMapper;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Configuration;

namespace IndieGameZone.Service
{
	public class ServiceManager : IServiceManager
	{
		public ServiceManager(IRepositoryManager repositoryManager, IMapper mapper, UserManager<Users> userManager, IConfiguration configuration)
		{

		}
	}
}
