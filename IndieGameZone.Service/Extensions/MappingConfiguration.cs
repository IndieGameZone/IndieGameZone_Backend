using IndieGameZone.Domain.Entities;
using IndieGameZone.Domain.RequestsAndResponses.Requests.GameInfos;
using IndieGameZone.Domain.RequestsAndResponses.Requests.GamePlatforms;
using IndieGameZone.Domain.RequestsAndResponses.Requests.Games;
using Mapster;

namespace IndieGameZone.Application.Extensions
{
	public class MappingConfiguration : IRegister
	{
		public void Register(TypeAdapterConfig config)
		{
			config.NewConfig<GamePlatformForCreationDto, GamePlatforms>()
				.Ignore(dest => dest.File);
			config.NewConfig<GamePlatformForUpdateDto, GamePlatforms>()
				.Ignore(dest => dest.File);

			config.NewConfig<GameForCreationDto, Games>()
				.Ignore(dest => dest.CoverImage)
				.Ignore(dest => dest.GamePlatforms)
				.Ignore(dest => dest.GameImages);
			config.NewConfig<GameForUpdateDto, Games>()
				.Ignore(dest => dest.CoverImage)
				.Ignore(dest => dest.GamePlatforms)
				.Ignore(dest => dest.GameImages);

			config.NewConfig<GameInfoForCreationDto, GameImages>()
				.Ignore(dest => dest.Image);
			config.NewConfig<GameInfoForUpdateDto, GameImages>()
				.Ignore(dest => dest.Image);
		}
	}
}
