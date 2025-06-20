using IndieGameZone.Application.AIService;
using IndieGameZone.Application.BlobService;
using IndieGameZone.Domain.Constants;
using Microsoft.AspNetCore.Mvc;
using System.Text.Json;
using System.Web;

namespace IndieGameZone.API.Controllers
{
	[Route("api")]
	[ApiController]
	public class FilesController : ControllerBase
	{
		private readonly IBlobService blobService;
		private readonly IAIService aIService;
		private readonly IConfiguration configuration;

		public FilesController(IBlobService blobService, IAIService aIService, IConfiguration configuration)
		{
			this.blobService = blobService;
			this.aIService = aIService;
			this.configuration = configuration;
		}

		[HttpPost("files")]
		public async Task<IActionResult> UploadImage(IFormFile file)
		{
			if (file == null || file.Length == 0)
			{
				return BadRequest("No file uploaded.");
			}
			if (!file.FileName.EndsWith(".jpg") && !file.FileName.EndsWith(".png") &&
				!file.FileName.EndsWith(".rar") && !file.FileName.EndsWith(".zip") &&
				!file.FileName.EndsWith(".exe") && !file.FileName.EndsWith(".webp"))
			{
				return BadRequest("File type is not supported. Only .jpg, .png, .rar, .zip, and .exe files are allowed.");
			}
			var uploadedUrl = await blobService.UploadBlob(
						$"{Guid.NewGuid()}{Path.GetExtension(file.FileName)}",
						StorageContainer.STORAGE_CONTAINER,
						file);
			if (file.FileName.EndsWith(".jpg") || file.FileName.EndsWith(".png") || file.FileName.EndsWith(".webp"))
			{
				if (!await aIService.AnalyzeImage(uploadedUrl))
				{
					await blobService.DeleteBlob(uploadedUrl.Split('/').Last(), StorageContainer.STORAGE_CONTAINER);
					return BadRequest("Image analysis failed. Please ensure the image is appropriate.");
				}
			}
			else if (file.FileName.EndsWith(".rar") || file.FileName.EndsWith(".zip") || file.FileName.EndsWith(".exe"))
			{
				var httpClient = new HttpClient();
				string url = $"https://www.ipqualityscore.com/api/json/url/{configuration.GetSection("IPQualityKey").Value}/{HttpUtility.UrlEncode(uploadedUrl)}";
				var response = await httpClient.GetAsync(url);
				response.EnsureSuccessStatusCode();
				var content = await response.Content.ReadAsStringAsync();
				using var jsonDoc = JsonDocument.Parse(content);
				var isSafe = !jsonDoc.RootElement.GetProperty("unsafe").GetBoolean();
				Console.WriteLine($"{isSafe}");
				if (!isSafe)
				{
					await blobService.DeleteBlob(uploadedUrl.Split('/').Last(), StorageContainer.STORAGE_CONTAINER);
					return BadRequest("File analysis failed. Please ensure the file is safe and appropriate.");
				}

				//var requestUrl = "https://www.virustotal.com/api/v3/urls";

				//// Prepare the form content
				//var formData = new FormUrlEncodedContent(new[]
				//{
				//	new KeyValuePair<string, string>("url", uploadedUrl)
				//});

				//// First request to get analyst Id
				//var request = new HttpRequestMessage(HttpMethod.Post, requestUrl)
				//{
				//	Content = formData
				//};
				//request.Headers.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
				//request.Headers.Add("x-apikey", configuration.GetSection("TotalVirusAPIKey").Value);

				//var response = await httpClient.SendAsync(request);
				//var content = await response.Content.ReadAsStringAsync();

				//var options = new JsonSerializerOptions { PropertyNameCaseInsensitive = true };
				//var result = JsonSerializer.Deserialize<TotalVirusResponse>(content, options);

				//var analystId = result?.data?.id;
				//// Second request to get the analysis results
				//var analystUrl = $"https://www.virustotal.com/api/v3/analyses/{analystId}";
				//var analystRequest = new HttpRequestMessage(HttpMethod.Get, analystUrl);

				//analystRequest.Headers.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
				//analystRequest.Headers.Add("x-apikey", configuration.GetSection("TotalVirusAPIKey").Value);

				//var analystResponse = await httpClient.SendAsync(analystRequest);
				//var analystContent = await analystResponse.Content.ReadAsStringAsync();

				//using var jsonDoc = JsonDocument.Parse(analystContent);
				//var stats = jsonDoc.RootElement.GetProperty("data").GetProperty("attributes").GetProperty("stats");
				//string status = jsonDoc.RootElement.GetProperty("data").GetProperty("attributes").GetProperty("status").GetString() ?? string.Empty;
				//int maliciousCount = stats.GetProperty("malicious").GetInt32();
				//int suspiciousCount = stats.GetProperty("suspicious").GetInt32();
				//int harmlessCount = stats.GetProperty("harmless").GetInt32();
				//int undetectedCount = stats.GetProperty("undetected").GetInt32();
				//int timeoutCount = stats.GetProperty("timeout").GetInt32();


				//if ((maliciousCount > 0 || suspiciousCount > 0) && status.Equals("completed"))
				//{
				//	return BadRequest("File analysis failed. Please ensure the file is safe and appropriate.");
				//}
			}

			return Ok(uploadedUrl);
		}
	}
}
