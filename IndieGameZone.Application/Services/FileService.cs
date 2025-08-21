using Azure.Storage;
using Azure.Storage.Blobs;
using Azure.Storage.Blobs.Models;
using Cloudmersive.APIClient.NET.VirusScan.Api;
using Cloudmersive.APIClient.NET.VirusScan.Client;
using Cloudmersive.APIClient.NET.VirusScan.Model;
using IndieGameZone.Application.IServices;
using IndieGameZone.Domain.Constants;
using IndieGameZone.Domain.Exceptions;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;

namespace IndieGameZone.Application.Services
{
	public class FileService : IFileService
	{
		private readonly IConfiguration configuration;
		private readonly IBlobService blobService;
		private readonly BlobServiceClient blobServiceClient;

		public FileService(IConfiguration configuration, IBlobService blobService, BlobServiceClient blobServiceClient)
		{
			this.configuration = configuration;
			this.blobService = blobService;
			this.blobServiceClient = blobServiceClient;
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
		private async Task<string> ScanFile(IFormFile file, CancellationToken ct = default)
		{
			if (file.FileName.EndsWith(".jpg") || file.FileName.EndsWith(".png") || file.FileName.EndsWith(".webp"))
			{
				return await blobService.UploadBlob(
				$"{Guid.NewGuid()}{Path.GetExtension(file.FileName)}",
				StorageContainer.STORAGE_CONTAINER,
				file);
			}
			var cloudmersiveConfiguration = new Configuration();
			cloudmersiveConfiguration.AddApiKey("Apikey", configuration.GetSection("CloudmersiveAPIKey").Value);
			var apiInstance = new ScanApi(cloudmersiveConfiguration);

			using (var memoryStream = file.OpenReadStream())
			{
				memoryStream.Position = 0;
				VirusScanResult scanResult = await apiInstance.ScanFileAsync(memoryStream, cancellationToken: ct);
				if (scanResult == null)
					throw new InvalidOperationException("Cloudmersive scan returned null response");
				if (!scanResult.CleanResult)
				{
					throw new BadRequestException("File scan failed. Please ensure the file is safe and appropriate.");
				}

				memoryStream.Position = 0;
				var blobName = $"{Guid.NewGuid()}{Path.GetExtension(file.FileName)}";
				BlobContainerClient containerClient = blobServiceClient.GetBlobContainerClient(StorageContainer.STORAGE_CONTAINER);
				BlobClient blobClient = containerClient.GetBlobClient(blobName);

				BlobUploadOptions uploadOptions = new BlobUploadOptions
				{
					TransferOptions = new StorageTransferOptions
					{
						InitialTransferSize = 4 * 1024 * 1024, // 4MB
						MaximumTransferSize = 4 * 1024 * 1024, // 4MB
						MaximumConcurrency = 4
					},
					HttpHeaders = new BlobHttpHeaders
					{
						ContentType = file.ContentType,
						ContentDisposition = $"attachment; filename=\"{file.FileName}\""
					},
					Metadata = new Dictionary<string, string>
					{
						{ "OriginalName", file.FileName },
						{ "UploadDate", DateTime.Now.ToString("o") }
					}
				};

				var uploadResult = await blobClient.UploadAsync(memoryStream, uploadOptions);
				if (uploadResult is not null)
				{
					return await blobService.GetBlob(blobName, StorageContainer.STORAGE_CONTAINER);
				}
				return "";
			}
		}

		private async Task<string> ScanBlobFile(IFormFile file)
		{
			var blobName = $"{Guid.NewGuid()}{Path.GetExtension(file.FileName)}";
			var blobUrl = await blobService.UploadBlob(blobName, StorageContainer.STORAGE_CONTAINER, file);

			var cloudmersiveConfiguration = new Configuration();
			cloudmersiveConfiguration.AddApiKey("Apikey", configuration.GetSection("CloudmersiveAPIKey").Value);
			var apiInstance = new ScanCloudStorageApi(cloudmersiveConfiguration);

			CloudStorageVirusScanResult result = await apiInstance.ScanCloudStorageScanAzureBlobAsync(configuration.GetSection("StorageAccount").Value, StorageContainer.STORAGE_CONTAINER, blobName);
			if (!result.CleanResult)
			{
				await blobService.DeleteBlob(blobName, StorageContainer.STORAGE_CONTAINER);
				throw new BadRequestException("File scan failed. Please ensure the file is safe and appropriate.");
			}
			return blobUrl;
		}

		public async Task<string> UploadScanFile(IFormFile file, CancellationToken ct = default)
		{
			CheckingFile(file);
			return await ScanFile(file, ct);
		}
	}
}
