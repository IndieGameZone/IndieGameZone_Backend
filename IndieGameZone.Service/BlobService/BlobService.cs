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

		public async Task<(Stream content, string type, string filename)> DownloadFile(string blobName, string containerName)
		{
			BlobContainerClient containerClient = blobServiceClient.GetBlobContainerClient(containerName);
			BlobClient blobClient = containerClient.GetBlobClient(blobName);
			var exists = await blobClient.ExistsAsync();
			if (!exists.Value)
			{
				throw new FileNotFoundException($"Blob '{blobName}' not found.");
			}
			var blob = await blobClient.DownloadAsync();
			var metadata = (await blobClient.GetPropertiesAsync()).Value.Metadata;
			var originalFileName = metadata.ContainsKey("OriginalName") ? metadata["OriginalName"] : blobName;
			return (blob.Value.Content, blob.Value.Details.ContentType, originalFileName);
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

		public async Task<string> GetBlobOriginalName(string blobName, string containerName)
		{
			BlobContainerClient containerClient = blobServiceClient.GetBlobContainerClient(containerName);
			BlobClient blobClient = containerClient.GetBlobClient(blobName);
			var exists = await blobClient.ExistsAsync();
			if (!exists.Value)
			{
				throw new FileNotFoundException($"Blob '{blobName}' not found.");
			}
			var metadata = (await blobClient.GetPropertiesAsync()).Value.Metadata;
			var originalFileName = metadata.ContainsKey("OriginalName") ? metadata["OriginalName"] : blobName;
			return originalFileName;
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

			BlobUploadOptions uploadOptions = new BlobUploadOptions
			{
				TransferOptions = new StorageTransferOptions
				{
					InitialTransferSize = 4 * 1024 * 1024, // 4MB
					MaximumTransferSize = 4 * 1024 * 1024, // 4MB
					MaximumConcurrency = 4
				},
				Metadata = new Dictionary<string, string>
				{
					{ "OriginalName", file.FileName },
					{ "UploadDate", DateTime.Now.ToString("o") }
				}
			};
			var result = await blobClient.UploadAsync(file.OpenReadStream(), uploadOptions);
			if (result is not null)
			{
				return await GetBlob(blobName, containerName);
			}
			return "";
		}
	}
}
