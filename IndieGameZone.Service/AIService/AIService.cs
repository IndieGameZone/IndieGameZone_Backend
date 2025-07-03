using Azure;
using Azure.AI.ContentSafety;
using Azure.AI.TextAnalytics;
using Microsoft.Extensions.Configuration;

namespace IndieGameZone.Application.AIService
{
	public sealed class AIService : IAIService
	{
		private readonly TextAnalyticsClient textAnalyticClient;
		private readonly ContentSafetyClient contentSafetyClient;

		public AIService(IConfiguration configuration)
		{
			contentSafetyClient = new ContentSafetyClient(
				new Uri(configuration.GetSection("ContentSafetyEndpoint").Value),
				new AzureKeyCredential(configuration.GetSection("ContentSafetyKey").Value));
			textAnalyticClient = new TextAnalyticsClient(
				new Uri(configuration.GetSection("TextAnalyticsEndpoint").Value),
				new AzureKeyCredential(configuration.GetSection("TextAnalyticsKey").Value));
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
			string combinedText = string.Join(" ", text);

			var documents = new List<string> { combinedText };

			ExtractiveSummarizeOperation operation = textAnalyticClient.ExtractiveSummarize(WaitUntil.Completed, documents);

			await foreach (ExtractiveSummarizeResultCollection documentsInPage in operation.Value)
			{
				foreach (ExtractiveSummarizeResult documentResult in documentsInPage)
				{
					foreach (ExtractiveSummarySentence sentence in documentResult.Sentences)
					{
						return sentence.Text;
					}
				}
			}

			return string.Empty;

			//var actions = new TextAnalyticsActions
			//{
			//	ExtractiveSummarizeActions = new List<ExtractiveSummarizeAction> { new ExtractiveSummarizeAction() }
			//};

			//// Run the action
			//var operation = await textAnalyticClient.StartAnalyzeActionsAsync(documents, actions);

			//var response = await textAnalyticClient.Ex

			//await operation.WaitForCompletionAsync();

			//var summarySentences = new List<string>();

			//await foreach (var result in operation.Value)
			//{
			//	foreach (var extractSummaryResult in result.ExtractiveSummarizeResults)
			//	{
			//		foreach (var doc in extractSummaryResult.DocumentsResults)
			//		{
			//			summarySentences.AddRange(doc.Sentences.Select(s => s.Text));
			//		}
			//	}
			//}

			//return string.Join(" ", summarySentences);
		}
	}
}
