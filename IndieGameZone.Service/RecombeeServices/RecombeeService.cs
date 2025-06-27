using IndieGameZone.Domain.IRepositories;
using IndieGameZone.Domain.RequestsAndResponses.Responses.Games;
using MapsterMapper;
using Microsoft.Extensions.Configuration;
using Recombee.ApiClient;
using Recombee.ApiClient.ApiRequests;
using Recombee.ApiClient.Bindings;
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

		public async Task GetRecommendedGamesForUser(Guid userId)
		{
			RecommendationResponse result = await client.SendAsync(new RecommendItemsToUser(userId.ToString(), 5));
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

		public async Task PushGameToRecombee(Guid gameId)
		{
			var gameEntity = await repositoryManager.GameRepository.GetGameById(gameId, false);
			var game = mapper.Map<GameForRecommendationDto>(gameEntity);
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

		public async Task RemoveGameFromRecombee(Guid gameId)
		{
			await client.SendAsync(new DeleteItem(gameId.ToString()));
		}

		public async Task SendBookmarkEvent(Guid userId, Guid gameId)
		{
			await client.SendAsync(new AddBookmark(userId.ToString(), gameId.ToString(), timestamp: DateTime.Now, cascadeCreate: true));
		}

		public async Task SendDetailViewEvent(Guid userId, Guid gameId)
		{
			await client.SendAsync(new AddDetailView(userId.ToString(), gameId.ToString(), timestamp: DateTime.Now, cascadeCreate: true));
		}

		public async Task SendPurchaseEvent(Guid userId, Guid gameId)
		{
			await client.SendAsync(new AddPurchase(userId.ToString(), gameId.ToString(), timestamp: DateTime.Now, cascadeCreate: true));
		}

		public async Task SendRatingEvent(Guid userId, Guid gameId, double rating)
		{
			await client.SendAsync(new AddRating(userId.ToString(), gameId.ToString(), rating, timestamp: DateTime.Now, cascadeCreate: true));
		}
	}
}
