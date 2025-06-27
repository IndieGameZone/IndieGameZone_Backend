namespace IndieGameZone.Application.RecombeeServices
{
	public interface IRecombeeService
	{
		Task AddProperty();
		Task PushGamesToRecombee();
		Task RemoveGameFromRecombee(Guid gameId);
		Task PushGameToRecombee(Guid gameId);
		Task SendBookmarkEvent(Guid userId, Guid gameId);
		Task SendPurchaseEvent(Guid userId, Guid gameId);
		Task SendDetailViewEvent(Guid userId, Guid gameId);
		Task SendRatingEvent(Guid userId, Guid gameId, double rating);
		Task GetRecommendedGamesForUser(Guid userId);
	}
}
