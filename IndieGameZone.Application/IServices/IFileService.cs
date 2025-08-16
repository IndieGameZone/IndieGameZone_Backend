using Microsoft.AspNetCore.Http;

namespace IndieGameZone.Application.IServices
{
	public interface IFileService
	{
		Task<(string url, string password)> UploadScanFile(IFormFile file);
	}
}
