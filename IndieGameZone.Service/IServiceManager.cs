using IndieGameZone.Application.LanguageServices;

namespace IndieGameZone.Application
{
	public interface IServiceManager
	{
		ILanguageService LanguageService { get; }

	}
}
