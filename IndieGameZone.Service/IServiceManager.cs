using IndieGameZone.Application.LanguageServices;
using IndieGameZone.Application.TagServices;

namespace IndieGameZone.Application
{
	public interface IServiceManager
	{
		ILanguageService LanguageService { get; }
		ITagService TagService { get; }

	}
}
