using Azure.Storage;
using Azure.Storage.Blobs;
using Azure.Storage.Blobs.Models;
using Microsoft.AspNetCore.Http;

namespace IndieGameZone.Application.BlobService
{
	public sealed class BlobService : IBlobService
	{
		private readonly BlobServiceClient blobServiceClient;

		public BlobService(BlobServiceClient blobServiceClient)
		{
			this.blobServiceClient = blobServiceClient;
		}

		public async Task<bool> DeleteBlob(string blobName, string containerName)
		{
			BlobContainerClient containerClient = blobServiceClient.GetBlobContainerClient(containerName);
			BlobClient blobClient = containerClient.GetBlobClient(blobName);

			return await blobClient.DeleteIfExistsAsync();
		}

		public async Task<string> GetBlob(string blobName, string containerName)
		{
			BlobContainerClient containerClient = blobServiceClient.GetBlobContainerClient(containerName);
			BlobClient blobClient = containerClient.GetBlobClient(blobName);
			var exists = await blobClient.ExistsAsync();
			if (!exists.Value)
			{
				throw new FileNotFoundException($"Blob '{blobName}' not found.");
			}
			return blobClient.Uri.AbsoluteUri;
		}

		public async Task<double> GetBlobSize(string blobName, string containerName)
		{
			BlobContainerClient containerClient = blobServiceClient.GetBlobContainerClient(containerName);
			BlobClient blobClient = containerClient.GetBlobClient(blobName);
			var exists = await blobClient.ExistsAsync();
			if (!exists.Value)
			{
				throw new FileNotFoundException($"Blob '{blobName}' not found.");
			}
			var properties = await blobClient.GetPropertiesAsync();
			return properties.Value.ContentLength / (1024.0 * 1024.0); // Size in MB
		}

		public async Task<string> UploadBlob(string blobName, string containerName, IFormFile file)
		{
			BlobContainerClient containerClient = blobServiceClient.GetBlobContainerClient(containerName);
			BlobClient blobClient = containerClient.GetBlobClient(blobName);

			//var httpHeaders = new BlobHttpHeaders
			//{
			//	ContentType = file.ContentType
			//};
			BlobUploadOptions uploadOptions = new BlobUploadOptions
			{
				TransferOptions = new StorageTransferOptions
				{
					InitialTransferSize = 4 * 1024 * 1024, // 4MB
					MaximumTransferSize = 4 * 1024 * 1024, // 4MB
					MaximumConcurrency = 4
				}
			};
			var result = await blobClient.UploadAsync(file.OpenReadStream(), overwrite: true);
			if (result is not null)
			{
				return await GetBlob(blobName, containerName);
			}
			return "";
		}

		public async Task<List<string>> UploadBlobs(string blobName, string containerName, IFormFileCollection files)
		{
			BlobContainerClient containerClient = blobServiceClient.GetBlobContainerClient(containerName);
			BlobClient blobClient = containerClient.GetBlobClient(blobName);
			List<string> uploadedBlobUrls = new List<string>();
			foreach (var file in files)
			{
				if (file.Length > 0)
				{
					var httpHeaders = new BlobHttpHeaders
					{
						ContentType = file.ContentType
					};
					var result = await blobClient.UploadAsync(file.OpenReadStream(), httpHeaders);
					if (result is not null)
					{
						uploadedBlobUrls.Add(blobClient.Uri.AbsoluteUri);
					}
				}
			}
			return uploadedBlobUrls;
		}
	}
}
