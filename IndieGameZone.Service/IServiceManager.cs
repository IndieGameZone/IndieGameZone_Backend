using IndieGameZone.Application.AgeRestrictionServices;
using IndieGameZone.Application.CategoryServices;
using IndieGameZone.Application.GameStatusServices;
using IndieGameZone.Application.LanguageServices;
using IndieGameZone.Application.PlatformServices;
using IndieGameZone.Application.TagServices;

namespace IndieGameZone.Application
{
	public interface IServiceManager
	{
		ILanguageService LanguageService { get; }
		ITagService TagService { get; }
		ICategoryService CategoryService { get; }
		IPlatformService PlatformService { get; }
		IGameStatusService GameStatusService { get; }
		IAgeRestrictionService AgeRestrictionService { get; }

	}
}
