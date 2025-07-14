using Mapster;
using Microsoft.Extensions.DependencyInjection;
using System.Reflection;

namespace IndieGameZone.Application.Extensions
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
