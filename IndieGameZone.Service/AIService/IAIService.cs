namespace IndieGameZone.Service.AIService
{
	public interface IAIService
	{
		Task<bool> AnalyzeText(string text, CancellationToken ct = default);
		Task<bool> AnalyzeImage(string image, CancellationToken ct = default);
	}
}
