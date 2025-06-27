using IndieGameZone.Domain.Entities;

namespace IndieGameZone.Domain.IRepositories
{
	public interface IGameRecommendationRepository
	{
		void AddRecommendations(IEnumerable<GameRecommendations> recommendations);
		void RemoveRecommendations(IEnumerable<GameRecommendations> recommendations);
		Task<IEnumerable<GameRecommendations>> GetRecommendationsByUserId(Guid userId, bool trackChanges, CancellationToken ct = default);
	}
}
