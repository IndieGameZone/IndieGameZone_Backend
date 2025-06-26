
using Algolia.Search.Clients;
using IndieGameZone.Domain.IRepositories;
using IndieGameZone.Domain.RequestsAndResponses.Responses.Games;
using MapsterMapper;
using Microsoft.Extensions.Configuration;
using System.Text;
using System.Text.Json;

namespace IndieGameZone.Application.AlgoliaServices
{
	public class AlgoliaService : IAlgoliaService
	{
		private readonly HttpClient httpClient;
		private readonly IRepositoryManager repositoryManager;
		private readonly IMapper mapper;
		private readonly SearchClient client;
		private readonly string algoliaApplicationId;
		private readonly string algoliaWriteApiKey;
		private readonly string algoliaSearchApiKey;
		private const string indexName = "active-games";
		private const string InsightsUrl = "https://insights.algolia.io/1/events";

		public AlgoliaService(IConfiguration configuration, HttpClient httpClient, IRepositoryManager repositoryManager, IMapper mapper)
		{
			this.httpClient = httpClient;
			this.repositoryManager = repositoryManager;
			this.mapper = mapper;
			algoliaApplicationId = configuration.GetSection("AlgoliaApplicationID").Value;
			algoliaWriteApiKey = configuration.GetSection("AlgoliaWriteAPIKey").Value;
			algoliaSearchApiKey = configuration.GetSection("AlgoliaSearchAPIKey").Value;
			client = new SearchClient(algoliaApplicationId, algoliaWriteApiKey);
			httpClient.DefaultRequestHeaders.Add("X-Algolia-Application-Id", algoliaApplicationId);
			httpClient.DefaultRequestHeaders.Add("X-Algolia-API-Key", algoliaWriteApiKey);
		}
		public async Task SendEventToAlgolia(string eventType, string eventName, string userToken, string objectID, CancellationToken ct = default)
		{
			var eventPayload = new
			{
				events = new[]
			{
				new
				{   eventType,
					eventName,
					index = indexName,
					userToken,
					objectIDs = new[] { objectID },
					timestamp = DateTimeOffset.Now.ToUnixTimeMilliseconds()
				}
			}
			};

			var json = JsonSerializer.Serialize(eventPayload);
			var content = new StringContent(json, Encoding.UTF8, "application/json");

			var response = await httpClient.PostAsync(InsightsUrl, content);
			response.EnsureSuccessStatusCode();
		}

		public async Task UploadGamesToAlgolia(CancellationToken ct = default)
		{

			var games = mapper.Map<IEnumerable<GameForRecommendationDto>>(await repositoryManager.GameRepository.GetActiveGames(false, ct));
			// Add record to an index
			await client.SaveObjectsAsync<GameForRecommendationDto>(indexName, games);
		}

		public async Task UploadGameToAlgolia(Guid gameId, CancellationToken ct = default)
		{
			var game = mapper.Map<GameForRecommendationDto>(await repositoryManager.GameRepository.GetGameById(gameId, false, ct));
			var response = await client.SaveObjectAsync(indexName, game);
		}

		public async Task<string> GetPersonalizedRecommendations(string userToken)
		{
			var requestBody = new
			{
				requests = new[]
				{
					new
					{
						indexName,
						userToken,
						model = "personalization",
						maxRecommendations = 5
					}
				}
			};

			var json = JsonSerializer.Serialize(requestBody);
			var content = new StringContent(json, Encoding.UTF8, "application/json");

			using var httpClient = new HttpClient();
			httpClient.DefaultRequestHeaders.Add("X-Algolia-Application-Id", algoliaApplicationId);
			httpClient.DefaultRequestHeaders.Add("X-Algolia-API-Key", algoliaSearchApiKey);

			var response = await httpClient.PostAsync("https://recommendation.algolia.com/1/indexes/*/recommendations", content);
			response.EnsureSuccessStatusCode();

			var resultJson = await response.Content.ReadAsStringAsync();
			var result = JsonSerializer.Deserialize<JsonElement>(resultJson);

			// Extract recommended objectIDs
			var hits = result.GetProperty("results")[0].GetProperty("hits");
			var objectIds = hits.EnumerateArray().Select(hit => hit.GetProperty("objectID").GetString()).ToList();

			return resultJson;
		}
	}
}
