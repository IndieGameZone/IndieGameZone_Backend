namespace IndieGameZone.Application.AlgoliaServices
{
	public interface IAlgoliaService
	{
		Task UploadGamesToAlgolia(CancellationToken ct = default);
		Task UploadGameToAlgolia(Guid gameId, CancellationToken ct = default);
		Task SendEventToAlgolia(string eventType, string eventName, string userToken, string objectID, CancellationToken ct = default);
		Task<string> GetPersonalizedRecommendations(string userToken);
	}
}
