using IndieGameZone.Domain.Entities;
using IndieGameZone.Domain.RequestsAndResponses.Requests.Games;
using IndieGameZone.Domain.RequestsAndResponses.Requests.Posts;
using IndieGameZone.Domain.RequestsAndResponses.Responses.Games;
using Mapster;

namespace IndieGameZone.Application.Extensions
{
	public class MappingConfiguration : IRegister
	{
		public void Register(TypeAdapterConfig config)
		{
			config.NewConfig<PostForCreationDto, Posts>()
				.Ignore(dest => dest.Image);
			config.NewConfig<PostForUpdateDto, Posts>()
				.Ignore(dest => dest.Image);

			config.NewConfig<GameForCreationDto, Games>()
				.Ignore(dest => dest.GameImages);
			config.NewConfig<GameForUpdateDto, Games>()
				.Ignore(dest => dest.GameImages);

			config.NewConfig<Games, GameForAlgoliaDto>()
				.Map(dest => dest.ObjectID, src => src.Id)
				.Map(dest => dest.Category, src => src.Category.Name)
				.Map(dest => dest.Tags, src => src.GameTags.Select(gt => gt.Tag.Name).ToList());
		}
	}
}
