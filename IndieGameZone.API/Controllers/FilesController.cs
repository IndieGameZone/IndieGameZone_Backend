using IndieGameZone.Application.AIService;
using IndieGameZone.Application.BlobService;
using IndieGameZone.Domain.Constants;
using Microsoft.AspNetCore.Mvc;
using System.Net.Http.Headers;
using System.Text.Json;

namespace IndieGameZone.API.Controllers
{
	[Route("api")]
	[ApiController]
	public class FilesController : ControllerBase
	{
		private readonly IBlobService blobService;
		private readonly IAIService aIService;
		private readonly IConfiguration configuration;
		private readonly HttpClient httpClient;

		public FilesController(IBlobService blobService, IAIService aIService, IConfiguration configuration, HttpClient httpClient)
		{
			this.blobService = blobService;
			this.aIService = aIService;
			this.configuration = configuration;
			this.httpClient = httpClient;
		}

		private async Task<string> GetUploadUrlAsync()
		{
			httpClient.DefaultRequestHeaders.Clear();
			httpClient.DefaultRequestHeaders.Add("x-apikey", configuration.GetSection("TotalVirusAPIKey").Value);
			httpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

			var urlResponse = await httpClient.GetAsync("https://www.virustotal.com/api/v3/files/upload_url");
			var urlContent = await urlResponse.Content.ReadAsStringAsync();
			Console.WriteLine(urlContent);
			using var jsonDocUrl = JsonDocument.Parse(urlContent);
			string uploadUrl = jsonDocUrl.RootElement.GetProperty("data").GetString() ?? string.Empty;
			return uploadUrl;
		}

		private async Task<string> UploadFileToVirusTotalAsync(IFormFile file, string uploadUrl)
		{
			using var content = new MultipartFormDataContent();
			using var fileStream = file.OpenReadStream();
			var streamContent = new StreamContent(fileStream);
			streamContent.Headers.ContentType = new MediaTypeHeaderValue(file.ContentType ?? "application/octet-stream");
			streamContent.Headers.ContentDisposition = new ContentDispositionHeaderValue("form-data")
			{
				Name = "\"file\"",
				FileName = $"\"{file.FileName}\""
			};
			content.Add(streamContent, "file", file.FileName);

			httpClient.DefaultRequestHeaders.Clear();
			httpClient.DefaultRequestHeaders.Add("x-apikey", configuration.GetSection("TotalVirusAPIKey").Value);
			httpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

			var uploadResponse = await httpClient.PostAsync(uploadUrl, content);
			var uploadContent = await uploadResponse.Content.ReadAsStringAsync();
			Console.WriteLine(uploadContent);
			using var jsonDocUpload = JsonDocument.Parse(uploadContent);
			var analystId = jsonDocUpload.RootElement.GetProperty("data").GetProperty("id").GetString() ?? string.Empty;
			return analystId;
		}

		private async Task<(string Status, int MaliciousCount, int SuspiciousCount)> GetAnalysisResultsAsync(string analysisId)
		{
			httpClient.DefaultRequestHeaders.Clear();
			httpClient.DefaultRequestHeaders.Add("x-apikey", configuration.GetSection("TotalVirusAPIKey").Value);
			httpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

			var analystResponse = await httpClient.GetAsync($"https://www.virustotal.com/api/v3/analyses/{analysisId}");
			var analystContent = await analystResponse.Content.ReadAsStringAsync();
			using var jsonDocAnalyst = JsonDocument.Parse(analystContent);
			var attributes = jsonDocAnalyst.RootElement.GetProperty("data").GetProperty("attributes");
			var status = attributes.GetProperty("status").GetString() ?? string.Empty;
			var maliciousCount = attributes.GetProperty("stats").GetProperty("malicious").GetInt32();
			var suspiciousCount = attributes.GetProperty("stats").GetProperty("suspicious").GetInt32();
			Console.WriteLine($"Status: {status}, Malicious: {maliciousCount}, Suspicious: {suspiciousCount}");

			return (status, maliciousCount, suspiciousCount);
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
				return BadRequest("File type is not supported. Only .jpg, .png, .rar, .zip, .exe and .webp files are allowed.");
			}
			if (file.FileName.EndsWith(".rar") || file.FileName.EndsWith(".zip") || file.FileName.EndsWith(".exe"))
			{
				string uploadUrl = await GetUploadUrlAsync();
				string analysisId = await UploadFileToVirusTotalAsync(file, uploadUrl);
				await Task.Delay(18000);
				var (status, maliciousCount, suspiciousCount) = await GetAnalysisResultsAsync(analysisId);

				if ((maliciousCount > 0 || suspiciousCount > 0) && status.Equals("completed"))
				{
					return BadRequest("File analysis failed. Please ensure the file is safe and appropriate.");
				}
			}
			var uploadedUrl = await blobService.UploadBlob(
					$"{Guid.NewGuid()}*{file.FileName}",
					StorageContainer.STORAGE_CONTAINER,
					file);
			return Ok(uploadedUrl);
		}
	}
}
