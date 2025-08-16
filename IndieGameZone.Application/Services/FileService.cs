using Cloudmersive.APIClient.NET.VirusScan.Api;
using Cloudmersive.APIClient.NET.VirusScan.Client;
using Cloudmersive.APIClient.NET.VirusScan.Model;
using IndieGameZone.Application.IServices;
using IndieGameZone.Domain.Constants;
using IndieGameZone.Domain.Exceptions;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;
using System.Security.Cryptography;

namespace IndieGameZone.Application.Services
{
	public class FileService : IFileService
	{
		private readonly IConfiguration configuration;
		private readonly IBlobService blobService;

		public FileService(IConfiguration configuration, IBlobService blobService)
		{
			this.configuration = configuration;
			this.blobService = blobService;
		}
		private void CheckingFile(IFormFile file)
		{
			if (file == null || file.Length == 0)
			{
				throw new BadRequestException("No file uploaded.");
			}
			if (!file.FileName.EndsWith(".jpg") && !file.FileName.EndsWith(".png") &&
				!file.FileName.EndsWith(".rar") && !file.FileName.EndsWith(".zip") &&
				!file.FileName.EndsWith(".exe") && !file.FileName.EndsWith(".webp"))
			{
				throw new BadRequestException("File type is not supported. Only .jpg, .png, .rar, .zip, .exe and .webp files are allowed.");
			}
		}
		private void ScanFile(IFormFile file)
		{
			if (file.FileName.EndsWith(".jpg") || file.FileName.EndsWith(".png") || file.FileName.EndsWith(".webp")) return;
			var cloudmersiveConfiguration = new Configuration();
			cloudmersiveConfiguration.AddApiKey("Apikey", configuration.GetSection("CloudmersiveAPIKey").Value);
			var apiInstance = new ScanApi(cloudmersiveConfiguration);

			using (var stream = file.OpenReadStream())
			{
				VirusScanResult result = apiInstance.ScanFile(stream);
				if (!result.CleanResult)
				{
					throw new BadRequestException("File scan failed. Please ensure the file is safe and appropriate.");
				}
			}
		}

		private string GenerateRandomPassword(int length)
		{
			const string validChars = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890!@#$%^&*()_+";
			using var rng = RandomNumberGenerator.Create();
			var bytes = new byte[length];
			rng.GetBytes(bytes);
			var chars = bytes.Select(b => validChars[b % validChars.Length]);
			return new string(chars.ToArray());
		}

		public async Task<(string url, string password)> UploadScanFile(IFormFile file)
		{
			CheckingFile(file);
			ScanFile(file);
			if (file.FileName.EndsWith(".rar") || file.FileName.EndsWith(".zip") || file.FileName.EndsWith(".exe"))
			{
				var password = GenerateRandomPassword(12);
				var url = await blobService.UploadBlob(
					$"{Guid.NewGuid()}{Path.GetExtension(file.FileName)}",
					StorageContainer.STORAGE_CONTAINER,
					file,
					password);
				return (url, password);
			}
			else
			{
				var url = await blobService.UploadBlob(
				$"{Guid.NewGuid()}{Path.GetExtension(file.FileName)}",
				StorageContainer.STORAGE_CONTAINER,
				file);
				return (url, "");
			}
		}
	}
}
