using IndieGameZone.Domain.Entities;
using IndieGameZone.Domain.RequestsAndResponses.Requests.GameImages;
using IndieGameZone.Domain.RequestsAndResponses.Requests.GamePlatforms;
using IndieGameZone.Domain.RequestsAndResponses.Requests.Games;
using IndieGameZone.Domain.RequestsAndResponses.Requests.Posts;
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

			config.NewConfig<GameImageForCreationDto, GameImages>()
				.Ignore(dest => dest.Image);
			config.NewConfig<GameImageForUpdateDto, GameImages>()
				.Ignore(dest => dest.Image);

			config.NewConfig<PostForCreationDto, Posts>()
				.Ignore(dest => dest.Image);
			config.NewConfig<PostForUpdateDto, Posts>()
				.Ignore(dest => dest.Image);
		}
	}
}
