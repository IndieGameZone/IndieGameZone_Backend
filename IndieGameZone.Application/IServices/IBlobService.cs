using Microsoft.AspNetCore.Http;

namespace IndieGameZone.Application.IServices
{
	public interface IBlobService
	{
		Task<string> GetBlob(string blobName, string containerName);
		Task<bool> DeleteBlob(string blobName, string containerName);
		Task<string> UploadBlob(string blobName, string containerName, IFormFile file);
		Task<string> UploadBlob(string blobName, string containerName, IFormFile file, string password);
		Task<double> GetBlobSize(string blobName, string containerName);
		Task<string> GetBlobOriginalName(string blobName, string containerName);
	}
}
