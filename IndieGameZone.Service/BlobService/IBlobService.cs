using Microsoft.AspNetCore.Http;

namespace IndieGameZone.Application.BlobService
{
	public interface IBlobService
	{
		Task<string> GetBlob(string blobName, string containerName);
		Task<bool> DeleteBlob(string blobName, string containerName);
		Task<string> UploadBlob(string blobName, string containerName, IFormFile file);
		Task<List<string>> UploadBlobs(string blobName, string containerName, IFormFileCollection files);
	}
}
