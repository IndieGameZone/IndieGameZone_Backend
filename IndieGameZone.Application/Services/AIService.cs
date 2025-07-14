using Azure;
using Azure.AI.ContentSafety;
using IndieGameZone.Application.IServices;
using Microsoft.Extensions.Configuration;
using OpenAI.Chat;

namespace IndieGameZone.Application.Services
{
	public sealed class AIService : IAIService
	{
		private readonly ContentSafetyClient contentSafetyClient;
		private readonly IConfiguration configuration;

		public AIService(IConfiguration configuration)
		{
			contentSafetyClient = new ContentSafetyClient(
				new Uri(configuration.GetSection("ContentSafetyEndpoint").Value),
				new AzureKeyCredential(configuration.GetSection("ContentSafetyKey").Value));
			this.configuration = configuration;
		}

		public async Task<bool> AnalyzeImage(string? imageUrl, CancellationToken ct = default)
		{
			if (imageUrl == null) return true;

			ContentSafetyImageData image = new ContentSafetyImageData(new Uri(imageUrl));

			var request = new AnalyzeImageOptions(image);
			Response<AnalyzeImageResult> response = await contentSafetyClient.AnalyzeImageAsync(request, ct);
			int hateSeverity = response.Value.CategoriesAnalysis.FirstOrDefault(a => a.Category == ImageCategory.Hate)?.Severity ?? 0;
			int selfHarmSeverity = response.Value.CategoriesAnalysis.FirstOrDefault(a => a.Category == ImageCategory.SelfHarm)?.Severity ?? 0;
			int sexualSeverity = response.Value.CategoriesAnalysis.FirstOrDefault(a => a.Category == ImageCategory.Sexual)?.Severity ?? 0;
			int violenceSeverity = response.Value.CategoriesAnalysis.FirstOrDefault(a => a.Category == ImageCategory.Violence)?.Severity ?? 0;

			return hateSeverity == 0 && selfHarmSeverity == 0 && sexualSeverity == 0 && violenceSeverity == 0;
		}

		public async Task<bool> AnalyzeText(string text, CancellationToken ct = default)
		{
			var request = new AnalyzeTextOptions(text);

			Response<AnalyzeTextResult> response = await contentSafetyClient.AnalyzeTextAsync(request, ct);
			int hateSeverity = response.Value.CategoriesAnalysis.FirstOrDefault(a => a.Category == TextCategory.Hate)?.Severity ?? 0;
			int selfHarmSeverity = response.Value.CategoriesAnalysis.FirstOrDefault(a => a.Category == TextCategory.SelfHarm)?.Severity ?? 0;
			int sexualSeverity = response.Value.CategoriesAnalysis.FirstOrDefault(a => a.Category == TextCategory.Sexual)?.Severity ?? 0;
			int violenceSeverity = response.Value.CategoriesAnalysis.FirstOrDefault(a => a.Category == TextCategory.Violence)?.Severity ?? 0;

			return hateSeverity == 0 && selfHarmSeverity == 0 && sexualSeverity == 0 && violenceSeverity == 0;
		}

		public async Task<string> SummarizeReviews(ICollection<string> text, CancellationToken ct = default)
		{
			var combineText = string.Join(" ", text);
			ChatClient client = new(model: "gpt-4o-mini", apiKey: configuration.GetSection("OpenAIKey").Value);
			string prompt = $"You are a helpful assistant that summarizes game reviews. Please provide a concise summary of the overall sentiment and key points from the following reviews.\n{combineText}";
			ChatCompletion completion = client.CompleteChat(prompt);
			return completion.Content[0].Text;
		}
	}
}
