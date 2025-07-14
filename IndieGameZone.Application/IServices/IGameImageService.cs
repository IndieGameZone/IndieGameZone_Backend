namespace IndieGameZone.Application.IServices
{
	public interface IGameImageService
	{
		Task UpdateGameImages(Guid gameId, ICollection<string> images, CancellationToken ct = default);
	}
}
