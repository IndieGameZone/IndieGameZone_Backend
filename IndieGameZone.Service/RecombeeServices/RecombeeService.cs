using IndieGameZone.Domain.IRepositories;
using IndieGameZone.Domain.RequestsAndResponses.Responses.Games;
using MapsterMapper;
using Microsoft.Extensions.Configuration;
using Recombee.ApiClient;
using Recombee.ApiClient.ApiRequests;
using Recombee.ApiClient.Util;

namespace IndieGameZone.Application.RecombeeServices
{
	public class RecombeeService : IRecombeeService
	{
		private readonly RecombeeClient client;
		private readonly IRepositoryManager repositoryManager;
		private readonly IMapper mapper;

		public RecombeeService(IConfiguration configuration, IRepositoryManager repositoryManager, IMapper mapper)
		{
			client = new RecombeeClient(
				configuration.GetSection("RecombeeDevDatabaseId").Value,
				configuration.GetSection("RecombeeDevPrivateToken").Value,
				region: Region.ApSe);
			this.repositoryManager = repositoryManager;
			this.mapper = mapper;
		}

		public async Task AddProperty()
		{
			await client.SendAsync(new AddItemProperty("Name", "string"));
			await client.SendAsync(new AddItemProperty("CoverImage", "image"));
			await client.SendAsync(new AddItemProperty("ShortDescription", "string"));
			await client.SendAsync(new AddItemProperty("Price", "double"));
			await client.SendAsync(new AddItemProperty("Category", "string"));
			await client.SendAsync(new AddItemProperty("Tags", "set"));
		}

		public async Task PushGamesToRecombee()
		{
			await AddProperty();
			var gameEntities = await repositoryManager.GameRepository.GetActiveGames(false);
			var games = mapper.Map<IEnumerable<GameForRecommendationDto>>(gameEntities);
			foreach (var game in games)
			{
				var item = new SetItemValues(
					game.Id.ToString(),
					new Dictionary<string, object>
					{
						{ "Name", game.Name },
						{ "CoverImage", game.CoverImage },
						{ "ShortDescription", game.ShortDescription },
						{ "Price", game.Price },
						{ "Category", game.Category },
						{ "Tags", game.Tags }
					},
					cascadeCreate: true);
				await client.SendAsync(item);
			}
		}
	}
}
