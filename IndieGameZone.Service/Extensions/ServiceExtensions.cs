using Mapster;
using Microsoft.Extensions.DependencyInjection;
using System.Reflection;

namespace IndieGameZone.Service.Extensions
{
	public static class ServiceExtensions
	{
		public static void ConfigureMapsters(this IServiceCollection services)
		{
			TypeAdapterConfig.GlobalSettings.Scan(Assembly.GetExecutingAssembly());
			services.AddMapster();
		}
	}
}
