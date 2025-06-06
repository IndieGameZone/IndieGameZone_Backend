using IndieGameZone.Domain.Entities;
using IndieGameZone.Domain.RequestsAndResponses.Requests.Posts;
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
		}
	}
}
